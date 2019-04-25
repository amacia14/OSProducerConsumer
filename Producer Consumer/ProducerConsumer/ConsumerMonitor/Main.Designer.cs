namespace ConsumerMonitor
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
			this.tpSettings = new System.Windows.Forms.TabPage();
			this.cmdSendSettings = new System.Windows.Forms.Button();
			this.cmdTestConnection = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtbxBaseUrl = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tpResults = new System.Windows.Forms.TabPage();
			this.listView1 = new System.Windows.Forms.ListView();
			this.colThreadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colActive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colSentence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.bkWorker = new System.ComponentModel.BackgroundWorker();
			this.nClients = new System.Windows.Forms.NumericUpDown();
			this.nProducers = new System.Windows.Forms.NumericUpDown();
			this.nBufferSize = new System.Windows.Forms.NumericUpDown();
			this.nPort = new System.Windows.Forms.NumericUpDown();
			this.nConsumerSleep = new System.Windows.Forms.NumericUpDown();
			this.nWordCount = new System.Windows.Forms.NumericUpDown();
			this.nProducerSleep = new System.Windows.Forms.NumericUpDown();
			this.tabControl1.SuspendLayout();
			this.tpSettings.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tpResults.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nClients)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nProducers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nBufferSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nPort)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nConsumerSleep)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nWordCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nProducerSleep)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tpSettings);
			this.tabControl1.Controls.Add(this.tpResults);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.MinimumSize = new System.Drawing.Size(344, 384);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(344, 384);
			this.tabControl1.TabIndex = 0;
			// 
			// tpSettings
			// 
			this.tpSettings.Controls.Add(this.cmdSendSettings);
			this.tpSettings.Controls.Add(this.cmdTestConnection);
			this.tpSettings.Controls.Add(this.groupBox2);
			this.tpSettings.Controls.Add(this.groupBox1);
			this.tpSettings.Location = new System.Drawing.Point(4, 22);
			this.tpSettings.Name = "tpSettings";
			this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
			this.tpSettings.Size = new System.Drawing.Size(336, 358);
			this.tpSettings.TabIndex = 0;
			this.tpSettings.Text = "Initialize";
			this.tpSettings.UseVisualStyleBackColor = true;
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
			this.groupBox2.Controls.Add(this.nProducerSleep);
			this.groupBox2.Controls.Add(this.nWordCount);
			this.groupBox2.Controls.Add(this.nConsumerSleep);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(8, 177);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(269, 130);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Optional";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(145, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "Producer Sleep Number (ms):";
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
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(149, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Consumer Sleep Number (ms):";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.nPort);
			this.groupBox1.Controls.Add(this.nBufferSize);
			this.groupBox1.Controls.Add(this.nProducers);
			this.groupBox1.Controls.Add(this.nClients);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtbxBaseUrl);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(3, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(274, 156);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Mandatory";
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
			// tpResults
			// 
			this.tpResults.Controls.Add(this.listView1);
			this.tpResults.Location = new System.Drawing.Point(4, 22);
			this.tpResults.Name = "tpResults";
			this.tpResults.Padding = new System.Windows.Forms.Padding(3);
			this.tpResults.Size = new System.Drawing.Size(336, 358);
			this.tpResults.TabIndex = 2;
			this.tpResults.Text = "Results";
			this.tpResults.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colThreadName,
            this.colActive,
            this.colSentence});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.Location = new System.Drawing.Point(3, 3);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(330, 352);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// colThreadName
			// 
			this.colThreadName.Text = "Thread name";
			// 
			// colActive
			// 
			this.colActive.Text = "Status";
			this.colActive.Width = 54;
			// 
			// colSentence
			// 
			this.colSentence.Text = "Sentence";
			// 
			// bkWorker
			// 
			this.bkWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkWorker_DoWork);
			// 
			// nClients
			// 
			this.nClients.Location = new System.Drawing.Point(155, 17);
			this.nClients.Name = "nClients";
			this.nClients.Size = new System.Drawing.Size(100, 20);
			this.nClients.TabIndex = 9;
			// 
			// nProducers
			// 
			this.nProducers.Location = new System.Drawing.Point(155, 46);
			this.nProducers.Name = "nProducers";
			this.nProducers.Size = new System.Drawing.Size(100, 20);
			this.nProducers.TabIndex = 10;
			// 
			// nBufferSize
			// 
			this.nBufferSize.Location = new System.Drawing.Point(155, 73);
			this.nBufferSize.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.nBufferSize.Name = "nBufferSize";
			this.nBufferSize.Size = new System.Drawing.Size(100, 20);
			this.nBufferSize.TabIndex = 11;
			// 
			// nPort
			// 
			this.nPort.Location = new System.Drawing.Point(155, 124);
			this.nPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.nPort.Name = "nPort";
			this.nPort.Size = new System.Drawing.Size(100, 20);
			this.nPort.TabIndex = 12;
			// 
			// nConsumerSleep
			// 
			this.nConsumerSleep.Location = new System.Drawing.Point(150, 17);
			this.nConsumerSleep.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
			this.nConsumerSleep.Name = "nConsumerSleep";
			this.nConsumerSleep.Size = new System.Drawing.Size(100, 20);
			this.nConsumerSleep.TabIndex = 13;
			// 
			// nWordCount
			// 
			this.nWordCount.Location = new System.Drawing.Point(150, 48);
			this.nWordCount.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
			this.nWordCount.Name = "nWordCount";
			this.nWordCount.Size = new System.Drawing.Size(100, 20);
			this.nWordCount.TabIndex = 14;
			// 
			// nProducerSleep
			// 
			this.nProducerSleep.Location = new System.Drawing.Point(150, 78);
			this.nProducerSleep.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
			this.nProducerSleep.Name = "nProducerSleep";
			this.nProducerSleep.Size = new System.Drawing.Size(100, 20);
			this.nProducerSleep.TabIndex = 15;
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
			this.tpSettings.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tpResults.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nClients)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nProducers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nBufferSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nPort)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nConsumerSleep)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nWordCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nProducerSleep)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tpSettings;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtbxBaseUrl;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button cmdTestConnection;
		private System.Windows.Forms.Button cmdSendSettings;
		private System.Windows.Forms.TabPage tpResults;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader colThreadName;
		private System.Windows.Forms.ColumnHeader colActive;
		private System.Windows.Forms.ColumnHeader colSentence;
		private System.ComponentModel.BackgroundWorker bkWorker;
		private System.Windows.Forms.NumericUpDown nProducerSleep;
		private System.Windows.Forms.NumericUpDown nWordCount;
		private System.Windows.Forms.NumericUpDown nConsumerSleep;
		private System.Windows.Forms.NumericUpDown nPort;
		private System.Windows.Forms.NumericUpDown nBufferSize;
		private System.Windows.Forms.NumericUpDown nProducers;
		private System.Windows.Forms.NumericUpDown nClients;
	}
}

