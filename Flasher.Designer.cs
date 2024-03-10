/* Copyright 2023 Dual Tachyon
 * https://github.com/DualTachyon
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 *     Unless required by applicable law or agreed to in writing, software
 *     distributed under the License is distributed on an "AS IS" BASIS,
 *     WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *     See the License for the specific language governing permissions and
 *     limitations under the License.
 */

namespace RT_890_Flasher {
	partial class Flasher {
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
		private void InitializeComponent()
		{
            this.FilenameBox = new System.Windows.Forms.TextBox();
            this.PickButton = new System.Windows.Forms.Button();
            this.UartLog = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LogButton = new System.Windows.Forms.Button();
            this.BackupButton = new System.Windows.Forms.Button();
            this.EraseButton = new System.Windows.Forms.Button();
            this.FlashButton = new System.Windows.Forms.Button();
            this.CommunicationGroupBox = new System.Windows.Forms.GroupBox();
            this.COMPortLabel = new System.Windows.Forms.Label();
            this.BaudRateLabel = new System.Windows.Forms.Label();
            this.SpeedMode = new System.Windows.Forms.ComboBox();
            this.AutoUART = new System.Windows.Forms.CheckBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.ComPorts = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Progress = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.CommunicationGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilenameBox
            // 
            this.FilenameBox.Location = new System.Drawing.Point(83, 25);
            this.FilenameBox.Margin = new System.Windows.Forms.Padding(2);
            this.FilenameBox.Name = "FilenameBox";
            this.FilenameBox.ReadOnly = true;
            this.FilenameBox.Size = new System.Drawing.Size(215, 20);
            this.FilenameBox.TabIndex = 3;
            // 
            // PickButton
            // 
            this.PickButton.BackColor = System.Drawing.Color.White;
            this.PickButton.Location = new System.Drawing.Point(5, 22);
            this.PickButton.Margin = new System.Windows.Forms.Padding(2);
            this.PickButton.Name = "PickButton";
            this.PickButton.Size = new System.Drawing.Size(74, 26);
            this.PickButton.TabIndex = 4;
            this.PickButton.Text = "&Open";
            this.PickButton.UseVisualStyleBackColor = false;
            this.PickButton.Click += new System.EventHandler(this.PickButton_Click);
            // 
            // UartLog
            // 
            this.UartLog.BackColor = System.Drawing.Color.White;
            this.UartLog.Location = new System.Drawing.Point(4, 18);
            this.UartLog.Margin = new System.Windows.Forms.Padding(2);
            this.UartLog.Multiline = true;
            this.UartLog.Name = "UartLog";
            this.UartLog.ReadOnly = true;
            this.UartLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UartLog.Size = new System.Drawing.Size(293, 182);
            this.UartLog.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PickButton);
            this.groupBox1.Controls.Add(this.FilenameBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 64);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Firmware file";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LogButton);
            this.groupBox2.Controls.Add(this.BackupButton);
            this.groupBox2.Controls.Add(this.EraseButton);
            this.groupBox2.Controls.Add(this.FlashButton);
            this.groupBox2.Location = new System.Drawing.Point(13, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 63);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // LogButton
            // 
            this.LogButton.BackColor = System.Drawing.Color.White;
            this.LogButton.Location = new System.Drawing.Point(230, 22);
            this.LogButton.Margin = new System.Windows.Forms.Padding(2);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(70, 26);
            this.LogButton.TabIndex = 18;
            this.LogButton.Text = "&Log";
            this.LogButton.UseVisualStyleBackColor = false;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // BackupButton
            // 
            this.BackupButton.BackColor = System.Drawing.Color.White;
            this.BackupButton.Location = new System.Drawing.Point(5, 22);
            this.BackupButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(74, 26);
            this.BackupButton.TabIndex = 16;
            this.BackupButton.Text = "&Backup SPI";
            this.BackupButton.UseVisualStyleBackColor = false;
            // 
            // EraseButton
            // 
            this.EraseButton.BackColor = System.Drawing.Color.White;
            this.EraseButton.Enabled = false;
            this.EraseButton.Location = new System.Drawing.Point(156, 22);
            this.EraseButton.Margin = new System.Windows.Forms.Padding(2);
            this.EraseButton.Name = "EraseButton";
            this.EraseButton.Size = new System.Drawing.Size(70, 26);
            this.EraseButton.TabIndex = 15;
            this.EraseButton.Text = "&Erase";
            this.EraseButton.UseVisualStyleBackColor = false;
            // 
            // FlashButton
            // 
            this.FlashButton.BackColor = System.Drawing.Color.White;
            this.FlashButton.Enabled = false;
            this.FlashButton.Location = new System.Drawing.Point(83, 22);
            this.FlashButton.Margin = new System.Windows.Forms.Padding(2);
            this.FlashButton.Name = "FlashButton";
            this.FlashButton.Size = new System.Drawing.Size(70, 26);
            this.FlashButton.TabIndex = 14;
            this.FlashButton.Text = "&Flash";
            this.FlashButton.UseVisualStyleBackColor = false;
            this.FlashButton.Click += new System.EventHandler(this.FlashButton_Click);
            // 
            // CommunicationGroupBox
            // 
            this.CommunicationGroupBox.Controls.Add(this.COMPortLabel);
            this.CommunicationGroupBox.Controls.Add(this.BaudRateLabel);
            this.CommunicationGroupBox.Controls.Add(this.SpeedMode);
            this.CommunicationGroupBox.Controls.Add(this.AutoUART);
            this.CommunicationGroupBox.Controls.Add(this.RefreshButton);
            this.CommunicationGroupBox.Controls.Add(this.ComPorts);
            this.CommunicationGroupBox.Location = new System.Drawing.Point(13, 12);
            this.CommunicationGroupBox.Name = "CommunicationGroupBox";
            this.CommunicationGroupBox.Size = new System.Drawing.Size(303, 109);
            this.CommunicationGroupBox.TabIndex = 20;
            this.CommunicationGroupBox.TabStop = false;
            this.CommunicationGroupBox.Text = "Communication";
            // 
            // COMPortLabel
            // 
            this.COMPortLabel.AutoSize = true;
            this.COMPortLabel.Location = new System.Drawing.Point(145, 27);
            this.COMPortLabel.Name = "COMPortLabel";
            this.COMPortLabel.Size = new System.Drawing.Size(53, 13);
            this.COMPortLabel.TabIndex = 7;
            this.COMPortLabel.Text = "COM Port";
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.AutoSize = true;
            this.BaudRateLabel.Location = new System.Drawing.Point(6, 27);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(58, 13);
            this.BaudRateLabel.TabIndex = 6;
            this.BaudRateLabel.Text = "Baud Rate";
            // 
            // SpeedMode
            // 
            this.SpeedMode.FormattingEnabled = true;
            this.SpeedMode.Items.AddRange(new object[] {
            "115200",
            "19200"});
            this.SpeedMode.Location = new System.Drawing.Point(9, 51);
            this.SpeedMode.Name = "SpeedMode";
            this.SpeedMode.Size = new System.Drawing.Size(100, 21);
            this.SpeedMode.TabIndex = 5;
            this.SpeedMode.SelectedIndexChanged += new System.EventHandler(this.SpeedMode_SelectedIndexChanged);
            // 
            // AutoUART
            // 
            this.AutoUART.AutoSize = true;
            this.AutoUART.Location = new System.Drawing.Point(216, 76);
            this.AutoUART.Name = "AutoUART";
            this.AutoUART.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AutoUART.Size = new System.Drawing.Size(81, 17);
            this.AutoUART.TabIndex = 4;
            this.AutoUART.Text = "Auto UART";
            this.AutoUART.UseVisualStyleBackColor = true;
            this.AutoUART.CheckedChanged += new System.EventHandler(this.AutoUART_CheckedChanged);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(231, 47);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(66, 23);
            this.RefreshButton.TabIndex = 3;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ComPorts
            // 
            this.ComPorts.FormattingEnabled = true;
            this.ComPorts.Location = new System.Drawing.Point(148, 49);
            this.ComPorts.Name = "ComPorts";
            this.ComPorts.Size = new System.Drawing.Size(77, 21);
            this.ComPorts.TabIndex = 0;
            this.ComPorts.SelectedIndexChanged += new System.EventHandler(this.ComPorts_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Progress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 493);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(322, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Progress
            // 
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(300, 16);
            this.Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.UartLog);
            this.groupBox3.Location = new System.Drawing.Point(13, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 205);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "UART log";
            // 
            // Flasher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 515);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.CommunicationGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Flasher";
            this.Text = "Radtel RT-890 Flasher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.CommunicationGroupBox.ResumeLayout(false);
            this.CommunicationGroupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox FilenameBox;
		private System.Windows.Forms.Button PickButton;
		private System.Windows.Forms.TextBox UartLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.Button BackupButton;
        private System.Windows.Forms.Button EraseButton;
        private System.Windows.Forms.Button FlashButton;
        private System.Windows.Forms.GroupBox CommunicationGroupBox;
        private System.Windows.Forms.ComboBox ComPorts;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar Progress;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.CheckBox AutoUART;
        private System.Windows.Forms.Label COMPortLabel;
        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.ComboBox SpeedMode;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

