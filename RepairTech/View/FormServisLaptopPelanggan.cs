using Npgsql;
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
                string username = AkunContext.GetUsernameById(id_akun);

                if (!string.IsNullOrEmpty(username))
                {
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
                // Mengambil data jenis kerusakan dari JasaPerbaikanContext
                DataTable jasaPerbaikanList = JasaPerbaikanContext.All();

                // Binding data ke ComboBox
                comboBoxKerusakan.DataSource = jasaPerbaikanList;
                comboBoxKerusakan.DisplayMember = "jenis_kerusakan";  // Jenis kerusakan yang akan ditampilkan
                comboBoxKerusakan.ValueMember = "id_jasa_perbaikan";  // ID jenis kerusakan sebagai nilai yang digunakan
                comboBoxKerusakan.SelectedIndex = -1;  // Agar tidak ada item yang terpilih saat pertama kali
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
                // Mengambil data teknisi dari TeknisiContext
                DataTable teknisiList = TeknisiContext.All();

                // Binding data ke ComboBox
                comboBoxTeknisi.DataSource = teknisiList;
                comboBoxTeknisi.DisplayMember = "nama";  // Nama teknisi yang akan ditampilkan
                comboBoxTeknisi.ValueMember = "id_teknisi";  // ID teknisi sebagai nilai yang digunakan
                comboBoxTeknisi.SelectedIndex = -1;  // Agar tidak ada item yang terpilih saat pertama kali
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

            FormPelanggan formPelanggan = new FormPelanggan(id_akun);
            formPelanggan.Show();
            this.Hide();
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
                var transaksi = AmbilDataTransaksi();

                // Validasi data
                if (!ValidasiInput(transaksi))
                {
                    MessageBox.Show("Mohon lengkapi semua data.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tambahkan transaksi ke database
                int idTransaksi = SimpanTransaksi(transaksi);

                if (idTransaksi > 0)
                {
                    TambahkanDetailTransaksi(idTransaksi);
                    MessageBox.Show("Transaksi berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Alihkan ke form pelanggan
                    BukaFormPelanggan();
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

        // Metode untuk mengambil data transaksi dari form
        private M_Transaksi AmbilDataTransaksi()
        {
            return new M_Transaksi
            {
                nama_pelanggan = labelUsername.Text,
                laptop = textBoxNamaLaptop.Text,
                alamat = textBoxAlamat.Text,
                id_teknisi = Convert.ToInt32(comboBoxTeknisi.SelectedValue),
                tanggal = DateTime.Now,
                status_transaksi = "Belum Selesai"
            };
        }

        // Metode untuk validasi input
        private bool ValidasiInput(M_Transaksi transaksi)
        {
            return !string.IsNullOrEmpty(transaksi.laptop) &&
                   !string.IsNullOrEmpty(transaksi.alamat) &&
                   listBoxKerusakan.Items.Count > 0;
        }

        // Metode untuk menyimpan transaksi ke database
        private int SimpanTransaksi(M_Transaksi transaksi)
        {
            return TransaksiContext.AddTransaksi(transaksi);
        }

        // Metode untuk menambahkan detail transaksi
        private void TambahkanDetailTransaksi(int idTransaksi)
        {
            foreach (string kerusakan in listBoxKerusakan.Items)
            {
                var detailKerusakan = DetailTransaksiContext.GetKerusakanByDeskripsi(kerusakan);
                if (detailKerusakan != null)
                {
                    detailKerusakan.id_transaksi = idTransaksi;
                    DetailTransaksiContext.AddDetailTransaksi(detailKerusakan);
                }
            }
        }

        // Metode untuk membuka form pelanggan
        private void BukaFormPelanggan()
        {
            this.Hide();
            FormPelanggan formPelanggan = new FormPelanggan(id_akun);
            formPelanggan.Show();
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

        private void comboBoxKerusakan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();
            login.ShowDialog();
            this.Hide();
        }
    }
}