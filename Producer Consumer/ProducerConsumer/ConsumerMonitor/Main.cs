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

namespace ConsumerMonitor
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
			_threads = new List<Thread>(1);
		}

		private Http _httpConnection;
		private List<Thread> _threads;
		private Settings _settings;

		#region Settings
		private void cmdSendSettings_Click(object sender, EventArgs e)
		{
			sendSettings();
		}

		private void sendSettings()
		{
			try
			{
				int clients = Convert.ToInt32(nClients.Value);
				int producer = Convert.ToInt32(nProducers.Value);
				int bufferSize = Convert.ToInt32(nBufferSize.Value);
				int ConsumerSleep = Convert.ToInt32(nConsumerSleep.Value);
				int producerSleep = Convert.ToInt32(nProducerSleep.Value);
				int word = Convert.ToInt32(nWordCount.Value);
				_settings = new Settings(clients, producer, bufferSize, ConsumerSleep, word, producerSleep);
			}
			catch (Exception e)
			{
				MessageBox.Show("Please have digit numbers");
				return;
			}

			if (_httpConnection != null)
			{
				var result = _httpConnection.Post(_settings);
				if (result == HttpStatusCode.OK)
				{
					MessageBox.Show("Setting posted successfully");
					CheckSettings();

					tpSettings.Name = "Settings";
				}
				else
					MessageBox.Show("Setting NOT successful.");
			}
			else
			{
				cmdTestConnection_Click(null, null);
			}

		}

		#endregion



		#region Test Connection
		private void cmdTestConnection_Click(object sender, EventArgs e)
		{
			var test = this.test(txtbxBaseUrl.Text, Convert.ToInt32(nPort.Value));
			if (test)
				MessageBox.Show("Found correct server");
			else
			{
				MessageBox.Show("Incorrect server");
				_httpConnection = null;
			}
		}

		private bool test(string url, int port)
		{
			_httpConnection = new Http(url, port);

			if (_httpConnection.TestConnection())
				return true;
			else
				return false;
		}

		private bool testWithCurrent()
		{
			if (_httpConnection.TestConnection())
				return true;
			else
				return false;
		}

		#endregion

		private void bkWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			
		}

		private void CheckSettings()
		{
			if (_settings.NumOfClients > _threads.Count)
			{
				while (_settings.NumOfClients > _threads.Count)
				{
					Task.Run(() =>
					{
						//TODO: Assign producer method to the thread with a delegate
						//Send a method to update number of words
						//Send a method to update producer sleep
						//Thread thread = new Thread();
					});
				}
			}

		}
	}
}