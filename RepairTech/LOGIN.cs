using System;
using Npgsql;
using System.Windows.Forms;

namespace PROJECT_PBO
{
    public partial class LOGIN : Form
    {
        // Koneksi ke database PostgreSQL
        private string connectionString = "Host=localhost;Username=postgres;Password=1;Database=RepairTech"; // Sesuaikan dengan konfigurasi Anda

        public LOGIN()
        {
            InitializeComponent();

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
                MessageBox.Show($"Login berhasil sebagai {role}", "Login Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (role == "admin")
                {
                    FormAdmin formAdmin = new FormAdmin(); // Form khusus untuk Admin
                    formAdmin.Show();
                }
                else if (role == "pelanggan")
                {
                    FormPelanggan formPelanggan = new FormPelanggan(); // Form khusus untuk User
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

        private string ValidateLogin(string username, string password)
        {
            string role = null;

            // Membuka koneksi ke database PostgreSQL
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query untuk mengecek apakah username dan password cocok dan mengambil perannya
                    string query = "SELECT Role FROM akun WHERE Username = @username AND Password = @password";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        // Menghindari SQL Injection dengan parameterized query
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        // Mengeksekusi query dan mengambil role
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            role = result.ToString(); // Menyimpan role yang ditemukan
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return role;
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

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}