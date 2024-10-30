using System;
using Npgsql;
using System.Windows.Forms;

namespace PROJECT_PBO
{
    public partial class LOGIN : Form
    {
        // Koneksi ke database PostgreSQL
        private string connectionString = "Host=localhost;Username=postgres;Password=M#Anb8nb;Database=DATA PBO"; // Sesuaikan dengan konfigurasi Anda

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

            if (ValidateLogin(username, password))
            {
                Menu_utama menu_Utama = new Menu_utama();   
                menu_Utama.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Logika untuk checkbox yang mengubah visibilitas password
        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                textBoxPASSWORD.PasswordChar = '\0'; // Password terlihat
            }
            else
            {
                textBoxPASSWORD.PasswordChar = '*'; // Kembali ke tanda bintang
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            bool isValid = false;

            // Membuka koneksi ke database PostgreSQL
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query untuk mengecek apakah username dan password cocok
                    string query = "SELECT COUNT(1) FROM Users WHERE Username = @username AND Password = @password";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        // Menghindari SQL Injection dengan parameterized query
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        // Mengeksekusi query
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 1)
                        {
                            isValid = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return isValid;
        }
    }
}
