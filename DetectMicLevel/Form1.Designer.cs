namespace DetectMicLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbPeak = new System.Windows.Forms.ProgressBar();
            this.cmbAudioDevices = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.numPeakLevel = new System.Windows.Forms.NumericUpDown();
            this.numConfidence = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKeyboardStatusStart = new System.Windows.Forms.Label();
            this.txtSafeWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblKeyboardStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPeakLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConfidence)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPeak
            // 
            this.pbPeak.Location = new System.Drawing.Point(13, 237);
            this.pbPeak.Name = "pbPeak";
            this.pbPeak.Size = new System.Drawing.Size(945, 374);
            this.pbPeak.TabIndex = 0;
            // 
            // cmbAudioDevices
            // 
            this.cmbAudioDevices.FormattingEnabled = true;
            this.cmbAudioDevices.Location = new System.Drawing.Point(93, 197);
            this.cmbAudioDevices.Name = "cmbAudioDevices";
            this.cmbAudioDevices.Size = new System.Drawing.Size(504, 21);
            this.cmbAudioDevices.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // numPeakLevel
            // 
            this.numPeakLevel.DecimalPlaces = 2;
            this.numPeakLevel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numPeakLevel.Location = new System.Drawing.Point(93, 95);
            this.numPeakLevel.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPeakLevel.Name = "numPeakLevel";
            this.numPeakLevel.Size = new System.Drawing.Size(149, 20);
            this.numPeakLevel.TabIndex = 3;
            this.numPeakLevel.Tag = "";
            this.numPeakLevel.Value = new decimal(new int[] {
            65,
            0,
            0,
            131072});
            // 
            // numConfidence
            // 
            this.numConfidence.DecimalPlaces = 2;
            this.numConfidence.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numConfidence.Location = new System.Drawing.Point(93, 145);
            this.numConfidence.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numConfidence.Name = "numConfidence";
            this.numConfidence.Size = new System.Drawing.Size(149, 20);
            this.numConfidence.TabIndex = 4;
            this.numConfidence.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Peak Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confidence";
            // 
            // lblKeyboardStatusStart
            // 
            this.lblKeyboardStatusStart.AutoSize = true;
            this.lblKeyboardStatusStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblKeyboardStatusStart.Location = new System.Drawing.Point(16, 9);
            this.lblKeyboardStatusStart.Name = "lblKeyboardStatusStart";
            this.lblKeyboardStatusStart.Size = new System.Drawing.Size(102, 24);
            this.lblKeyboardStatusStart.TabIndex = 7;
            this.lblKeyboardStatusStart.Text = "Keyboard -";
            // 
            // txtSafeWord
            // 
            this.txtSafeWord.Location = new System.Drawing.Point(93, 50);
            this.txtSafeWord.Name = "txtSafeWord";
            this.txtSafeWord.Size = new System.Drawing.Size(149, 20);
            this.txtSafeWord.TabIndex = 8;
            this.txtSafeWord.Text = "Sorry";
            this.txtSafeWord.TextChanged += new System.EventHandler(this.txtSafeWord_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Safe Word";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Select Mic";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(625, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 117);
            this.label5.TabIndex = 11;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(624, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Details";
            // 
            // lblKeyboardStatus
            // 
            this.lblKeyboardStatus.AutoSize = true;
            this.lblKeyboardStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblKeyboardStatus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblKeyboardStatus.Location = new System.Drawing.Point(113, 10);
            this.lblKeyboardStatus.Name = "lblKeyboardStatus";
            this.lblKeyboardStatus.Size = new System.Drawing.Size(81, 24);
            this.lblKeyboardStatus.TabIndex = 13;
            this.lblKeyboardStatus.Text = "Enabled";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 635);
            this.Controls.Add(this.lblKeyboardStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSafeWord);
            this.Controls.Add(this.lblKeyboardStatusStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numConfidence);
            this.Controls.Add(this.numPeakLevel);
            this.Controls.Add(this.cmbAudioDevices);
            this.Controls.Add(this.pbPeak);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPeakLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConfidence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbPeak;
        private System.Windows.Forms.ComboBox cmbAudioDevices;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown numPeakLevel;
        private System.Windows.Forms.NumericUpDown numConfidence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKeyboardStatusStart;
        private System.Windows.Forms.TextBox txtSafeWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblKeyboardStatus;
    }
}

