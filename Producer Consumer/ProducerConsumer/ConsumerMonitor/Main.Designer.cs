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
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.listView1 = new System.Windows.Forms.ListView();
			this.colThreadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colActive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colSentence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.tabControl1.SuspendLayout();
			this.tbpInit.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tbpInit);
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
			this.txtbxProducerSleep.Text = "50";
			this.txtbxProducerSleep.TextChanged += new System.EventHandler(this.txtbxProducerSleep_TextChanged);
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
			// txtbxWordCount
			// 
			this.txtbxWordCount.Location = new System.Drawing.Point(150, 47);
			this.txtbxWordCount.Name = "txtbxWordCount";
			this.txtbxWordCount.Size = new System.Drawing.Size(100, 20);
			this.txtbxWordCount.TabIndex = 3;
			this.txtbxWordCount.Text = "1000";
			this.txtbxWordCount.TextChanged += new System.EventHandler(this.txtbxWordCount_TextChanged);
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
			this.txtbxConsumerSleep.Text = "100";
			this.txtbxConsumerSleep.TextChanged += new System.EventHandler(this.txtbxConsumerSleep_TextChanged);
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
			this.txtbxClients.TextChanged += new System.EventHandler(this.txtbxClients_TextChanged);
			// 
			// txtbxBufferSize
			// 
			this.txtbxBufferSize.Location = new System.Drawing.Point(155, 72);
			this.txtbxBufferSize.Name = "txtbxBufferSize";
			this.txtbxBufferSize.Size = new System.Drawing.Size(100, 20);
			this.txtbxBufferSize.TabIndex = 5;
			this.txtbxBufferSize.TextChanged += new System.EventHandler(this.txtbxBufferSize_TextChanged);
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
			this.txtbxProducers.TextChanged += new System.EventHandler(this.txtbxProducers_TextChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.listView1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(336, 358);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "Results";
			this.tabPage1.UseVisualStyleBackColor = true;
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
			this.tabPage1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tbpInit;
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
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader colThreadName;
		private System.Windows.Forms.ColumnHeader colActive;
		private System.Windows.Forms.ColumnHeader colSentence;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}

