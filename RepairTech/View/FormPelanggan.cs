using Npgsql;
using PROJECT_PBO.Controller;
using PROJECT_PBO.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PBO
{
    public partial class FormPelanggan : Form
    {
        private int id_akun;

        public FormPelanggan(int id_akun)
        {
            InitializeComponent();
            this.id_akun = id_akun;
            LoadUsername();
            LoadDataTransaksi();

        }
        private void FormPelanggan_Load(object sender, EventArgs e)
        {
            LoadDataTransaksi();
        }

        public void LoadDataTransaksi()
        {
            try
            {
                // Mengambil data transaksi berdasarkan id_akun
                DataTable result = TransaksiContext.GetTransaksiByAkun(id_akun);

                // Set the result to DataGridView
                dataGridViewTransaksi.DataSource = result;

                dataGridViewTransaksi.Columns["tanggal"].HeaderText = "Tanggal Transaksi";
                dataGridViewTransaksi.Columns["laptop"].HeaderText = "Nama Laptop";
                dataGridViewTransaksi.Columns["teknisi"].HeaderText = "Nama Teknisi";
                dataGridViewTransaksi.Columns["alamat"].HeaderText = "Alamat";
                dataGridViewTransaksi.Columns["status_transaksi"].HeaderText = "Status Transaksi";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void LoadUsername()
        {
            try
            {
                // Query untuk mengambil username berdasarkan id
                string query = "SELECT username FROM akun WHERE id_akun = @id_akun";
                NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@id_akun", id_akun)
            };

                // Eksekusi query
                DataTable result = DatabaseWrapper.queryExecutor(query, parameters);

                if (result.Rows.Count > 0)
                {
                    // Ambil data dari baris pertama
                    string username = result.Rows[0]["username"].ToString();

                    // Tampilkan pada label
                    labelUsername.Text = username;
                    labelUsername.AutoSize = true; // Label menyesuaikan ukuran teks
                }
                else
                {
                    labelUsername.Text = "Username tidak ditemukan.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonServisLaptop_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormServisLaptopPelanggan formServisLaptopPelanggan = new FormServisLaptopPelanggan(id_akun);
            formServisLaptopPelanggan.Show();
            //if (formServisLaptopPelanggan.ShowDialog() == DialogResult.OK)
            //{
            //    LoadDataTransaksi();
            //}

            //this.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN lOGIN = new LOGIN();
            lOGIN.Show();
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        bool sidebarExpand;
        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                if (sidebarExpand)
                {
                    sidebar.Width -= 10;
                    if (sidebar.Width == sidebar.MinimumSize.Width)
                    {
                        sidebarExpand = false;
                        timer1.Stop();
                    }
                }
                else
                {
                    sidebar.Width += 10;
                    if (sidebar.Width == sidebar.MaximumSize.Width)
                    {
                        sidebarExpand = true;
                        timer1.Stop();
                    }
                }

            }
        }

        private void buttonServis_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormServisLaptopPelanggan formServisLaptopPelanggan = new FormServisLaptopPelanggan(id_akun);
            formServisLaptopPelanggan.Show();
        }
    }
}
