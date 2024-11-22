using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using PROJECT_PBO;

namespace PROJECT_PBO
{


    public partial class FormAdmin1 : Form
    {
        public FormAdmin1()
        {
            InitializeComponent();
            this.Resize += FormAdmin1_Resize;
        }

        private void FormAdmin1_Resize(object sender, EventArgs e)
        {
            // Tentukan margin dari kanan dan bawah
            int marginRight = 0; // Misalnya 10px dari kanan
            int marginBottom = 0; // Misalnya 10px dari bawah

            // Atur lokasi tombol logout
            panel7.Location = new Point(
                this.ClientSize.Width - panel7.Width - marginRight,
                this.ClientSize.Height - panel7.Height - marginBottom
            );
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LOGIN formLogin = new LOGIN();
            formLogin.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void FormAdmin1_Load(object sender, EventArgs e)
        {

        }

        private void buttonKomponen_Click(object sender, EventArgs e)
        {
            FormKomponen formKomponen = new FormKomponen();
            formKomponen.Show();
            this.Hide();
        }

        private void FormKomponen_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            timerSidebar.Start();
        }

        bool sidebarExpand;
        private void timerSidebar_Tick_1(object sender, EventArgs e)
        {
            {
                if (sidebarExpand)
                {
                    sidebar.Width -= 10;
                    if (sidebar.Width == sidebar.MinimumSize.Width)
                    {
                        sidebarExpand = false;
                        timerSidebar.Stop();
                    }
                }
                else
                {
                    sidebar.Width += 10;
                    if (sidebar.Width == sidebar.MaximumSize.Width)
                    {
                        sidebarExpand = true;
                        timerSidebar.Stop();
                    }
                }

            }
        }

        private void buttonTransaksi_Click(object sender, EventArgs e)
        {

        }

        private void buttonJasa_Click(object sender, EventArgs e)
        {
            FormJasaServis formJasa = new FormJasaServis();
            formJasa.Show();
            this.Hide();
        }

        private void buttonTeknisi_Click(object sender, EventArgs e)
        {
            FormTeknisi formTeknisi = new FormTeknisi();
            formTeknisi.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
