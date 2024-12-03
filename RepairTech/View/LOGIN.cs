using System;
using Npgsql;
using System.Windows.Forms;
using PROJECT_PBO.Controller;
using PROJECT_PBO.Model;
using PROJECT_PBO.View;
using PROJECT_PBO.Model;
using System.Data;

namespace PROJECT_PBO
{
    public partial class LOGIN : Form
    {
        private AkunContext akun;
        private int id_akun;

        public LOGIN()
        {
            InitializeComponent();
            akun = new AkunContext();

            this.buttonLOGIN.Click += new System.EventHandler(this.buttonLOGIN_Click);
            textBoxPASSWORD.PasswordChar = '*';

            // Event handler untuk checkbox 'showPasswordCheckBox'
            showPasswordCheckBox.CheckedChanged += new EventHandler(showPasswordCheckBox_CheckedChanged);
        }

        private void buttonLOGIN_Click(object sender, EventArgs e)
        {
            string username = textBoxUSERNAME.Text.Trim();
            string password = textBoxPASSWORD.Text.Trim();

            string role = ValidateLogin(username, password);
            if (!string.IsNullOrEmpty(role))
            {
                //MessageBox.Show($"Login berhasil sebagai {role}", "Login Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (role == "admin")
                {
                    FormAdmin1 formAdmin1 = new FormAdmin1(); // Form khusus untuk Admin  
                    formAdmin1.Show();
                }
                else if (role == "pelanggan")
                {
                    FormPelanggan formPelanggan = new FormPelanggan(id_akun); // Form khusus untuk User
                    formPelanggan.Show();
                }

                this.Hide(); // Menutup form login setelah login berhasil
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Logika untuk checkbox yang mengubah visibilitas password
        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPASSWORD.PasswordChar = showPasswordCheckBox.Checked ? '\0' : '*';
        }

        public string ValidateLogin(string username, string password)
        {
            DataTable result = akun.GetAkunByUsernamePassword(username, password);

            if (result.Rows.Count > 0)
            {
                id_akun = Convert.ToInt32(result.Rows[0]["id_akun"]);

                // Ambil data role dari hasil query
                string role = result.Rows[0]["role"].ToString();
                return role;
            }
            return null; // Jika tidak ada hasil (login gagal)
        }


        private void textBoxPASSWORD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUSERNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister formRegister = new FormRegister(); // Form khusus untuk Register
            formRegister.Show();

            this.Hide();
        }

        private void buttonLOGIN_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPASSWORD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Jika tombol Enter ditekan
            {
                buttonLOGIN.PerformClick(); // Klik tombol Login
                e.SuppressKeyPress = true; // Mencegah bunyi 'ding' dari tombol Enter
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity = +.2;
        }
    }
}