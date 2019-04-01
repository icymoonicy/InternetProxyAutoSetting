using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using SetYourProxy.Config;
using Microsoft.Win32;

namespace SetYourProxy
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			InitProxyData();
		}

		void InitProxyData()
		{
			var section =  (ProxyPacSection)ConfigurationManager.GetSection("proxyPacs");
			foreach (ProxyPacUrl item in section.ProxyPacUrls)
			{
				cmbProxyList.Items.Add(item);
			}
			cmbProxyList.SelectedIndex = 0;
			lblRunningStatus.Text = "Stopped";
			lblRunningStatus.ForeColor = Color.Red;
		}

		void btnStart_Click(object sender, EventArgs e)
		{
			DoSetProxy();
			timer1.Start();
			btnStart.Enabled = false;
			btnStop.Enabled = true;
			lblRunningStatus.Text = "Running";
			lblRunningStatus.ForeColor = Color.Green;
		}

		void btnStop_Click(object sender, EventArgs e)
		{
			timer1.Stop();
			btnStart.Enabled = true;
			btnStop.Enabled = false;
			lblRunningStatus.Text = "Stopped";
			lblRunningStatus.ForeColor = Color.Red;
		}

		void SetProxy(string proxy)
		{
			using (RegistryKey regKey = Registry.CurrentUser)
			{
				string SubKeyPath = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
				RegistryKey optionKey = regKey.OpenSubKey(SubKeyPath, true);
				optionKey.SetValue("ProxyEnable", 1);
				optionKey.SetValue("AutoConfigURL", proxy);
				regKey.Flush();
			}
		}

		bool GetProxyStatus()
		{
			RegistryKey regKey = Registry.CurrentUser;
			string SubKeyPath = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
			RegistryKey optionKey = regKey.OpenSubKey(SubKeyPath, true);
			int actualProxyStatus = Convert.ToInt32(optionKey.GetValue("ProxyEnable"));
			regKey.Close();
			return actualProxyStatus == 1 ? true : false;
		}

		string GetProxyPacUrl()
		{
			RegistryKey regKey = Registry.CurrentUser;
			string SubKeyPath = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
			RegistryKey optionKey = regKey.OpenSubKey(SubKeyPath, true);
			string actualProxy = optionKey.GetValue("AutoConfigURL").ToString();
			regKey.Close();
			return actualProxy;
		}

		void timer1_Tick(object sender, EventArgs e)
		{
			DoSetProxy();
		}

		void DoSetProxy()
		{
			string proxyStr = ((ProxyPacUrl)cmbProxyList.SelectedItem).PacUrl;
			SetProxy(proxyStr);
		}

		void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.Visible = true;
			this.WindowState = FormWindowState.Normal;
		}

		void Form1_Resize(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.Visible = false;
				notifyIcon1.Visible = true;
			}
			else
			{
				this.Visible = true;
				notifyIcon1.Visible = false;
			}
		}

		void showMainFormToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Visible = true;
			this.WindowState = FormWindowState.Normal;
		}

		void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
