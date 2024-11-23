using PROJECT_PBO.Controller;
using PROJECT_PBO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT_PBO.Model;

namespace PROJECT_PBO.View
{
    public partial class FormRegister : Form
    {
        private AkunContext akun;
        public FormRegister()
        {
            InitializeComponent();
            akun = new AkunContext();
        }

        private void buttonRegistrasi_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email, Username, dan password harus diisi!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if email or username already exists
            if (AkunContext.IsUsernameExist(username))
            {
                MessageBox.Show("Username sudah terdaftar. Gunakan username lain.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AkunContext.IsEmailExist(email))
            {
                MessageBox.Show("Email sudah terdaftar. Gunakan email lain.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create and register new account
            M_Akun newAkun = new M_Akun
            {
                username = username,
                password = password, // Pastikan ini di-hash untuk keamanan
                email = email,
                role = "pelanggan"
            };

            try
            {
                akun.RegisterAkun(newAkun);
                MessageBox.Show("Registrasi berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LOGIN login = new LOGIN();
                login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registrasi gagal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();
            login.Show();
            this.Hide();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
