namespace LEDStabilityMeasurement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ControllerComboBox = new System.Windows.Forms.ComboBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.ControllorLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SaveTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveGroupBox = new System.Windows.Forms.GroupBox();
            this.ConnectGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DCNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RangeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SampleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PeriodNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.MeasureButton = new System.Windows.Forms.Button();
            this.SampleLabel = new System.Windows.Forms.Label();
            this.PeriodLabel = new System.Windows.Forms.Label();
            this.MeasureTimer = new System.Windows.Forms.Timer(this.components);
            this.SampleTimer = new System.Windows.Forms.Timer(this.components);
            this.AveLabel = new System.Windows.Forms.Label();
            this.AvgTextBox = new System.Windows.Forms.TextBox();
            this.InSTDVTextBox = new System.Windows.Forms.TextBox();
            this.InSTDVLabel = new System.Windows.Forms.Label();
            this.OutSTDVTextBox = new System.Windows.Forms.TextBox();
            this.OutSTDVLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SaveGroupBox.SuspendLayout();
            this.ConnectGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DCNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RangeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SampleNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(280, 14);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(92, 23);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ControllerComboBox
            // 
            this.ControllerComboBox.AllowDrop = true;
            this.ControllerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ControllerComboBox.FormattingEnabled = true;
            this.ControllerComboBox.Location = new System.Drawing.Point(93, 16);
            this.ControllerComboBox.Name = "ControllerComboBox";
            this.ControllerComboBox.Size = new System.Drawing.Size(181, 24);
            this.ControllerComboBox.TabIndex = 2;
            this.ControllerComboBox.DropDown += new System.EventHandler(this.ControllerComboBox_DropDown);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Enabled = false;
            this.MessageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageTextBox.ForeColor = System.Drawing.Color.Red;
            this.MessageTextBox.Location = new System.Drawing.Point(93, 43);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(279, 23);
            this.MessageTextBox.TabIndex = 3;
            // 
            // ControllorLabel
            // 
            this.ControllorLabel.AutoSize = true;
            this.ControllorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControllorLabel.Location = new System.Drawing.Point(3, 19);
            this.ControllorLabel.Name = "ControllorLabel";
            this.ControllorLabel.Size = new System.Drawing.Size(84, 17);
            this.ControllorLabel.TabIndex = 4;
            this.ControllorLabel.Text = "Controller:";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.Location = new System.Drawing.Point(3, 44);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(77, 17);
            this.MessageLabel.TabIndex = 5;
            this.MessageLabel.Text = "Message:";
            // 
            // SaveTextBox
            // 
            this.SaveTextBox.Enabled = false;
            this.SaveTextBox.Location = new System.Drawing.Point(6, 22);
            this.SaveTextBox.Name = "SaveTextBox";
            this.SaveTextBox.Size = new System.Drawing.Size(328, 23);
            this.SaveTextBox.TabIndex = 10;
            this.SaveTextBox.Text = "C:\\";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(340, 22);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(32, 23);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "...";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SaveGroupBox
            // 
            this.SaveGroupBox.Controls.Add(this.SaveTextBox);
            this.SaveGroupBox.Controls.Add(this.SaveButton);
            this.SaveGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveGroupBox.Location = new System.Drawing.Point(6, 257);
            this.SaveGroupBox.Name = "SaveGroupBox";
            this.SaveGroupBox.Size = new System.Drawing.Size(378, 58);
            this.SaveGroupBox.TabIndex = 13;
            this.SaveGroupBox.TabStop = false;
            this.SaveGroupBox.Text = "Save:";
            // 
            // ConnectGroupBox
            // 
            this.ConnectGroupBox.Controls.Add(this.ControllorLabel);
            this.ConnectGroupBox.Controls.Add(this.ConnectButton);
            this.ConnectGroupBox.Controls.Add(this.MessageLabel);
            this.ConnectGroupBox.Controls.Add(this.ControllerComboBox);
            this.ConnectGroupBox.Controls.Add(this.MessageTextBox);
            this.ConnectGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectGroupBox.Location = new System.Drawing.Point(6, 7);
            this.ConnectGroupBox.Name = "ConnectGroupBox";
            this.ConnectGroupBox.Size = new System.Drawing.Size(378, 76);
            this.ConnectGroupBox.TabIndex = 14;
            this.ConnectGroupBox.TabStop = false;
            this.ConnectGroupBox.Text = "Connect";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DCNumericUpDown);
            this.groupBox1.Controls.Add(this.RangeNumericUpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SampleNumericUpDown);
            this.groupBox1.Controls.Add(this.PeriodNumericUpDown);
            this.groupBox1.Controls.Add(this.ProgressBar);
            this.groupBox1.Controls.Add(this.MeasureButton);
            this.groupBox1.Controls.Add(this.SampleLabel);
            this.groupBox1.Controls.Add(this.PeriodLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 109);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Collection";
            // 
            // DCNumericUpDown
            // 
            this.DCNumericUpDown.Location = new System.Drawing.Point(289, 49);
            this.DCNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DCNumericUpDown.Name = "DCNumericUpDown";
            this.DCNumericUpDown.Size = new System.Drawing.Size(81, 23);
            this.DCNumericUpDown.TabIndex = 19;
            this.DCNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RangeNumericUpDown
            // 
            this.RangeNumericUpDown.Location = new System.Drawing.Point(93, 49);
            this.RangeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RangeNumericUpDown.Name = "RangeNumericUpDown";
            this.RangeNumericUpDown.Size = new System.Drawing.Size(81, 23);
            this.RangeNumericUpDown.TabIndex = 18;
            this.RangeNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "DC Out (V):";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Range (V):";
            this.label2.UseMnemonic = false;
            // 
            // SampleNumericUpDown
            // 
            this.SampleNumericUpDown.Location = new System.Drawing.Point(289, 23);
            this.SampleNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SampleNumericUpDown.Name = "SampleNumericUpDown";
            this.SampleNumericUpDown.Size = new System.Drawing.Size(81, 23);
            this.SampleNumericUpDown.TabIndex = 15;
            this.SampleNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // PeriodNumericUpDown
            // 
            this.PeriodNumericUpDown.Location = new System.Drawing.Point(93, 23);
            this.PeriodNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PeriodNumericUpDown.Name = "PeriodNumericUpDown";
            this.PeriodNumericUpDown.Size = new System.Drawing.Size(81, 23);
            this.PeriodNumericUpDown.TabIndex = 14;
            this.PeriodNumericUpDown.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(104, 80);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(266, 23);
            this.ProgressBar.TabIndex = 13;
            // 
            // MeasureButton
            // 
            this.MeasureButton.Location = new System.Drawing.Point(6, 80);
            this.MeasureButton.Name = "MeasureButton";
            this.MeasureButton.Size = new System.Drawing.Size(92, 23);
            this.MeasureButton.TabIndex = 6;
            this.MeasureButton.Text = "Measure";
            this.MeasureButton.UseVisualStyleBackColor = true;
            this.MeasureButton.Click += new System.EventHandler(this.MeasureButton_Click);
            // 
            // SampleLabel
            // 
            this.SampleLabel.AutoSize = true;
            this.SampleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SampleLabel.Location = new System.Drawing.Point(181, 25);
            this.SampleLabel.Name = "SampleLabel";
            this.SampleLabel.Size = new System.Drawing.Size(107, 17);
            this.SampleLabel.TabIndex = 11;
            this.SampleLabel.Text = "# of Samples:";
            this.SampleLabel.UseMnemonic = false;
            // 
            // PeriodLabel
            // 
            this.PeriodLabel.AutoSize = true;
            this.PeriodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeriodLabel.Location = new System.Drawing.Point(6, 25);
            this.PeriodLabel.Name = "PeriodLabel";
            this.PeriodLabel.Size = new System.Drawing.Size(85, 17);
            this.PeriodLabel.TabIndex = 6;
            this.PeriodLabel.Text = "Period (s):";
            this.PeriodLabel.UseMnemonic = false;
            // 
            // MeasureTimer
            // 
            this.MeasureTimer.Tick += new System.EventHandler(this.MeasureTimer_Tick);
            // 
            // SampleTimer
            // 
            this.SampleTimer.Tick += new System.EventHandler(this.SampleTimer_Tick);
            // 
            // AveLabel
            // 
            this.AveLabel.AutoSize = true;
            this.AveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AveLabel.Location = new System.Drawing.Point(6, 19);
            this.AveLabel.Name = "AveLabel";
            this.AveLabel.Size = new System.Drawing.Size(40, 17);
            this.AveLabel.TabIndex = 20;
            this.AveLabel.Text = "Avg:";
            this.AveLabel.UseMnemonic = false;
            // 
            // AvgTextBox
            // 
            this.AvgTextBox.Enabled = false;
            this.AvgTextBox.Location = new System.Drawing.Point(49, 18);
            this.AvgTextBox.Name = "AvgTextBox";
            this.AvgTextBox.Size = new System.Drawing.Size(52, 23);
            this.AvgTextBox.TabIndex = 6;
            // 
            // InSTDVTextBox
            // 
            this.InSTDVTextBox.Enabled = false;
            this.InSTDVTextBox.Location = new System.Drawing.Point(185, 18);
            this.InSTDVTextBox.Name = "InSTDVTextBox";
            this.InSTDVTextBox.Size = new System.Drawing.Size(52, 23);
            this.InSTDVTextBox.TabIndex = 21;
            // 
            // InSTDVLabel
            // 
            this.InSTDVLabel.AutoSize = true;
            this.InSTDVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InSTDVLabel.Location = new System.Drawing.Point(107, 19);
            this.InSTDVLabel.Name = "InSTDVLabel";
            this.InSTDVLabel.Size = new System.Drawing.Size(72, 17);
            this.InSTDVLabel.TabIndex = 22;
            this.InSTDVLabel.Text = "In STDV:";
            this.InSTDVLabel.UseMnemonic = false;
            // 
            // OutSTDVTextBox
            // 
            this.OutSTDVTextBox.Enabled = false;
            this.OutSTDVTextBox.Location = new System.Drawing.Point(321, 19);
            this.OutSTDVTextBox.Name = "OutSTDVTextBox";
            this.OutSTDVTextBox.Size = new System.Drawing.Size(52, 23);
            this.OutSTDVTextBox.TabIndex = 23;
            // 
            // OutSTDVLabel
            // 
            this.OutSTDVLabel.AutoSize = true;
            this.OutSTDVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutSTDVLabel.Location = new System.Drawing.Point(243, 19);
            this.OutSTDVLabel.Name = "OutSTDVLabel";
            this.OutSTDVLabel.Size = new System.Drawing.Size(76, 17);
            this.OutSTDVLabel.TabIndex = 24;
            this.OutSTDVLabel.Text = "O/ STDV:";
            this.OutSTDVLabel.UseMnemonic = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AveLabel);
            this.groupBox2.Controls.Add(this.OutSTDVTextBox);
            this.groupBox2.Controls.Add(this.AvgTextBox);
            this.groupBox2.Controls.Add(this.OutSTDVLabel);
            this.groupBox2.Controls.Add(this.InSTDVLabel);
            this.groupBox2.Controls.Add(this.InSTDVTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 47);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 328);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ConnectGroupBox);
            this.Controls.Add(this.SaveGroupBox);
            this.Name = "Form1";
            this.Text = "LED Stability Measurement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.SaveGroupBox.ResumeLayout(false);
            this.SaveGroupBox.PerformLayout();
            this.ConnectGroupBox.ResumeLayout(false);
            this.ConnectGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DCNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RangeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SampleNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.ComboBox ControllerComboBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label ControllorLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox SaveTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox SaveGroupBox;
        private System.Windows.Forms.GroupBox ConnectGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button MeasureButton;
        private System.Windows.Forms.Label SampleLabel;
        private System.Windows.Forms.Label PeriodLabel;
        private System.Windows.Forms.NumericUpDown SampleNumericUpDown;
        private System.Windows.Forms.NumericUpDown PeriodNumericUpDown;
        private System.Windows.Forms.Timer MeasureTimer;
        private System.Windows.Forms.Timer SampleTimer;
        private System.Windows.Forms.NumericUpDown DCNumericUpDown;
        private System.Windows.Forms.NumericUpDown RangeNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AveLabel;
        private System.Windows.Forms.TextBox AvgTextBox;
        private System.Windows.Forms.TextBox InSTDVTextBox;
        private System.Windows.Forms.Label InSTDVLabel;
        private System.Windows.Forms.TextBox OutSTDVTextBox;
        private System.Windows.Forms.Label OutSTDVLabel;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

