namespace ProxyGrabber
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MiniBtn = new System.Windows.Forms.Button();
            this.SeprLbl = new System.Windows.Forms.Label();
            this.upChkSta = new System.Windows.Forms.Label();
            this.AmountSta = new System.Windows.Forms.Label();
            this.TimeoutSta = new System.Windows.Forms.Label();
            this.TimeoutTbar = new System.Windows.Forms.TrackBar();
            this.CountryCmBox = new System.Windows.Forms.ComboBox();
            this.AnonymityCmBox = new System.Windows.Forms.ComboBox();
            this.SSLCmBox = new System.Windows.Forms.ComboBox();
            this.TypeCmBox = new System.Windows.Forms.ComboBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.TypeLbl = new System.Windows.Forms.Label();
            this.CountryLbl = new System.Windows.Forms.Label();
            this.AnonymityLbl = new System.Windows.Forms.Label();
            this.SSLLbl = new System.Windows.Forms.Label();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.SaveProxies = new System.Windows.Forms.SaveFileDialog();
            this.DownloadIcoPicBox = new System.Windows.Forms.PictureBox();
            this.LogoPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TimeoutTbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadIcoPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(271, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(24, 25);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MiniBtn
            // 
            this.MiniBtn.BackColor = System.Drawing.SystemColors.Control;
            this.MiniBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MiniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiniBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiniBtn.Location = new System.Drawing.Point(245, 2);
            this.MiniBtn.Name = "MiniBtn";
            this.MiniBtn.Size = new System.Drawing.Size(24, 25);
            this.MiniBtn.TabIndex = 1;
            this.MiniBtn.Text = "_";
            this.MiniBtn.UseVisualStyleBackColor = false;
            this.MiniBtn.Click += new System.EventHandler(this.MiniBtn_Click);
            // 
            // SeprLbl
            // 
            this.SeprLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SeprLbl.Location = new System.Drawing.Point(2, 33);
            this.SeprLbl.Name = "SeprLbl";
            this.SeprLbl.Size = new System.Drawing.Size(294, 1);
            this.SeprLbl.TabIndex = 3;
            // 
            // upChkSta
            // 
            this.upChkSta.AutoSize = true;
            this.upChkSta.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upChkSta.Location = new System.Drawing.Point(12, 192);
            this.upChkSta.Name = "upChkSta";
            this.upChkSta.Size = new System.Drawing.Size(98, 19);
            this.upChkSta.TabIndex = 5;
            this.upChkSta.Text = "Last updated:";
            // 
            // AmountSta
            // 
            this.AmountSta.AutoSize = true;
            this.AmountSta.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountSta.Location = new System.Drawing.Point(12, 219);
            this.AmountSta.Name = "AmountSta";
            this.AmountSta.Size = new System.Drawing.Size(65, 19);
            this.AmountSta.TabIndex = 7;
            this.AmountSta.Text = "Amount:";
            // 
            // TimeoutSta
            // 
            this.TimeoutSta.AutoSize = true;
            this.TimeoutSta.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeoutSta.Location = new System.Drawing.Point(79, 256);
            this.TimeoutSta.Name = "TimeoutSta";
            this.TimeoutSta.Size = new System.Drawing.Size(71, 19);
            this.TimeoutSta.TabIndex = 9;
            this.TimeoutSta.Text = "Timeout: ";
            // 
            // TimeoutTbar
            // 
            this.TimeoutTbar.LargeChange = 50;
            this.TimeoutTbar.Location = new System.Drawing.Point(12, 278);
            this.TimeoutTbar.Maximum = 10000;
            this.TimeoutTbar.Minimum = 50;
            this.TimeoutTbar.Name = "TimeoutTbar";
            this.TimeoutTbar.Size = new System.Drawing.Size(273, 45);
            this.TimeoutTbar.SmallChange = 50;
            this.TimeoutTbar.TabIndex = 50;
            this.TimeoutTbar.TickFrequency = 50;
            this.TimeoutTbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TimeoutTbar.Value = 10000;
            this.TimeoutTbar.Scroll += new System.EventHandler(this.TimeoutTbar_Scroll);
            this.TimeoutTbar.MouseCaptureChanged += new System.EventHandler(this.TimeoutTbar_MouseCaptureChanged);
            // 
            // CountryCmBox
            // 
            this.CountryCmBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CountryCmBox.DropDownHeight = 123;
            this.CountryCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountryCmBox.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryCmBox.FormattingEnabled = true;
            this.CountryCmBox.IntegralHeight = false;
            this.CountryCmBox.ItemHeight = 19;
            this.CountryCmBox.Items.AddRange(new object[] {
            "all",
            "AL",
            "AM",
            "AR",
            "AU",
            "BD",
            "BG",
            "BR",
            "CA",
            "CD",
            "CL",
            "CN",
            "CO",
            "CZ",
            "DE",
            "EC",
            "ES",
            "FR",
            "GB",
            "GE",
            "GR",
            "HK",
            "HU",
            "ID",
            "IN",
            "IQ",
            "IR",
            "IT",
            "KE",
            "KH",
            "KR",
            "KZ",
            "LB",
            "LT",
            "MD",
            "MK",
            "MN",
            "MV",
            "MW",
            "MX",
            "MY",
            "NG",
            "NL",
            "NP",
            "NZ",
            "PE",
            "PH",
            "PK",
            "PL",
            "PS",
            "RO",
            "RS",
            "RU",
            "SC",
            "SK",
            "TH",
            "TR",
            "TW",
            "UA",
            "US",
            "UY",
            "VE",
            "VN",
            "ZA"});
            this.CountryCmBox.Location = new System.Drawing.Point(105, 347);
            this.CountryCmBox.Name = "CountryCmBox";
            this.CountryCmBox.Size = new System.Drawing.Size(173, 27);
            this.CountryCmBox.TabIndex = 51;
            this.CountryCmBox.SelectedIndexChanged += new System.EventHandler(this.CountryCmBox_SelectedIndexChanged);
            // 
            // AnonymityCmBox
            // 
            this.AnonymityCmBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnonymityCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnonymityCmBox.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnonymityCmBox.FormattingEnabled = true;
            this.AnonymityCmBox.Items.AddRange(new object[] {
            "all",
            "elite",
            "anonymous",
            "transparent"});
            this.AnonymityCmBox.Location = new System.Drawing.Point(105, 383);
            this.AnonymityCmBox.Name = "AnonymityCmBox";
            this.AnonymityCmBox.Size = new System.Drawing.Size(173, 27);
            this.AnonymityCmBox.TabIndex = 52;
            this.AnonymityCmBox.SelectedIndexChanged += new System.EventHandler(this.AnonymityCmBox_SelectedIndexChanged);
            // 
            // SSLCmBox
            // 
            this.SSLCmBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SSLCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SSLCmBox.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSLCmBox.FormattingEnabled = true;
            this.SSLCmBox.Items.AddRange(new object[] {
            "all",
            "yes",
            "no"});
            this.SSLCmBox.Location = new System.Drawing.Point(105, 419);
            this.SSLCmBox.Name = "SSLCmBox";
            this.SSLCmBox.Size = new System.Drawing.Size(173, 27);
            this.SSLCmBox.TabIndex = 53;
            this.SSLCmBox.SelectedIndexChanged += new System.EventHandler(this.SSLCmBox_SelectedIndexChanged);
            // 
            // TypeCmBox
            // 
            this.TypeCmBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TypeCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeCmBox.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeCmBox.FormattingEnabled = true;
            this.TypeCmBox.Items.AddRange(new object[] {
            "all",
            "http",
            "socks4",
            "socks5"});
            this.TypeCmBox.Location = new System.Drawing.Point(105, 311);
            this.TypeCmBox.Name = "TypeCmBox";
            this.TypeCmBox.Size = new System.Drawing.Size(173, 27);
            this.TypeCmBox.TabIndex = 54;
            this.TypeCmBox.Tag = "";
            this.TypeCmBox.SelectedIndexChanged += new System.EventHandler(this.TypeCmBox_SelectedIndexChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(82, 463);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(134, 47);
            this.SaveBtn.TabIndex = 55;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLbl.Location = new System.Drawing.Point(12, 314);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(48, 19);
            this.TypeLbl.TabIndex = 56;
            this.TypeLbl.Text = "Type: ";
            // 
            // CountryLbl
            // 
            this.CountryLbl.AutoSize = true;
            this.CountryLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryLbl.Location = new System.Drawing.Point(12, 350);
            this.CountryLbl.Name = "CountryLbl";
            this.CountryLbl.Size = new System.Drawing.Size(67, 19);
            this.CountryLbl.TabIndex = 57;
            this.CountryLbl.Text = "Country: ";
            // 
            // AnonymityLbl
            // 
            this.AnonymityLbl.AutoSize = true;
            this.AnonymityLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnonymityLbl.Location = new System.Drawing.Point(12, 386);
            this.AnonymityLbl.Name = "AnonymityLbl";
            this.AnonymityLbl.Size = new System.Drawing.Size(87, 19);
            this.AnonymityLbl.TabIndex = 58;
            this.AnonymityLbl.Text = "Anonymity: ";
            // 
            // SSLLbl
            // 
            this.SSLLbl.AutoSize = true;
            this.SSLLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSLLbl.Location = new System.Drawing.Point(12, 422);
            this.SSLLbl.Name = "SSLLbl";
            this.SSLLbl.Size = new System.Drawing.Size(39, 19);
            this.SSLLbl.TabIndex = 59;
            this.SSLLbl.Text = "SSL: ";
            // 
            // InfoBtn
            // 
            this.InfoBtn.BackColor = System.Drawing.SystemColors.Control;
            this.InfoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBtn.Location = new System.Drawing.Point(219, 2);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(24, 25);
            this.InfoBtn.TabIndex = 60;
            this.InfoBtn.Text = "?";
            this.InfoBtn.UseVisualStyleBackColor = false;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // SaveProxies
            // 
            this.SaveProxies.DefaultExt = "txt";
            this.SaveProxies.FileName = "MyProxies";
            this.SaveProxies.Filter = "Text files (*.txt)|*.txt";
            // 
            // DownloadIcoPicBox
            // 
            this.DownloadIcoPicBox.Image = global::ProxyGrabber.Properties.Resources.DownloadIcon;
            this.DownloadIcoPicBox.Location = new System.Drawing.Point(77, 50);
            this.DownloadIcoPicBox.Name = "DownloadIcoPicBox";
            this.DownloadIcoPicBox.Size = new System.Drawing.Size(139, 133);
            this.DownloadIcoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DownloadIcoPicBox.TabIndex = 4;
            this.DownloadIcoPicBox.TabStop = false;
            // 
            // LogoPicBox
            // 
            this.LogoPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoPicBox.Image = global::ProxyGrabber.Properties.Resources.ProxyLogo;
            this.LogoPicBox.Location = new System.Drawing.Point(3, 3);
            this.LogoPicBox.Name = "LogoPicBox";
            this.LogoPicBox.Size = new System.Drawing.Size(169, 25);
            this.LogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPicBox.TabIndex = 2;
            this.LogoPicBox.TabStop = false;
            this.LogoPicBox.Click += new System.EventHandler(this.LogoPicBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 522);
            this.ControlBox = false;
            this.Controls.Add(this.InfoBtn);
            this.Controls.Add(this.SSLLbl);
            this.Controls.Add(this.AnonymityLbl);
            this.Controls.Add(this.CountryLbl);
            this.Controls.Add(this.TypeLbl);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.TypeCmBox);
            this.Controls.Add(this.SSLCmBox);
            this.Controls.Add(this.AnonymityCmBox);
            this.Controls.Add(this.CountryCmBox);
            this.Controls.Add(this.TimeoutTbar);
            this.Controls.Add(this.TimeoutSta);
            this.Controls.Add(this.AmountSta);
            this.Controls.Add(this.upChkSta);
            this.Controls.Add(this.DownloadIcoPicBox);
            this.Controls.Add(this.SeprLbl);
            this.Controls.Add(this.LogoPicBox);
            this.Controls.Add(this.MiniBtn);
            this.Controls.Add(this.ExitBtn);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.TimeoutTbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadIcoPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MiniBtn;
        private System.Windows.Forms.PictureBox LogoPicBox;
        private System.Windows.Forms.Label SeprLbl;
        private System.Windows.Forms.PictureBox DownloadIcoPicBox;
        private System.Windows.Forms.Label upChkSta;
        private System.Windows.Forms.Label AmountSta;
        private System.Windows.Forms.Label TimeoutSta;
        private System.Windows.Forms.TrackBar TimeoutTbar;
        private System.Windows.Forms.ComboBox CountryCmBox;
        private System.Windows.Forms.ComboBox AnonymityCmBox;
        private System.Windows.Forms.ComboBox SSLCmBox;
        private System.Windows.Forms.ComboBox TypeCmBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label TypeLbl;
        private System.Windows.Forms.Label CountryLbl;
        private System.Windows.Forms.Label AnonymityLbl;
        private System.Windows.Forms.Label SSLLbl;
        private System.Windows.Forms.Button InfoBtn;
        private System.Windows.Forms.SaveFileDialog SaveProxies;
    }
}

