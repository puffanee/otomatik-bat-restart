using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Bot_Otomatik_Restart
{
    public partial class frmMain : Form
    {
        private DateTime nextExecutionTime;
        private Int32 restartGunu = 13;
        private int AktifGorevPID;

        static bool IsProcessRunning(int pid)
        {
            try
            {
                Process.GetProcessById(pid);
                return true;
            }
            catch (ArgumentException)
            {
                return false;
            }
        }

        static bool KillProcess(int pid)
        {
            try
            {
                Process process = Process.GetProcessById(pid);
                process.Kill();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public frmMain()
        {
            InitializeComponent();

            nextExecutionTime = DateTime.Now.Add(TimeSpan.FromDays(restartGunu));

            kalanRestartSuresi.Text = $"00 gün 00 saat 00 dakika 00 saniye";
        }

        private void restartTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = nextExecutionTime - DateTime.Now;

            kalanRestartSuresi.Text = $"{remainingTime.Days} gün {remainingTime.Hours} saat {remainingTime.Minutes} dakika {remainingTime.Seconds} saniye";

            if (DateTime.Now >= nextExecutionTime)
            {
                nextExecutionTime = DateTime.Now.Add(TimeSpan.FromDays(restartGunu));

                RestartOps();
            }
        }

        private void RestartOps()
        {
            if (IsProcessRunning(AktifGorevPID))
            {
                if (KillProcess(AktifGorevPID))
                {
                    kalanRestartSuresi.Text = "...";
                    MessageBox.Show($"{restartAppAdi.Text} yeniden başlatılıyor...", "Yeniden Başlatılıyor", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ProcessStartInfo psi = new ProcessStartInfo(txtSelectedPath.Text)
                    {
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = false
                    };

                    using (Process process = new Process { StartInfo = psi })
                    {
                        process.Start();
                        AktifGorevPID = process.Id;
                        MessageBox.Show($"{restartAppAdi.Text} yeniden başlatıldı", "Yeniden Başlatıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    restartTimer.Enabled = true;
                    restartTimer.Start();
                }
            }
        }

        private void selectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Yeniden Başlatılacak Uygulama Seç";
            openFileDialog.Filter = "BAT Dosyası|*.bat";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = openFileDialog.FileName;
                string dosyaAdi = openFileDialog.SafeFileName;

                MessageBox.Show($"{dosyaAdi} adlı dosya yeniden başlatmak için ayarlandı", "Dosya Seçildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                restartAppAdi.Text = $"{dosyaAdi}";
                txtSelectedPath.Text = dosyaYolu;

                restartTimer.Enabled = true;
                restartTimer.Start();
            }
        }

        private void cancelProcess_Click(object sender, EventArgs e)
        {
            restartTimer.Stop();
            restartTimer.Enabled = false;

            restartAppAdi.Text = "Bilinmeyen";
            txtSelectedPath.Text = string.Empty;
            kalanRestartSuresi.Text = "00 gün 00 saat 00 dakika 00 saniye";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            footerVerInfoLabel.Text = Application.ProductVersion;
        }
    }
}