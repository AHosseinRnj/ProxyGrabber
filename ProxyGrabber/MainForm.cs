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
            TimeoutLbl.Text = "Timeout: " + Convert.ToString(TimeoutTbar.Value) + "ms";

            TypeCmBox.SelectedIndex = 0;
            CountryCmBox.SelectedIndex = 0;
            AnonymityCmBox.SelectedIndex = 0;
            SSLCmBox.SelectedIndex = 0;

            AmountLbl.Text = API.ProxiesCount();
        }

        private string _timeOut = string.Empty;
        private void TimeoutTbar_Scroll(object sender, EventArgs e)
        {
            _timeOut = Convert.ToString(TimeoutTbar.Value);
            TimeoutLbl.Text = "Timeout: " + _timeOut + " ms";
        }

        private void TimeoutTbar_MouseCaptureChanged(object sender, EventArgs e)
        {
            API.TimeOut = _timeOut;
            AmountLbl.Text = API.ProxiesCount();
        }

        private void TypeCmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            API.ProxyType = Convert.ToString(TypeCmBox.SelectedItem);

            if (API.ProxyType == "socks4" || API.ProxyType == "socks5")
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

            LastUpdatedLbl.Text = API.lastUpdated();
            AmountLbl.Text = API.ProxiesCount();
        }

        private void CountryCmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            API.Country = Convert.ToString(CountryCmBox.SelectedItem);
            AmountLbl.Text = API.ProxiesCount();
        }

        private void AnonymityCmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            API.Anonymity = Convert.ToString(AnonymityCmBox.SelectedItem);
            AmountLbl.Text = API.ProxiesCount();
        }

        private void SSLCmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            API.Ssl = Convert.ToString(SSLCmBox.SelectedItem);
            AmountLbl.Text = API.ProxiesCount();
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
            Application.Exit();
        }

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            using (Information InfoDialog = new Information())
            {
                InfoDialog.ShowDialog();
            }
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