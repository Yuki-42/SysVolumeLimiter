﻿namespace WinVolumeLimiter
{
    sealed partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnChooseProcess = new System.Windows.Forms.Button();
            this.updownSamplingDelay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProcessName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updownRestoreDelay = new System.Windows.Forms.NumericUpDown();
            this.tbMonitorVolume = new System.Windows.Forms.TrackBar();
            this.tbDuckingVolume = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLinked = new System.Windows.Forms.CheckBox();
            this.tbMasterVolume = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEnabled = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.updownLinkRatio = new System.Windows.Forms.NumericUpDown();
            this.audioLevelsControl = new WinVolumeLimiter.AudioLevelsUIControl();
            ((System.ComponentModel.ISupportInitialize)(this.updownSamplingDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownRestoreDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMonitorVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDuckingVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMasterVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownLinkRatio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseProcess
            // 
            this.btnChooseProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChooseProcess.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnChooseProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseProcess.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnChooseProcess.ForeColor = System.Drawing.Color.Black;
            this.btnChooseProcess.Location = new System.Drawing.Point(7, 271);
            this.btnChooseProcess.Name = "btnChooseProcess";
            this.btnChooseProcess.Size = new System.Drawing.Size(106, 23);
            this.btnChooseProcess.TabIndex = 1;
            this.btnChooseProcess.Text = "Choose Process";
            this.btnChooseProcess.UseVisualStyleBackColor = false;
            this.btnChooseProcess.Click += new System.EventHandler(this.BtnChooseProcess_Click);
            // 
            // updownSamplingDelay
            // 
            this.updownSamplingDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updownSamplingDelay.BackColor = System.Drawing.Color.Black;
            this.updownSamplingDelay.ForeColor = System.Drawing.Color.White;
            this.updownSamplingDelay.Location = new System.Drawing.Point(12, 393);
            this.updownSamplingDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updownSamplingDelay.Name = "updownSamplingDelay";
            this.updownSamplingDelay.Size = new System.Drawing.Size(72, 22);
            this.updownSamplingDelay.TabIndex = 2;
            this.updownSamplingDelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sampling Delay (ms)";
            // 
            // tbProcessName
            // 
            this.tbProcessName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbProcessName.BackColor = System.Drawing.Color.Black;
            this.tbProcessName.Enabled = false;
            this.tbProcessName.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.tbProcessName.ForeColor = System.Drawing.Color.White;
            this.tbProcessName.Location = new System.Drawing.Point(7, 298);
            this.tbProcessName.Name = "tbProcessName";
            this.tbProcessName.ReadOnly = true;
            this.tbProcessName.Size = new System.Drawing.Size(106, 22);
            this.tbProcessName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Restore Delay (ms)";
            // 
            // updownRestoreDelay
            // 
            this.updownRestoreDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updownRestoreDelay.BackColor = System.Drawing.Color.Black;
            this.updownRestoreDelay.ForeColor = System.Drawing.Color.White;
            this.updownRestoreDelay.Location = new System.Drawing.Point(12, 346);
            this.updownRestoreDelay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.updownRestoreDelay.Name = "updownRestoreDelay";
            this.updownRestoreDelay.Size = new System.Drawing.Size(72, 22);
            this.updownRestoreDelay.TabIndex = 6;
            this.updownRestoreDelay.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // tbMonitorVolume
            // 
            this.tbMonitorVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMonitorVolume.LargeChange = 10;
            this.tbMonitorVolume.Location = new System.Drawing.Point(140, 345);
            this.tbMonitorVolume.Maximum = 130;
            this.tbMonitorVolume.Name = "tbMonitorVolume";
            this.tbMonitorVolume.Size = new System.Drawing.Size(231, 45);
            this.tbMonitorVolume.TabIndex = 8;
            this.tbMonitorVolume.TickFrequency = 10;
            this.tbMonitorVolume.Value = 75;
            // 
            // tbDuckingVolume
            // 
            this.tbDuckingVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDuckingVolume.LargeChange = 10;
            this.tbDuckingVolume.Location = new System.Drawing.Point(140, 395);
            this.tbDuckingVolume.Maximum = 100;
            this.tbDuckingVolume.Name = "tbDuckingVolume";
            this.tbDuckingVolume.Size = new System.Drawing.Size(231, 45);
            this.tbDuckingVolume.TabIndex = 9;
            this.tbDuckingVolume.TickFrequency = 10;
            this.tbDuckingVolume.Value = 33;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(144, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Monitor Volume";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(144, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ducking Volume";
            // 
            // cbLinked
            // 
            this.cbLinked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLinked.AutoSize = true;
            this.cbLinked.Checked = true;
            this.cbLinked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLinked.Location = new System.Drawing.Point(307, 274);
            this.cbLinked.Name = "cbLinked";
            this.cbLinked.Size = new System.Drawing.Size(60, 17);
            this.cbLinked.TabIndex = 12;
            this.cbLinked.Text = "Linked";
            this.cbLinked.UseVisualStyleBackColor = true;
            // 
            // tbMasterVolume
            // 
            this.tbMasterVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMasterVolume.LargeChange = 10;
            this.tbMasterVolume.Location = new System.Drawing.Point(7, 440);
            this.tbMasterVolume.Maximum = 100;
            this.tbMasterVolume.Name = "tbMasterVolume";
            this.tbMasterVolume.Size = new System.Drawing.Size(363, 45);
            this.tbMasterVolume.TabIndex = 17;
            this.tbMasterVolume.TickFrequency = 10;
            this.tbMasterVolume.Value = 100;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(9, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Application Master Volume";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 6.5F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(242, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "(Monitor Volume out of 130%)";
            // 
            // cbEnabled
            // 
            this.cbEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbEnabled.AutoSize = true;
            this.cbEnabled.Checked = true;
            this.cbEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEnabled.Location = new System.Drawing.Point(123, 274);
            this.cbEnabled.Name = "cbEnabled";
            this.cbEnabled.Size = new System.Drawing.Size(68, 17);
            this.cbEnabled.TabIndex = 17;
            this.cbEnabled.Text = "Enabled";
            this.cbEnabled.UseVisualStyleBackColor = true;
            this.cbEnabled.CheckedChanged += new System.EventHandler(this.CbEnabled_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(213, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Linking Ratio";
            // 
            // updownLinkRatio
            // 
            this.updownLinkRatio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updownLinkRatio.BackColor = System.Drawing.Color.Black;
            this.updownLinkRatio.DecimalPlaces = 2;
            this.updownLinkRatio.ForeColor = System.Drawing.Color.White;
            this.updownLinkRatio.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.updownLinkRatio.Location = new System.Drawing.Point(294, 298);
            this.updownLinkRatio.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updownLinkRatio.Name = "updownLinkRatio";
            this.updownLinkRatio.Size = new System.Drawing.Size(72, 22);
            this.updownLinkRatio.TabIndex = 14;
            this.updownLinkRatio.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // audioLevelsControl
            // 
            this.audioLevelsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.audioLevelsControl.AudioMonitor = null;
            this.audioLevelsControl.Location = new System.Drawing.Point(0, 0);
            this.audioLevelsControl.Margin = new System.Windows.Forms.Padding(0);
            this.audioLevelsControl.Name = "audioLevelsControl";
            this.audioLevelsControl.Size = new System.Drawing.Size(379, 260);
            this.audioLevelsControl.TabIndex = 0;
            this.audioLevelsControl.Text = "audioLevelsUIControl1";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(377, 477);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbEnabled);
            this.Controls.Add(this.updownLinkRatio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDuckingVolume);
            this.Controls.Add(this.tbMonitorVolume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updownRestoreDelay);
            this.Controls.Add(this.tbProcessName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updownSamplingDelay);
            this.Controls.Add(this.btnChooseProcess);
            this.Controls.Add(this.audioLevelsControl);
            this.Controls.Add(this.tbMasterVolume);
            this.Controls.Add(this.cbLinked);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(302, 423);
            this.Name = "MainForm";
            this.Text = "Windows Volume Limiter";
            ((System.ComponentModel.ISupportInitialize)(this.updownSamplingDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownRestoreDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMonitorVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDuckingVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMasterVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownLinkRatio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AudioLevelsUIControl audioLevelsControl;
        private System.Windows.Forms.Button btnChooseProcess;
        private System.Windows.Forms.NumericUpDown updownSamplingDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProcessName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown updownRestoreDelay;
        private System.Windows.Forms.TrackBar tbMonitorVolume;
        private System.Windows.Forms.TrackBar tbDuckingVolume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbLinked;
        private System.Windows.Forms.NumericUpDown updownLinkRatio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbEnabled;
        private System.Windows.Forms.TrackBar tbMasterVolume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}

