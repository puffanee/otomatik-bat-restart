namespace Bot_Otomatik_Restart
{
    partial class frmMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.footerVerInfoLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kalanRestartSuresi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.restartTimer = new System.Windows.Forms.Timer(this.components);
            this.restartAppAdi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.selectFile = new Guna.UI2.WinForms.Guna2Button();
            this.txtSelectedPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cancelProcess = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // footerVerInfoLabel
            // 
            this.footerVerInfoLabel.AutoSize = true;
            this.footerVerInfoLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.footerVerInfoLabel.Location = new System.Drawing.Point(393, 213);
            this.footerVerInfoLabel.Name = "footerVerInfoLabel";
            this.footerVerInfoLabel.Size = new System.Drawing.Size(60, 18);
            this.footerVerInfoLabel.TabIndex = 12;
            this.footerVerInfoLabel.Text = "v2.0.0.0";
            this.footerVerInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(9, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telif Hakkı © Ahmet Mert \'Puffanee\' Kaymaz\r\nMade in İzmir with love ❤";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kalanRestartSuresi
            // 
            this.kalanRestartSuresi.BackColor = System.Drawing.Color.Transparent;
            this.kalanRestartSuresi.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.kalanRestartSuresi.Location = new System.Drawing.Point(62, 39);
            this.kalanRestartSuresi.Name = "kalanRestartSuresi";
            this.kalanRestartSuresi.Size = new System.Drawing.Size(339, 25);
            this.kalanRestartSuresi.TabIndex = 10;
            this.kalanRestartSuresi.Text = "99 gün 24 saat 60 dakika 60 saniye";
            this.kalanRestartSuresi.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // restartTimer
            // 
            this.restartTimer.Interval = 1000;
            this.restartTimer.Tick += new System.EventHandler(this.restartTimer_Tick);
            // 
            // restartAppAdi
            // 
            this.restartAppAdi.BackColor = System.Drawing.Color.Transparent;
            this.restartAppAdi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.restartAppAdi.Location = new System.Drawing.Point(179, 8);
            this.restartAppAdi.Name = "restartAppAdi";
            this.restartAppAdi.Size = new System.Drawing.Size(104, 25);
            this.restartAppAdi.TabIndex = 15;
            this.restartAppAdi.Text = "Bilinmeyen";
            this.restartAppAdi.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // selectFile
            // 
            this.selectFile.BorderRadius = 10;
            this.selectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.selectFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.selectFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.selectFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.selectFile.FillColor = System.Drawing.Color.Gray;
            this.selectFile.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.selectFile.ForeColor = System.Drawing.Color.White;
            this.selectFile.HoverState.FillColor = System.Drawing.Color.DarkGray;
            this.selectFile.Location = new System.Drawing.Point(12, 113);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(214, 33);
            this.selectFile.TabIndex = 17;
            this.selectFile.Text = "Restart Dosya Seç";
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // txtSelectedPath
            // 
            this.txtSelectedPath.Animated = true;
            this.txtSelectedPath.BackColor = System.Drawing.Color.White;
            this.txtSelectedPath.BorderRadius = 5;
            this.txtSelectedPath.BorderThickness = 2;
            this.txtSelectedPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSelectedPath.DefaultText = "";
            this.txtSelectedPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSelectedPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSelectedPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSelectedPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSelectedPath.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.txtSelectedPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSelectedPath.ForeColor = System.Drawing.Color.Black;
            this.txtSelectedPath.HoverState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSelectedPath.Location = new System.Drawing.Point(12, 152);
            this.txtSelectedPath.MaxLength = 50000;
            this.txtSelectedPath.Name = "txtSelectedPath";
            this.txtSelectedPath.PasswordChar = '\0';
            this.txtSelectedPath.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSelectedPath.PlaceholderText = "Seçilen Dosya Yolu";
            this.txtSelectedPath.ReadOnly = true;
            this.txtSelectedPath.SelectedText = "";
            this.txtSelectedPath.Size = new System.Drawing.Size(439, 33);
            this.txtSelectedPath.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSelectedPath.TabIndex = 18;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(126, 68);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(210, 23);
            this.guna2HtmlLabel1.TabIndex = 19;
            this.guna2HtmlLabel1.Text = "sonra yeniden başlatılacak";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cancelProcess
            // 
            this.cancelProcess.BorderRadius = 10;
            this.cancelProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelProcess.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelProcess.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelProcess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelProcess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelProcess.FillColor = System.Drawing.Color.Firebrick;
            this.cancelProcess.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.cancelProcess.ForeColor = System.Drawing.Color.White;
            this.cancelProcess.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.cancelProcess.Location = new System.Drawing.Point(237, 113);
            this.cancelProcess.Name = "cancelProcess";
            this.cancelProcess.Size = new System.Drawing.Size(214, 33);
            this.cancelProcess.TabIndex = 20;
            this.cancelProcess.Text = "İptal Et";
            this.cancelProcess.Click += new System.EventHandler(this.cancelProcess_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 241);
            this.Controls.Add(this.cancelProcess);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtSelectedPath);
            this.Controls.Add(this.selectFile);
            this.Controls.Add(this.restartAppAdi);
            this.Controls.Add(this.footerVerInfoLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kalanRestartSuresi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(479, 280);
            this.MinimumSize = new System.Drawing.Size(479, 141);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bot Otomatik Restart (BAT)";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label footerVerInfoLabel;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2HtmlLabel kalanRestartSuresi;
        private System.Windows.Forms.Timer restartTimer;
        private Guna.UI2.WinForms.Guna2Button selectFile;
        private Guna.UI2.WinForms.Guna2HtmlLabel restartAppAdi;
        private Guna.UI2.WinForms.Guna2TextBox txtSelectedPath;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button cancelProcess;
    }
}

