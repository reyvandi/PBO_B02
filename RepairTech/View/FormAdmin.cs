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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SetInitialPanelLayout(); // Panggil metode untuk mengatur ulang tampilan panel
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();
            login.Show();
            this.Hide();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
        // Metode untuk mengatur ulang panel ke tampilan awal
        private void SetInitialPanelLayout()
        {
            panel4.Controls.Clear(); // Hapus kontrol yang ada di panel

            // Tambahkan kontrol awal ke panel
            Label label1 = new Label() { Text = "Label Awal", Location = new Point(10, 10) };
            Button buttonInPanel = new Button() { Text = "Button di Panel", Location = new Point(10, 50) };

            panel4.Controls.Add(label1);
            panel4.Controls.Add(buttonInPanel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear(); // Hapus semua kontrol di dalam panel

            // Tambahkan kontrol baru ke panel
            Label newLabel = new Label() { Text = "Tampilan Baru", Location = new Point(10, 10) };
            panel4.Controls.Add(newLabel);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
