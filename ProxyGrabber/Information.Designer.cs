namespace ProxyGrabber
{
    partial class Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            this.NameLbl = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SeprLbl = new System.Windows.Forms.Label();
            this.VerLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InstagramPicBox = new System.Windows.Forms.PictureBox();
            this.TelegramPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.InstagramPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelegramPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(2, 4);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(128, 23);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Change Logs: ";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(361, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(24, 25);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SeprLbl
            // 
            this.SeprLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SeprLbl.Location = new System.Drawing.Point(3, 33);
            this.SeprLbl.Name = "SeprLbl";
            this.SeprLbl.Size = new System.Drawing.Size(383, 1);
            this.SeprLbl.TabIndex = 4;
            // 
            // VerLbl
            // 
            this.VerLbl.AutoSize = true;
            this.VerLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerLbl.Location = new System.Drawing.Point(23, 46);
            this.VerLbl.Name = "VerLbl";
            this.VerLbl.Size = new System.Drawing.Size(46, 21);
            this.VerLbl.TabIndex = 5;
            this.VerLbl.Text = "1.0.0:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "- Release Ver.\r\n- Might have bugs\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ways To Contact Me:";
            // 
            // InstagramPicBox
            // 
            this.InstagramPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InstagramPicBox.Image = global::ProxyGrabber.Properties.Resources.Instagram_Logo;
            this.InstagramPicBox.Location = new System.Drawing.Point(195, 141);
            this.InstagramPicBox.Name = "InstagramPicBox";
            this.InstagramPicBox.Size = new System.Drawing.Size(94, 93);
            this.InstagramPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InstagramPicBox.TabIndex = 12;
            this.InstagramPicBox.TabStop = false;
            this.InstagramPicBox.Click += new System.EventHandler(this.InstagramPicBox_Click);
            // 
            // TelegramPicBox
            // 
            this.TelegramPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TelegramPicBox.Image = global::ProxyGrabber.Properties.Resources.Telegram_Logo;
            this.TelegramPicBox.Location = new System.Drawing.Point(103, 146);
            this.TelegramPicBox.Name = "TelegramPicBox";
            this.TelegramPicBox.Size = new System.Drawing.Size(86, 85);
            this.TelegramPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TelegramPicBox.TabIndex = 11;
            this.TelegramPicBox.TabStop = false;
            this.TelegramPicBox.Click += new System.EventHandler(this.TelegramPicBox_Click);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 242);
            this.ControlBox = false;
            this.Controls.Add(this.InstagramPicBox);
            this.Controls.Add(this.TelegramPicBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VerLbl);
            this.Controls.Add(this.SeprLbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.NameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Information_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.InstagramPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelegramPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label SeprLbl;
        private System.Windows.Forms.Label VerLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox InstagramPicBox;
        private System.Windows.Forms.PictureBox TelegramPicBox;
    }
}