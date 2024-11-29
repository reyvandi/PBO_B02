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
            panel1.Width += 50;
            if (panel1.Width >= 1600)
            {
                timer1.Stop();
                this.Hide();
                FormAdmin1 formadmin = new FormAdmin1();
                formadmin.ShowDialog();
            }

        }

        private void FormLoading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
