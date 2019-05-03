using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using ConsumerMonitor.ProducerWCF;

namespace ConsumerMonitor
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
			_ThreadManager = new ThreadManager<Consumer>();
		}

		public Common.ThreadManager<Consumer> _ThreadManager;
		private Settings _settings;

		private WorkerClient _Client;

		#region Settings
		private void cmdSendSettings_Click(object sender, EventArgs e)
		{
			sendSettings();
		}

		private void sendSettings()
		{
			//Check settings if valid
			Settings newSettings;
			try
			{
				int clients = Convert.ToInt32(nClients.Value);
				int producer = Convert.ToInt32(nProducers.Value);
				int bufferSize = Convert.ToInt32(nBufferSize.Value);
				int ConsumerSleep = Convert.ToInt32(nConsumerSleep.Value);
				int producerSleep = Convert.ToInt32(nProducerSleep.Value);
				int word = Convert.ToInt32(nWordCount.Value);
				newSettings = new Settings(clients, producer, bufferSize, ConsumerSleep, word, producerSleep);
			}
			catch (Exception e)
			{
				MessageBox.Show("Please have digit numbers");
				return;
			}

			try
			{
				_Client = new WorkerClient();
				var result = _Client.Post(newSettings);
				if (result == HttpStatusCode.OK)
				{
					tpSettings.Name = "Settings";
					_settings = newSettings;
					bkWorker.RunWorkerAsync();
					MessageBox.Show("Setting posted successfully");
				}
				else
					MessageBox.Show("Setting NOT successful.");
			}
			catch(Exception e)
			{
				MessageBox.Show("Setting not successful for some reason.  Probably Service is not active");
			}
			////Check http connection
			//if (_httpConnection == null)
			//{
			//	if (!test(txtbxBaseUrl.Text, Convert.ToInt32(nPort.Value)))
			//	{
			//		MessageBox.Show("Server not found");
			//		return;
			//	}
			//}

			//var result = _httpConnection.Post(newSettings);
			//if (result == HttpStatusCode.OK)
			//{
			//	MessageBox.Show("Setting posted successfully");

			//	tpSettings.Name = "Settings";
			//	_settings = newSettings;
			//	bkWorker.RunWorkerAsync();
			//}
			//else
			//	MessageBox.Show("Setting NOT successful.");
		}
		#endregion



		#region Test Connection
		private void cmdTestConnection_Click(object sender, EventArgs e)
		{
			try
			{
				WorkerClient client = new WorkerClient();
				if (client.Test())
					MessageBox.Show("Found service");
				else
				{
					MessageBox.Show("Service not found");
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show("Service not found");
			}

			#region  deadcode

			//var test = this.test(txtbxBaseUrl.Text, Convert.ToInt32(nPort.Value));
			//if (test)
			//	MessageBox.Show("Found correct server");
			//else
			//{
			//	MessageBox.Show("Incorrect server");
			//	_httpConnection = null;
			//}

			#endregion

		}

		#region deadCode
		//private bool test(string url, int port)
		//{
		//	_httpConnection = new Http(url, port);

		//	if (_httpConnection.TestConnection())
		//		return true;
		//	else
		//		return false;
		//}
		//private bool testWithCurrent()
		//{
		//	if (_httpConnection.TestConnection())
		//		return true;
		//	else
		//		return false;
		//}
		#endregion

		#endregion

		private void bkWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			CheckSettings();
		}

		private void CheckSettings()
		{
			//Number of Clients
			while (_settings.NumOfClients > _ThreadManager.CurrentCount)
			{
				WorkerClient client = new WorkerClient();
				Consumer consumer = new Consumer(_settings.ConsumersleepNum, client);

				Thread thread = new Thread(consumer.Consume)
				{
					Name = "consumer " + Guid.NewGuid().ToString(),
					IsBackground = false
				};
				thread.SetApartmentState(ApartmentState.MTA);

				_ThreadManager.AddThread(thread, consumer);

				thread.Start();
			}

			while (_settings.NumOfClients < _ThreadManager.CurrentCount)
			{
				_ThreadManager.KillThread();
			}

			//Consumer Sleep time
			if (_ThreadManager.CurrentCount != 0 && _settings.ConsumersleepNum != _ThreadManager.GetRunningThreads()[0].Item2._consumerSleepNum)
			{
				foreach (var item in _ThreadManager.GetRunningThreads())
				{
					item.Item2._consumerSleepNum = _settings.ConsumersleepNum;
				}
			}
		}

		private void cmdRefresh_Click(object sender, EventArgs e)
		{
			lvThreads.Items.Clear();
			foreach (var item in _ThreadManager.GetRunningThreads())
			{
				ListViewItem listItem = new ListViewItem(item.Item1.Name);
				listItem.SubItems.Add(Enum.GetName(typeof(ThreadState), item.Item1.ThreadState));
				listItem.SubItems.Add(item.Item2.Sentence);

				lvThreads.Items.Add(listItem);
			}

			foreach(var item in _ThreadManager.GetRunningThreads())
			{
				ListViewItem listItem = new ListViewItem(item.Item1.Name);
				listItem.SubItems.Add(Enum.GetName(typeof(ThreadState), item.Item1.ThreadState));
				listItem.SubItems.Add(item.Item2.Sentence);

				lvThreads.Items.Add(listItem);
			}
			
		}

		private void cmdProducerFetch_Click(object sender, EventArgs e)
		{
			var bufferItems = _Client.BufferItems();
			var settings = _Client.CurrentSettings();

			lblThreads.Text = "Number of threads: " + settings.NumOfProducers;
			lblBufferSize.Text = "Buffer Size: " + settings.BufferSize;
			lblBufferCount.Text = "Buffer Count: " + bufferItems.Count;

		}

		private void cmdreset_Click(object sender, EventArgs e)
		{
			_Client.Reset();
		}
	}
}