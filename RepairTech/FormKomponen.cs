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

namespace PROJECT_PBO
{


    public partial class FormKomponen : Form
    {
        public FormKomponen()
        {
            InitializeComponent();
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

        private void FormKomponen_Load(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonMenu_Click_1(object sender, EventArgs e)
        {
            timerSidebar.Start();
        }

        private void buttonTransaksi_Click(object sender, EventArgs e)
        {

        }

        private void buttonKomponen_Click(object sender, EventArgs e)
        {

        }

        private void buttonJasa_Click(object sender, EventArgs e)
        {

        }

        private void buttonTeknisi_Click(object sender, EventArgs e)
        {

        }

        bool sidebarExpand;
        private void timerSidebar_Tick_1(object sender, EventArgs e)
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
}
