﻿namespace ConsumerMonitor
{
	partial class Main
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

		
		#region generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tbpInit = new System.Windows.Forms.TabPage();
			this.cmdSendSettings = new System.Windows.Forms.Button();
			this.cmdTestConnection = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtbxProducerSleep = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtbxWordCount = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtbxConsumerSleep = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtbxPort = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtbxBaseUrl = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtbxClients = new System.Windows.Forms.TextBox();
			this.txtbxBufferSize = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtbxProducers = new System.Windows.Forms.TextBox();
			this.tbpOptions = new System.Windows.Forms.TabPage();
			this.cmdSendSetting = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.tbpInit.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tbpOptions.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tbpInit);
			this.tabControl1.Controls.Add(this.tbpOptions);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.MinimumSize = new System.Drawing.Size(344, 384);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(344, 384);
			this.tabControl1.TabIndex = 0;
			// 
			// tbpInit
			// 
			this.tbpInit.Controls.Add(this.cmdSendSettings);
			this.tbpInit.Controls.Add(this.cmdTestConnection);
			this.tbpInit.Controls.Add(this.groupBox2);
			this.tbpInit.Controls.Add(this.groupBox1);
			this.tbpInit.Location = new System.Drawing.Point(4, 22);
			this.tbpInit.Name = "tbpInit";
			this.tbpInit.Padding = new System.Windows.Forms.Padding(3);
			this.tbpInit.Size = new System.Drawing.Size(336, 358);
			this.tbpInit.TabIndex = 0;
			this.tbpInit.Text = "Initialize";
			this.tbpInit.UseVisualStyleBackColor = true;
			// 
			// cmdSendSettings
			// 
			this.cmdSendSettings.Location = new System.Drawing.Point(202, 313);
			this.cmdSendSettings.Name = "cmdSendSettings";
			this.cmdSendSettings.Size = new System.Drawing.Size(75, 23);
			this.cmdSendSettings.TabIndex = 9;
			this.cmdSendSettings.Text = "Set up Settings";
			this.cmdSendSettings.UseVisualStyleBackColor = true;
			this.cmdSendSettings.Click += new System.EventHandler(this.cmdSendSettings_Click);
			// 
			// cmdTestConnection
			// 
			this.cmdTestConnection.Location = new System.Drawing.Point(8, 313);
			this.cmdTestConnection.Name = "cmdTestConnection";
			this.cmdTestConnection.Size = new System.Drawing.Size(102, 23);
			this.cmdTestConnection.TabIndex = 8;
			this.cmdTestConnection.Text = "Test connection";
			this.cmdTestConnection.UseVisualStyleBackColor = true;
			this.cmdTestConnection.Click += new System.EventHandler(this.cmdTestConnection_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtbxProducerSleep);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtbxWordCount);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtbxConsumerSleep);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(8, 177);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(269, 130);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Optional";
			// 
			// txtbxProducerSleep
			// 
			this.txtbxProducerSleep.Location = new System.Drawing.Point(150, 77);
			this.txtbxProducerSleep.Name = "txtbxProducerSleep";
			this.txtbxProducerSleep.Size = new System.Drawing.Size(100, 20);
			this.txtbxProducerSleep.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(120, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "Producer Sleep Number";
			// 
			// txtbxWordCount
			// 
			this.txtbxWordCount.Location = new System.Drawing.Point(150, 47);
			this.txtbxWordCount.Name = "txtbxWordCount";
			this.txtbxWordCount.Size = new System.Drawing.Size(100, 20);
			this.txtbxWordCount.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 50);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(110, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Producer Word Count";
			// 
			// txtbxConsumerSleep
			// 
			this.txtbxConsumerSleep.Location = new System.Drawing.Point(150, 16);
			this.txtbxConsumerSleep.Name = "txtbxConsumerSleep";
			this.txtbxConsumerSleep.Size = new System.Drawing.Size(100, 20);
			this.txtbxConsumerSleep.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(127, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Consumer Sleep Number:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtbxPort);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtbxBaseUrl);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtbxClients);
			this.groupBox1.Controls.Add(this.txtbxBufferSize);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtbxProducers);
			this.groupBox1.Location = new System.Drawing.Point(3, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(274, 156);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Mandatory";
			// 
			// txtbxPort
			// 
			this.txtbxPort.Location = new System.Drawing.Point(155, 126);
			this.txtbxPort.Name = "txtbxPort";
			this.txtbxPort.Size = new System.Drawing.Size(100, 20);
			this.txtbxPort.TabIndex = 9;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 126);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(73, 13);
			this.label8.TabIndex = 8;
			this.label8.Text = "* Port Number";
			// 
			// txtbxBaseUrl
			// 
			this.txtbxBaseUrl.Location = new System.Drawing.Point(155, 98);
			this.txtbxBaseUrl.Name = "txtbxBaseUrl";
			this.txtbxBaseUrl.Size = new System.Drawing.Size(100, 20);
			this.txtbxBaseUrl.TabIndex = 7;
			this.txtbxBaseUrl.Text = "localhost";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(5, 101);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(109, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "* Producer host name";
			// 
			// txtbxClients
			// 
			this.txtbxClients.Location = new System.Drawing.Point(155, 19);
			this.txtbxClients.Name = "txtbxClients";
			this.txtbxClients.Size = new System.Drawing.Size(100, 20);
			this.txtbxClients.TabIndex = 1;
			// 
			// txtbxBufferSize
			// 
			this.txtbxBufferSize.Location = new System.Drawing.Point(155, 72);
			this.txtbxBufferSize.Name = "txtbxBufferSize";
			this.txtbxBufferSize.Size = new System.Drawing.Size(100, 20);
			this.txtbxBufferSize.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "* Number of Client Consumers:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(5, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "* Buffer Size";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(5, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "* Number of Producers";
			// 
			// txtbxProducers
			// 
			this.txtbxProducers.Location = new System.Drawing.Point(155, 45);
			this.txtbxProducers.Name = "txtbxProducers";
			this.txtbxProducers.Size = new System.Drawing.Size(100, 20);
			this.txtbxProducers.TabIndex = 3;
			// 
			// tbpOptions
			// 
			this.tbpOptions.Controls.Add(this.cmdSendSetting);
			this.tbpOptions.Controls.Add(this.groupBox4);
			this.tbpOptions.Location = new System.Drawing.Point(4, 22);
			this.tbpOptions.Name = "tbpOptions";
			this.tbpOptions.Padding = new System.Windows.Forms.Padding(3);
			this.tbpOptions.Size = new System.Drawing.Size(336, 358);
			this.tbpOptions.TabIndex = 1;
			this.tbpOptions.Text = "Options";
			this.tbpOptions.UseVisualStyleBackColor = true;
			// 
			// cmdSendSetting
			// 
			this.cmdSendSetting.Location = new System.Drawing.Point(18, 220);
			this.cmdSendSetting.Name = "cmdSendSetting";
			this.cmdSendSetting.Size = new System.Drawing.Size(84, 23);
			this.cmdSendSetting.TabIndex = 12;
			this.cmdSendSetting.Text = "Send Settings";
			this.cmdSendSetting.UseVisualStyleBackColor = true;
			this.cmdSendSetting.Click += new System.EventHandler(this.cmdSendSetting_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.textBox4);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.textBox5);
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.textBox9);
			this.groupBox4.Controls.Add(this.label17);
			this.groupBox4.Controls.Add(this.textBox6);
			this.groupBox4.Controls.Add(this.textBox7);
			this.groupBox4.Controls.Add(this.label14);
			this.groupBox4.Controls.Add(this.label15);
			this.groupBox4.Controls.Add(this.label16);
			this.groupBox4.Controls.Add(this.textBox8);
			this.groupBox4.Location = new System.Drawing.Point(8, 6);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(274, 208);
			this.groupBox4.TabIndex = 9;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Mandatory";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(154, 162);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 11;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(7, 165);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(120, 13);
			this.label12.TabIndex = 10;
			this.label12.Text = "Producer Sleep Number";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(154, 132);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 20);
			this.textBox5.TabIndex = 9;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(7, 135);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(110, 13);
			this.label13.TabIndex = 8;
			this.label13.Text = "Producer Word Count";
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(154, 101);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(100, 20);
			this.textBox9.TabIndex = 7;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(7, 104);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(127, 13);
			this.label17.TabIndex = 6;
			this.label17.Text = "Consumer Sleep Number:";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(155, 19);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 20);
			this.textBox6.TabIndex = 1;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(155, 72);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(100, 20);
			this.textBox7.TabIndex = 5;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(5, 19);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(143, 13);
			this.label14.TabIndex = 0;
			this.label14.Text = "Number of Client Consumers:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(5, 75);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(58, 13);
			this.label15.TabIndex = 4;
			this.label15.Text = "Buffer Size";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(5, 48);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(107, 13);
			this.label16.TabIndex = 2;
			this.label16.Text = "Number of Producers";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(155, 45);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(100, 20);
			this.textBox8.TabIndex = 3;
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(336, 358);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 384);
			this.Controls.Add(this.tabControl1);
			this.Name = "Main";
			this.Text = "Consumer Monitor";
			this.tabControl1.ResumeLayout(false);
			this.tbpInit.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tbpOptions.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tbpInit;
		private System.Windows.Forms.TabPage tbpOptions;
		private System.Windows.Forms.TextBox txtbxProducers;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtbxClients;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtbxBufferSize;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtbxConsumerSleep;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtbxWordCount;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtbxProducerSleep;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtbxBaseUrl;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtbxPort;
		private System.Windows.Forms.Button cmdTestConnection;
		private System.Windows.Forms.Button cmdSendSettings;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Button cmdSendSetting;
		private System.Windows.Forms.TabPage tabPage1;
	}
}

