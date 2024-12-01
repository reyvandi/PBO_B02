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
                // Mengambil data transaksi berdasarkan username (nama_pelanggan)
                string username = labelUsername.Text; // Assuming the username is displayed in the label
                DataTable result = TransaksiContext.GetTransaksiByUsername(username);

                if (result.Rows.Count > 0)
                {
                    // Menambahkan kolom "Nomor" secara manual
                    DataTable formattedResult = new DataTable();
                    formattedResult.Columns.Add("Nomor", typeof(int));
                    formattedResult.Columns.Add("Tanggal Transaksi", typeof(string));
                    formattedResult.Columns.Add("Merk Laptop", typeof(string));
                    formattedResult.Columns.Add("Nama Teknisi", typeof(string));
                    formattedResult.Columns.Add("Alamat", typeof(string));
                    formattedResult.Columns.Add("Status Transaksi", typeof(string));

                    // Menyalin data dari hasil query ke dalam DataTable baru dengan kolom yang sesuai
                    for (int i = 0; i < result.Rows.Count; i++)
                    {
                        DataRow row = formattedResult.NewRow();
                        row["Nomor"] = i + 1; // Nomor urut
                        row["Tanggal Transaksi"] = Convert.ToDateTime(result.Rows[i]["tanggal"]).ToString("yyyy-MM-dd");
                        row["Merk Laptop"] = result.Rows[i]["laptop"];
                        row["Nama Teknisi"] = result.Rows[i]["teknisi"];
                        row["Alamat"] = result.Rows[i]["alamat"];
                        row["Status Transaksi"] = result.Rows[i]["status_transaksi"];
                        formattedResult.Rows.Add(row);
                    }

                    // Mengatur data ke DataGridView
                    dataGridViewTransaksi.DataSource = formattedResult;
                }
                //else
                //{
                //    MessageBox.Show("Tidak ada data transaksi untuk pengguna ini.");
                //    dataGridViewTransaksi.DataSource = null;
                //}
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
