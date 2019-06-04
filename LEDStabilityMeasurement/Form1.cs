using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace LEDStabilityMeasurement
{
    public partial class Form1 : Form
    {
        // measurement settings
        int hzAcq = 10000;

        // analog in counters
        int nSamples = 0;
        int cLost = 0;
        int cCorrupted = 0;
        int cSamples = 0;
        int cAvailable = 0;
        int nMeasurements = 0;
        bool fLost = false;
        bool fCorrupted = false;
        double[] readings;
        double[] averageReading;
        double[] stdvReading;
        public Form1()
        {
            InitializeComponent();
            ListDevices();
        }
        
        // populates the controllor combo box with all available analog discovery boards 
        private void ListDevices ()
        {
            int cDevice = 0;
            string error = "";
            //device info for constructing the display name
            int pDeviceId = 0;
            int pDeviceRevision = 0;
            String szDeviceName = "";
            String deviceData = "";
            String szSN = "";
            //get list / report error
            if (dwf.FDwfEnum(dwf.enumfilterAll, ref cDevice) == 0)
            {
                dwf.FDwfGetLastErrorMsg(out error);
                MessageTextBox.Text = "Error:" + error;
            }
            else
            {
                ControllerComboBox.Items.Clear();
                for (int i = 0; i < cDevice; i++)
                {
                    //get device data
                    dwf.FDwfEnumDeviceName(i, out szDeviceName);
                    dwf.FDwfEnumSN(i, out szSN);
                    dwf.FDwfEnumDeviceType((cDevice - 1), ref pDeviceId, ref pDeviceRevision);
                    //construct name
                    deviceData += szDeviceName;
                    deviceData += " " + szSN;
                    deviceData += " ID" + pDeviceId;
                    deviceData += "." + pDeviceRevision;
                    //add device
                    ControllerComboBox.Items.Add(deviceData);
                }
            }

        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            string error = "";
            int success = 0;
            int available = 0;
            if (ControllerComboBox.Enabled) // if you are not connected
            {
                if (dwf.FDwfEnumDeviceIsOpened(ControllerComboBox.SelectedIndex, ref available) == 0)
                {
                    dwf.FDwfGetLastErrorMsg(out error);
                    MessageTextBox.Text = "Error:" + error;
                }
                else if(available == 0)  // if the device is not already open (available)
                {
                    if (dwf.FDwfDeviceOpen(ControllerComboBox.SelectedIndex, ref success) == 0) //open the device
                    {
                        dwf.FDwfGetLastErrorMsg(out error);
                        MessageTextBox.Text = "Error:" + error;
                    }
                    else if (success == 1) //if you opened successfully
                    {
                        //switch states
                        ControllerComboBox.Enabled = false;
                        ConnectButton.Text = "Disconnect";
                        MeasureButton.Enabled = true;
                    }
                    else
                    {
                        MessageTextBox.Text = "Failed to connect";
                    }
                }
                else
                {
                    MessageTextBox.Text = "Already Connected";
                }
            }
            else //when disconnecting
            {
                dwf.FDwfDeviceClose(ControllerComboBox.SelectedIndex); //close device
                //switch states
                ControllerComboBox.Enabled = true;
                ConnectButton.Text = "Connect";
                MeasureButton.Enabled = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dwf.FDwfDeviceClose(ControllerComboBox.SelectedIndex); //always close device
        }

        private void ControllerComboBox_DropDown(object sender, EventArgs e)
        {
            ListDevices(); //refresh list whenever dropdown openned
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            SaveTextBox.Text = saveFileDialog1.FileName;
            int nReading = averageReading.Length;
            int nOutput = readings.Length;
            try
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine("Measurement Average, Measurement Stdv, Last Measurement"); //create labels

                for (int i = 0; i < nOutput || i < nReading; i++)
                {

                    if (i < nReading) sw.WriteLine(averageReading[i] + "," + stdvReading[i] + ","); // add data
                    else sw.WriteLine(",,");
                    if (i < cSamples) sw.WriteLine(readings[i]);
                }
                sw.Close();
            }
            catch (Exception error)
            {
                MessageTextBox.Text = error.Message;
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        private void MeasureButton_Click(object sender, EventArgs e)
        {
            dwf.FDwfAnalogInChannelEnableSet(1, 0, 1);
            dwf.FDwfAnalogInChannelRangeSet(1, 0, (double)RangeNumericUpDown.Value);
            dwf.FDwfAnalogInAcquisitionModeSet(1, dwf.acqmodeRecord);
            dwf.FDwfAnalogInFrequencySet(1, hzAcq);
            dwf.FDwfAnalogInRecordLengthSet(1, (double)PeriodNumericUpDown.Value);
            nSamples = hzAcq * (int)PeriodNumericUpDown.Value/2;
            cSamples = 0;
            readings = new double[nSamples];
            averageReading = new double[(int)SampleNumericUpDown.Value];
            stdvReading = new double[(int)SampleNumericUpDown.Value];
            nMeasurements = 0;
            ProgressBar.Value = 0;
            dwf.FDwfAnalogOutNodeEnableSet(1, 0, dwf.AnalogOutNodeCarrier, 1);
            dwf.FDwfAnalogOutNodeFunctionSet(1, 0, dwf.AnalogOutNodeCarrier, dwf.funcDC);
            dwf.FDwfAnalogOutNodeOffsetSet(1, 0, dwf.AnalogOutNodeCarrier, (double)DCNumericUpDown.Value);
            SampleTimer.Interval = 2000;
            SampleTimer.Enabled = true;
            MeasureButton.Enabled = false;
        }

        private void MeasureTimer_Tick(object sender, EventArgs e)
        {
            byte status = 0;
            string error = "";
            dwf.FDwfAnalogInConfigure(1, 0, 1);

            if (dwf.FDwfAnalogInStatus(1, 1, ref status)<=0)
            {
                dwf.FDwfGetLastErrorMsg(out error);
                MessageTextBox.Text = "Error: " + error;
                return;
            }
            if (cSamples == 0 && (status == dwf.DwfStateConfig || status == dwf.DwfStatePrefill || status == dwf.DwfStateArmed))
            {
                return;
            }
            dwf.FDwfAnalogInStatusRecord(1, ref cAvailable, ref cLost, ref cCorrupted);

            cSamples += cLost;
            if (cLost > 0) fLost = true;
            if (cCorrupted > 0) fCorrupted = true;
            //if (cAvailable <= 0) return;

            // get samples
            dwf.FDwfAnalogInStatusData(1, 0, readings, cAvailable);
            cSamples += cAvailable;
            if (cSamples >= nSamples)
            {
                double average = 0;
                MeasureTimer.Enabled = false;
                dwf.FDwfAnalogOutConfigure(1, 0, 0);
                dwf.FDwfAnalogInConfigure(1, 0, 0);
                stdvReading[nMeasurements] = calculateStdv(readings, ref average);
                averageReading[nMeasurements] = average;
                averageReading = new double[(int)SampleNumericUpDown.Value];
                stdvReading = new double[(int)SampleNumericUpDown.Value];
                nMeasurements++;
                ProgressBar.Value += (int)Math.Round(100.0 / (double)SampleNumericUpDown.Value);
                if (nMeasurements >= (int)SampleNumericUpDown.Value)
                {
                    OutSTDVTextBox.Text = calculateStdv(averageReading, ref average).ToString();
                    AvgTextBox.Text = average.ToString();
                    InSTDVTextBox.Text = (stdvReading.Sum() / stdvReading.Length).ToString();
                    MessageTextBox.Text = "done";
                    if (fLost) MessageTextBox.Text += ", data lost ";
                    if (fCorrupted) MessageTextBox.Text += ", data corrupted ";
                    MeasureButton.Enabled = true;
                    return;
                }
                SampleTimer.Interval = (int)PeriodNumericUpDown.Value * 1000 / 2;
                SampleTimer.Enabled = true;
            }
        }

        private void SampleTimer_Tick(object sender, EventArgs e)
        {
            dwf.FDwfAnalogOutConfigure(1, 0, 1);
            dwf.FDwfAnalogInConfigure(1, 0, 1);
            cSamples = 0;
            SampleTimer.Enabled = false;
            MeasureTimer.Interval = 500;
            MeasureTimer.Enabled = true;
        }
        private double calculateStdv (double[] array, ref double average)
        {
            double stdv = 0;
            average = array.Sum() / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                stdv += Math.Pow(array[i] - average, 2);
            }
            stdv /= array.Length;
            return Math.Sqrt(stdv);
        }
    }
}
