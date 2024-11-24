using Npgsql;
using PROJECT_PBO.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PBO.View
{
    public partial class FormServisLaptopPelanggan : Form
    {
        private int id_akun;

        public FormServisLaptopPelanggan(int id_akun)
        {
            InitializeComponent();
            this.id_akun = id_akun;
            LoadUsername();
        }
        private void FormServisLaptopPelanggan_Load(object sender, EventArgs e)
        {
            LoadJenisKerusakan();
            LoadTeknisi();
        }

        public void LoadUsername()
        {
            try
            {
                string query = "SELECT username FROM akun WHERE id_akun = @id_akun";
                NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@id_akun", id_akun)
            };

                DataTable result = DatabaseWrapper.queryExecutor(query, parameters);

                if (result.Rows.Count > 0)
                {
                    string username = result.Rows[0]["username"].ToString();

                    labelUsername.Text = username;
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

        public void LoadJenisKerusakan()
        {
            try
            {
                string query = "SELECT id_jasa_perbaikan, jenis_kerusakan FROM jasa_perbaikan";

                DataTable result = DatabaseWrapper.queryExecutor(query);

                comboBoxKerusakan.DataSource = result; // Set DataTable sebagai sumber data
                comboBoxKerusakan.DisplayMember = "jenis_kerusakan"; // Jenis kerusakan ditampilkan
                comboBoxKerusakan.ValueMember = "id_jasa_perbaikan"; // id_jasa_perbaikan digunakan sebagai value
                comboBoxKerusakan.SelectedIndex = -1; // Tidak ada item yang dipilih
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        public void LoadTeknisi()
        {
            try
            {
                string query = "SELECT id_teknisi, nama FROM teknisi";

                DataTable result = DatabaseWrapper.queryExecutor(query);

                comboBoxTeknisi.DataSource = result; // Set DataTable sebagai sumber data
                comboBoxTeknisi.DisplayMember = "nama"; // Nama teknisi ditampilkan di combobox
                comboBoxTeknisi.ValueMember = "id_teknisi"; // id_teknisi disimpan sebagai ValueMember
                comboBoxTeknisi.SelectedIndex = -1; // Tidak ada item yang dipilih
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void textBoxAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTransaksi_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPelanggan formPelanggan = new FormPelanggan(id_akun);
            formPelanggan.Show();
        }
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        bool sidebarExpand;
        private void timer1_Tick(object sender, EventArgs e)
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

        private void buttonTambahTransaksi_Click(object sender, EventArgs e)
        {
            try
            {
                // Ambil data dari form
                string namaLaptop = textBoxNamaLaptop.Text;
                string alamat = textBoxAlamat.Text;
                int idTeknisi = Convert.ToInt32(comboBoxTeknisi.SelectedValue);

                // Validasi input
                if (string.IsNullOrEmpty(namaLaptop) || string.IsNullOrEmpty(alamat) || listBoxKerusakan.Items.Count == 0)
                {
                    MessageBox.Show("Mohon lengkapi semua data.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insert ke tabel transaksi
                string insertTransaksiQuery = "INSERT INTO transaksi (id_akun, laptop, alamat, id_teknisi, tanggal) VALUES (@id_akun, @laptop, @alamat, @id_teknisi, @tanggal) RETURNING id_transaksi";
                NpgsqlParameter[] transaksiParams = {
                    new NpgsqlParameter("@id_akun", id_akun),
                    new NpgsqlParameter("@laptop", namaLaptop),
                    new NpgsqlParameter("@alamat", alamat),
                    new NpgsqlParameter("@id_teknisi", idTeknisi),
                    new NpgsqlParameter("@tanggal", DateTime.Now)
                };

                DataTable transaksiResult = DatabaseWrapper.queryExecutor(insertTransaksiQuery, transaksiParams);

                if (transaksiResult.Rows.Count > 0)
                {
                    int idTransaksi = Convert.ToInt32(transaksiResult.Rows[0]["id_transaksi"]);

                    // Insert ke tabel detail_transaksi
                    foreach (string kerusakan in listBoxKerusakan.Items)
                    {
                        // Ambil ID dan biaya kerusakan berdasarkan deskripsi
                        string selectKerusakanQuery = "SELECT id_jasa_perbaikan, biaya FROM jasa_perbaikan WHERE jenis_kerusakan = @jenis_kerusakan";
                        NpgsqlParameter[] kerusakanParams = {
                            new NpgsqlParameter("@jenis_kerusakan", kerusakan)
                        };

                        DataTable kerusakanResult = DatabaseWrapper.queryExecutor(selectKerusakanQuery, kerusakanParams);

                        if (kerusakanResult.Rows.Count > 0)
                        {
                            int idKerusakan = Convert.ToInt32(kerusakanResult.Rows[0]["id_jasa_perbaikan"]);
                            decimal biaya = Convert.ToDecimal(kerusakanResult.Rows[0]["biaya"]);

                            // Insert data ke tabel detail_transaksi
                            string insertDetailQuery = "INSERT INTO detail_transaksi (id_transaksi, id_jasa_perbaikan, biaya) VALUES (@id_transaksi, @id_jasa_perbaikan, @biaya)";
                            NpgsqlParameter[] detailParams = {
                                new NpgsqlParameter("@id_transaksi", idTransaksi),
                                new NpgsqlParameter("@id_jasa_perbaikan", idKerusakan),
                                new NpgsqlParameter("@biaya", biaya)
                            };

                            DatabaseWrapper.queryExecutor(insertDetailQuery, detailParams);
                        }
                    }

                    MessageBox.Show("Transaksi berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FormPelanggan formPelanggan = new FormPelanggan(id_akun);
                    formPelanggan.Show();
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan transaksi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTambahKerusakan_Click(object sender, EventArgs e)
        {
            if (comboBoxKerusakan.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih jenis kerusakan terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedKerusakan = comboBoxKerusakan.Text;

            foreach (string item in listBoxKerusakan.Items)
            {
                if (item == selectedKerusakan)
                {
                    MessageBox.Show("Kerusakan ini sudah ditambahkan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            listBoxKerusakan.Items.Add(selectedKerusakan);

            comboBoxKerusakan.SelectedIndex = -1;
        }



        private void btnHapusKerusakan_Click(object sender, EventArgs e)
        {
            if (listBoxKerusakan.SelectedItem != null)
            {
                listBoxKerusakan.Items.Remove(listBoxKerusakan.SelectedItem);
            }
            else
            {
                MessageBox.Show("Pilih kerusakan yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listBoxKerusakan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}