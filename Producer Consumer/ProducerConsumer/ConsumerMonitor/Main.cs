using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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



		#region Test Connection

		private void cmdSendSettings_Click(object sender, EventArgs e)
		{

		}

		private void sendSettings()
		{
			try
			{
				int clients = Convert.ToInt32(txtbxClients.Text);
				int producer = Convert.ToInt32(txtbxProducers.Text);
				int bufferSize = Convert.ToInt32(txtbxBufferSize.Text);
				int ConsumerSleep = Convert.ToInt32(txtbxConsumerSleep.Text);
				int producerSleep= Convert.ToInt32(txtbxProducerSleep.Text);
				int word= Convert.ToInt32(txtbxWordCount.Text);
				Settings settings = new Settings(clients,producer,bufferSize, ConsumerSleep, word, producerSleep);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		private void cmdTestConnection_Click(object sender, EventArgs e)
		{
			var test = this.test(txtbxBaseUrl.Text, Convert.ToInt32(txtbxPort.Text));
			if (test)
				MessageBox.Show("Found correct server");
			else
				MessageBox.Show("Incorrect server");
		}

		private bool test(string url, int port)
		{
			_httpConnection = new Http(url, port);

			if (_httpConnection.TestConnection())
				return true;
			else
				return false;
		}
		#endregion
	}
}
