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

        private void MainForm_Load(object sender, EventArgs e)
        {
            TimeoutSta.Text = "Timeout: " + Convert.ToString(TimeoutTbar.Value) + "ms";
            amountUpdate();
            TypeCmBox.SelectedIndex = 0;
            CountryCmBox.SelectedIndex = 0;
            AnonymityCmBox.SelectedIndex = 0;
            SSLCmBox.SelectedIndex = 0;
        }

        webAPI API;
        private string timeout;
        private string proxytype;
        private string country;
        private string anonymity;
        private string ssl;

        private void TimeoutTbar_Scroll(object sender, EventArgs e)
        {
            timeout = Convert.ToString(TimeoutTbar.Value);
            TimeoutSta.Text = "Timeout: " + timeout + "ms";
        }

        private void TimeoutTbar_MouseCaptureChanged(object sender, EventArgs e)
        {
            amountUpdate();
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
            timeUpdate();
            amountUpdate();
        }

        private void CountryCmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            country = Convert.ToString(CountryCmBox.SelectedItem);
            amountUpdate();
        }

        private void AnonymityCmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            anonymity = Convert.ToString(AnonymityCmBox.SelectedItem);
            amountUpdate();
        }

        private void SSLCmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ssl = Convert.ToString(SSLCmBox.SelectedItem);
            amountUpdate();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            APIReq();
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
            Application.Exit();
        }

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            Information InfoDialog = new Information();
            InfoDialog.ShowDialog();
        }

        public void timeUpdate()
        {
            APIReq();
            upChkSta.Text = "Last updated: " + API.Lastupdated();
        }

        public void amountUpdate()
        {
            APIReq();
            AmountSta.Text = "Amount: " + API.AmountProxies();
        }

        public void APIReq()
        {
            API = new webAPI(timeout, proxytype, country, anonymity, ssl);
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
