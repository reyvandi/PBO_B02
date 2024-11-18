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
    public partial class FormJasaServis : Form
    {
        public FormJasaServis()
        {
            InitializeComponent();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            timerSidebar.Start();
        }

        bool sidebarExpand;
        private void timerSidebar_Tick(object sender, EventArgs e)
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
            FormAdmin1 formTransaksi = new FormAdmin1();
            formTransaksi.Show();
            this.Hide();
        }

        private void buttonKomponen_Click(object sender, EventArgs e)
        {
            FormKomponen formKomponen = new FormKomponen();
            formKomponen.Show();
            this.Hide();
        }

        private void buttonTeknisi_Click(object sender, EventArgs e)
        {
            FormTeknisi formTeknisi = new FormTeknisi();
            formTeknisi.Show();
            this.Hide();
        }
    }
}
