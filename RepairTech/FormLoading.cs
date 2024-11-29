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
                label1.Text = progressBar1.Value.ToString() +"%";
                
            }
            else
            {
                timer1.Stop();
                this.Hide();
                FormAdmin1 formadmin = new FormAdmin1();
                formadmin.Show();
            }

        }

        private void FormLoading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
