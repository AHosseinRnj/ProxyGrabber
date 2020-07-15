using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using ProxyGrabber.Classes;

namespace ProxyGrabber
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string timeout;
        private string proxytype;
        private string country;
        private string anonymity;
        private string ssl;
        webAPI API = new webAPI();
        Information InfoDialog = new Information();
        private void MainForm_Load(object sender, EventArgs e)
        {
            TimeoutLbl.Text = "Timeout: " + Convert.ToString(TimeoutTbar.Value) + "ms";

            TypeCmBox.SelectedIndex = 0;
            CountryCmBox.SelectedIndex = 0;
            AnonymityCmBox.SelectedIndex = 0;
            SSLCmBox.SelectedIndex = 0;

            AmountLbl.Text = "Amount: " + API.amountProxies();
        }

        private void TimeoutTbar_Scroll(object sender, EventArgs e)
        {
            timeout = Convert.ToString(TimeoutTbar.Value);
            TimeoutLbl.Text = "Timeout: " + timeout + "ms";
        }

        private void TimeoutTbar_MouseCaptureChanged(object sender, EventArgs e)
        {
            API.setTimeout(timeout);
            AmountLbl.Text = "Amount: " + API.amountProxies();
        }

        private void TypeCmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            proxytype = Convert.ToString(TypeCmBox.SelectedItem);
            if (proxytype == "socks4" || proxytype == "socks5")
            {
                AnonymityCmBox.SelectedIndex = 0;
                SSLCmBox.SelectedIndex = 0;
                AnonymityCmBox.Enabled = false;
                SSLCmBox.Enabled = false;
            }
            else
            {
                AnonymityCmBox.Enabled = true;
                SSLCmBox.Enabled = true;
            }
            API.setProxyType(proxytype);
            LastUpdatedLbl.Text = "Last updated: " + API.lastUpdated();
            AmountLbl.Text = "Amount: " + API.amountProxies();
        }

        private void CountryCmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            country = Convert.ToString(CountryCmBox.SelectedItem);
            API.setCountry(country);
            AmountLbl.Text = "Amount: " + API.amountProxies();
        }

        private void AnonymityCmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            anonymity = Convert.ToString(AnonymityCmBox.SelectedItem);
            API.setAnonymity(anonymity);
            AmountLbl.Text = "Amount: " + API.amountProxies();
        }

        private void SSLCmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ssl = Convert.ToString(SSLCmBox.SelectedItem);
            API.setSSL(ssl);
            AmountLbl.Text = "Amount: " + API.amountProxies();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (SaveProxies.ShowDialog() == DialogResult.OK)
            {
                API.Download(SaveProxies.FileName);
            }
        }

        private void LogoPicBox_Click(object sender, EventArgs e)
        {
            Process.Start("https://proxyscrape.com/home");
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            API.Dispose();
            API = null;
            InfoDialog = null;
            GC.Collect();
            Application.Exit();
        }

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            InfoDialog.ShowDialog();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
