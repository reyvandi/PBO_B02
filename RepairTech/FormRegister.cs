using Npgsql;
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
    public partial class FormRegister : Form
    {

        private string connectionString = "Host=localhost;Username=postgres;Password=1;Database=RepairTech"; // Sesuaikan dengan konfigurasi Anda

        public FormRegister()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email) )
            {
                MessageBox.Show("Email, Username dan password harus diisi!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (RegisterAccount( username, password, email))
            {
                MessageBox.Show("Registrasi berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LOGIN login = new LOGIN(); // Form khusus untuk Login
                login.Show();
                this.Hide(); // Menutup form register setelah sukses
            }
            else
            {
                MessageBox.Show("Registrasi gagal! Username mungkin sudah ada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool RegisterAccount(string username, string password, string email)
        {
            bool isRegistered = false;

            // Membuka koneksi ke database PostgreSQL
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Mengecek apakah username sudah ada
                    string checkUsernameQuery = "SELECT COUNT(*) FROM akun WHERE Username = @username";
                    using (NpgsqlCommand checkUsernameCmd = new NpgsqlCommand(checkUsernameQuery, conn))
                    {
                        checkUsernameCmd.Parameters.AddWithValue("@username", username);
                        int usernameCount = Convert.ToInt32(checkUsernameCmd.ExecuteScalar());

                        if (usernameCount > 0)
                        {
                            MessageBox.Show("Username sudah terdaftar. Gunakan username lain.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return isRegistered; // Username sudah ada, tidak perlu melanjutkan
                        }
                    }

                    // Mengecek apakah email sudah ada
                    string checkEmailQuery = "SELECT COUNT(*) FROM akun WHERE Email = @email";
                    using (NpgsqlCommand checkEmailCmd = new NpgsqlCommand(checkEmailQuery, conn))
                    {
                        checkEmailCmd.Parameters.AddWithValue("@email", email);
                        int emailCount = Convert.ToInt32(checkEmailCmd.ExecuteScalar());

                        if (emailCount > 0)
                        {
                            MessageBox.Show("Email sudah terdaftar. Gunakan email lain.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return isRegistered; // Email sudah ada, tidak perlu melanjutkan
                        }
                    }

                    // Query untuk menyisipkan data pengguna baru dengan role 'Pelanggan'
                    string query = "INSERT INTO akun (Username, Password, Role, Email) VALUES (@username, @password, 'pelanggan',@email)";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        // Menghindari SQL Injection dengan parameterized query
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@email", email);// Pastikan ini di-hash untuk keamanan

                        // Mengeksekusi query dan memeriksa jumlah baris yang terpengaruh
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            isRegistered = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return isRegistered;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
