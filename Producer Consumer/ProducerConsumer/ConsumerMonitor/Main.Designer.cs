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
			this.components = new System.ComponentModel.Container();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tpSettings = new System.Windows.Forms.TabPage();
			this.cmdreset = new System.Windows.Forms.Button();
			this.cmdSendSettings = new System.Windows.Forms.Button();
			this.cmdTestConnection = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.nProducerSleep = new System.Windows.Forms.NumericUpDown();
			this.nWordCount = new System.Windows.Forms.NumericUpDown();
			this.nConsumerSleep = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.nBufferSize = new System.Windows.Forms.NumericUpDown();
			this.nProducers = new System.Windows.Forms.NumericUpDown();
			this.nClients = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tpResults = new System.Windows.Forms.TabPage();
			this.lvThreads = new System.Windows.Forms.ListView();
			this.colThreadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colActive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colSentence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cmdRefresh = new System.Windows.Forms.Button();
			this.tbProducer = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lblBufferCount = new System.Windows.Forms.Label();
			this.lblBufferSize = new System.Windows.Forms.Label();
			this.lblThreads = new System.Windows.Forms.Label();
			this.cmdProducerFetch = new System.Windows.Forms.Button();
			this.bkWorker = new System.ComponentModel.BackgroundWorker();
			this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.mainBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.consumerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tabControl1.SuspendLayout();
			this.tpSettings.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nProducerSleep)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nWordCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nConsumerSleep)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nBufferSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nProducers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nClients)).BeginInit();
			this.tpResults.SuspendLayout();
			this.tbProducer.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.consumerBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tpSettings);
			this.tabControl1.Controls.Add(this.tpResults);
			this.tabControl1.Controls.Add(this.tbProducer);
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
			this.tpSettings.Controls.Add(this.cmdreset);
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
			// cmdreset
			// 
			this.cmdreset.Location = new System.Drawing.Point(116, 313);
			this.cmdreset.Name = "cmdreset";
			this.cmdreset.Size = new System.Drawing.Size(75, 23);
			this.cmdreset.TabIndex = 10;
			this.cmdreset.Text = "Reset";
			this.cmdreset.UseVisualStyleBackColor = true;
			this.cmdreset.Click += new System.EventHandler(this.cmdreset_Click);
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
			// nWordCount
			// 
			this.nWordCount.Location = new System.Drawing.Point(150, 48);
			this.nWordCount.Maximum = new decimal(new int[] {
            5800,
            0,
            0,
            0});
			this.nWordCount.Name = "nWordCount";
			this.nWordCount.Size = new System.Drawing.Size(100, 20);
			this.nWordCount.TabIndex = 14;
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
			this.groupBox1.Controls.Add(this.nBufferSize);
			this.groupBox1.Controls.Add(this.nProducers);
			this.groupBox1.Controls.Add(this.nClients);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(3, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(274, 101);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Mandatory";
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
			// nProducers
			// 
			this.nProducers.Location = new System.Drawing.Point(155, 46);
			this.nProducers.Name = "nProducers";
			this.nProducers.Size = new System.Drawing.Size(100, 20);
			this.nProducers.TabIndex = 10;
			// 
			// nClients
			// 
			this.nClients.Location = new System.Drawing.Point(155, 17);
			this.nClients.Name = "nClients";
			this.nClients.Size = new System.Drawing.Size(100, 20);
			this.nClients.TabIndex = 9;
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
			this.tpResults.Controls.Add(this.lvThreads);
			this.tpResults.Controls.Add(this.cmdRefresh);
			this.tpResults.Location = new System.Drawing.Point(4, 22);
			this.tpResults.Name = "tpResults";
			this.tpResults.Padding = new System.Windows.Forms.Padding(3);
			this.tpResults.Size = new System.Drawing.Size(336, 358);
			this.tpResults.TabIndex = 2;
			this.tpResults.Text = "Results";
			this.tpResults.UseVisualStyleBackColor = true;
			// 
			// lvThreads
			// 
			this.lvThreads.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colThreadName,
            this.colActive,
            this.colSentence});
			this.lvThreads.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvThreads.Location = new System.Drawing.Point(3, 26);
			this.lvThreads.Name = "lvThreads";
			this.lvThreads.Size = new System.Drawing.Size(330, 329);
			this.lvThreads.TabIndex = 0;
			this.lvThreads.UseCompatibleStateImageBehavior = false;
			this.lvThreads.View = System.Windows.Forms.View.Details;
			// 
			// colThreadName
			// 
			this.colThreadName.Text = "Thread name";
			this.colThreadName.Width = 84;
			// 
			// colActive
			// 
			this.colActive.Text = "Status";
			this.colActive.Width = 54;
			// 
			// colSentence
			// 
			this.colSentence.Text = "Sentence";
			this.colSentence.Width = 187;
			// 
			// cmdRefresh
			// 
			this.cmdRefresh.Dock = System.Windows.Forms.DockStyle.Top;
			this.cmdRefresh.Location = new System.Drawing.Point(3, 3);
			this.cmdRefresh.Name = "cmdRefresh";
			this.cmdRefresh.Size = new System.Drawing.Size(330, 23);
			this.cmdRefresh.TabIndex = 1;
			this.cmdRefresh.Text = "Refresh";
			this.cmdRefresh.UseVisualStyleBackColor = true;
			this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
			// 
			// tbProducer
			// 
			this.tbProducer.Controls.Add(this.groupBox3);
			this.tbProducer.Controls.Add(this.cmdProducerFetch);
			this.tbProducer.Location = new System.Drawing.Point(4, 22);
			this.tbProducer.Name = "tbProducer";
			this.tbProducer.Padding = new System.Windows.Forms.Padding(3);
			this.tbProducer.Size = new System.Drawing.Size(336, 358);
			this.tbProducer.TabIndex = 3;
			this.tbProducer.Text = "Producer";
			this.tbProducer.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lblBufferCount);
			this.groupBox3.Controls.Add(this.lblBufferSize);
			this.groupBox3.Controls.Add(this.lblThreads);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox3.Location = new System.Drawing.Point(3, 26);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(330, 86);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Producer\'s resources";
			// 
			// lblBufferCount
			// 
			this.lblBufferCount.AutoSize = true;
			this.lblBufferCount.Location = new System.Drawing.Point(6, 62);
			this.lblBufferCount.Name = "lblBufferCount";
			this.lblBufferCount.Size = new System.Drawing.Size(69, 13);
			this.lblBufferCount.TabIndex = 7;
			this.lblBufferCount.Text = "Buffer Count:";
			// 
			// lblBufferSize
			// 
			this.lblBufferSize.AutoSize = true;
			this.lblBufferSize.Location = new System.Drawing.Point(6, 39);
			this.lblBufferSize.Name = "lblBufferSize";
			this.lblBufferSize.Size = new System.Drawing.Size(59, 13);
			this.lblBufferSize.TabIndex = 6;
			this.lblBufferSize.Text = "Buffer size:";
			// 
			// lblThreads
			// 
			this.lblThreads.AutoSize = true;
			this.lblThreads.Location = new System.Drawing.Point(6, 16);
			this.lblThreads.Name = "lblThreads";
			this.lblThreads.Size = new System.Drawing.Size(67, 13);
			this.lblThreads.TabIndex = 5;
			this.lblThreads.Text = "# of threads:";
			// 
			// cmdProducerFetch
			// 
			this.cmdProducerFetch.Dock = System.Windows.Forms.DockStyle.Top;
			this.cmdProducerFetch.Location = new System.Drawing.Point(3, 3);
			this.cmdProducerFetch.Name = "cmdProducerFetch";
			this.cmdProducerFetch.Size = new System.Drawing.Size(330, 23);
			this.cmdProducerFetch.TabIndex = 3;
			this.cmdProducerFetch.Text = "Refresh";
			this.cmdProducerFetch.UseVisualStyleBackColor = true;
			this.cmdProducerFetch.Click += new System.EventHandler(this.cmdProducerFetch_Click);
			// 
			// bkWorker
			// 
			this.bkWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkWorker_DoWork);
			// 
			// settingsBindingSource
			// 
			this.settingsBindingSource.DataSource = typeof(Common.Settings);
			// 
			// mainBindingSource
			// 
			this.mainBindingSource.DataSource = typeof(ConsumerMonitor.Main);
			// 
			// consumerBindingSource
			// 
			this.consumerBindingSource.DataSource = typeof(ConsumerMonitor.Consumer);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 384);
			this.Controls.Add(this.tabControl1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Main";
			this.ShowIcon = false;
			this.Text = "Consumer Monitor";
			this.tabControl1.ResumeLayout(false);
			this.tpSettings.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nProducerSleep)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nWordCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nConsumerSleep)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nBufferSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nProducers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nClients)).EndInit();
			this.tpResults.ResumeLayout(false);
			this.tbProducer.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.consumerBindingSource)).EndInit();
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
		private System.Windows.Forms.Button cmdTestConnection;
		private System.Windows.Forms.Button cmdSendSettings;
		private System.Windows.Forms.TabPage tpResults;
		private System.Windows.Forms.ListView lvThreads;
		private System.Windows.Forms.ColumnHeader colThreadName;
		private System.Windows.Forms.ColumnHeader colActive;
		private System.Windows.Forms.ColumnHeader colSentence;
		private System.ComponentModel.BackgroundWorker bkWorker;
		private System.Windows.Forms.NumericUpDown nProducerSleep;
		private System.Windows.Forms.NumericUpDown nWordCount;
		private System.Windows.Forms.NumericUpDown nConsumerSleep;
		private System.Windows.Forms.NumericUpDown nBufferSize;
		private System.Windows.Forms.NumericUpDown nProducers;
		private System.Windows.Forms.NumericUpDown nClients;
		private System.Windows.Forms.Button cmdRefresh;
		private System.Windows.Forms.TabPage tbProducer;
		private System.Windows.Forms.Button cmdProducerFetch;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lblBufferCount;
		private System.Windows.Forms.Label lblBufferSize;
		private System.Windows.Forms.Label lblThreads;
		private System.Windows.Forms.BindingSource settingsBindingSource;
		private System.Windows.Forms.BindingSource mainBindingSource;
		private System.Windows.Forms.BindingSource consumerBindingSource;
		private System.Windows.Forms.Button cmdreset;
	}
}

