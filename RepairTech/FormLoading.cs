using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PBO
{
    public partial class FormLoading : Form
    {
        public FormLoading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < 100)
            {
                progressBar1.Value = +2;
                label1.Text = progressBar1.Value.ToString() + "%";

            }
            else
            {
                timer1.Stop();
                this.Hide();
                FormAdmin1 formadmin = new FormAdmin1();
                formadmin.Show();
                MessageBox.Show("Selamat datang Admin RepairTech");
            }

        }

        private void FormLoading_Load(object sender, EventArgs e)
        {
            timer1.Start();
            // Atur properti ProgressBar
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0; // Nilai awal
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Size = new Size(1237, 30);
            progressBar1.Style = ProgressBarStyle.Continuous;

            // Gunakan OwnerDraw (menggambar ulang manual)
            progressBar1.Paint += ProgressBar1_Paint;
        }

        // Event handler untuk menggambar ulang ProgressBar
        private void ProgressBar1_Paint(object sender, PaintEventArgs e)
        {
            ProgressBar progressBar = (ProgressBar)sender;
            Rectangle rect = progressBar.ClientRectangle;

            // Gambar background
            e.Graphics.FillRectangle(new SolidBrush(Color.DarkBlue), rect);

            // Hitung lebar bar berdasarkan nilai progres
            rect.Width = (int)(rect.Width * ((double)progressBar.Value / progressBar.Maximum));

            // Gambar bar progres dengan warna yang diinginkan
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(24, 23, 80)), rect);
        }

            private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
