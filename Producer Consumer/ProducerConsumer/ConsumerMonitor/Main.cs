using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
		}

		private Http _httpConnection;


		private void cmdTestConnection_Click(object sender, EventArgs e)
		{

		}

		#region Test Connection

		private void cmdSendSettings_Click(object sender, EventArgs e)
		{

		}

		private void cmdSendSetting_Click(object sender, EventArgs e)
		{

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
