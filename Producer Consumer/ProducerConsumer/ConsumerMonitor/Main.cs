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

		/// <summary>
		/// Validate settings and sends it to server.
		/// </summary>
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
				//Send Settings
				var result = _Client.Post(newSettings);
				if (result == HttpStatusCode.OK)
				{
					tpSettings.Name = "Settings";
					_settings = newSettings;
					
					//Apply settings on Consumer Monitor end.
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
		}
		#endregion

		private void bkWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			CheckSettings();
		}

		/// <summary>
		/// Apply new settings
		/// </summary>
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

			foreach(var item in _ThreadManager.GetDeadThreads())
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
			if(_Client == null)
				_Client = new WorkerClient();
			_Client.Reset();
		}
	}
}