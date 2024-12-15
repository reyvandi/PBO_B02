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
    public partial class AddTransaksiForm : Form
    {
        Dictionary<string, int> jumlahKomponen = new Dictionary<string, int>();

        public AddTransaksiForm()
        {
            InitializeComponent();
        }

        private void AddTransaksiForm_Load(object sender, EventArgs e)
        {
            LoadJenisKerusakan();
            LoadTeknisi();
            LoadKomponen();
            numericUpDownJumlah.Value = 1; // Nilai awal untuk jumlah
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

        public void LoadKomponen()
        {
            try
            {
                string query = "SELECT id_komponen, nama_komponen FROM komponen";

                DataTable result = DatabaseWrapper.queryExecutor(query);

                comboBoxKomponen.DataSource = result; // Set DataTable sebagai sumber data
                comboBoxKomponen.DisplayMember = "nama_komponen"; // Jenis kerusakan ditampilkan
                comboBoxKomponen.ValueMember = "id_komponen"; // id_jasa_perbaikan digunakan sebagai value
                comboBoxKomponen.SelectedIndex = -1; // Tidak ada item yang dipilih
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

        private void btnTambahKomponen_Click(object sender, EventArgs e)
        {
            if (comboBoxKomponen.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih komponen terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedKomponen = comboBoxKomponen.Text;
            int jumlah = (int)numericUpDownJumlah.Value;

            if (jumlah <= 0)
            {
                MessageBox.Show("Jumlah harus lebih besar dari 0.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (jumlahKomponen.ContainsKey(selectedKomponen))
            {
                MessageBox.Show("Komponen ini sudah ditambahkan. Silakan ubah jumlah jika diperlukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tambahkan komponen ke dictionary
            jumlahKomponen[selectedKomponen] = jumlah;

            // Update ListBox
            UpdateListBoxKomponen();

            comboBoxKomponen.SelectedIndex = -1;
            numericUpDownJumlah.Value = 1; // Reset jumlah ke 1
        }
        private void btnHapusKomponen_Click(object sender, EventArgs e)
        {
            if (listBoxKomponen.SelectedItem != null)
            {
                string selectedKomponen = listBoxKomponen.SelectedItem.ToString().Split('-')[0].Trim(); // Hanya nama komponen
                jumlahKomponen.Remove(selectedKomponen);

                // Update ListBox
                UpdateListBoxKomponen();
            }
            else
            {
                MessageBox.Show("Pilih komponen yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateListBoxKomponen()
        {
            listBoxKomponen.Items.Clear();

            foreach (var item in jumlahKomponen)
            {
                listBoxKomponen.Items.Add($"{item.Key} - Jumlah: {item.Value}");
            }
        }

        private void buttonTambahTransaksi_Click(object sender, EventArgs e)
        {
            try
            {
                // Buat objek transaksi utama
                M_Transaksi transaksi = new M_Transaksi
                {
                    nama_pelanggan = textBoxPelanggan.Text,
                    laptop = string.IsNullOrWhiteSpace(textBoxMerkLaptop.Text) ? null : textBoxMerkLaptop.Text,
                    id_teknisi = comboBoxTeknisi.SelectedItem != null
                        ? (int?)((DataRowView)comboBoxTeknisi.SelectedItem)["id_teknisi"]
                        : null,
                    tanggal = DateTime.Now,
                    status_transaksi = "Telah Selesai", // Status default
                    alamat = null
                };

                // Ambil data detail transaksi (kerusakan)
                List<M_DetailTransaksi> detailTransaksi = new List<M_DetailTransaksi>();
                foreach (string kerusakan in listBoxKerusakan.Items)
                {
                    var jasaPerbaikan = JasaPerbaikanContext.GetByJenisKerusakan(kerusakan);
                    detailTransaksi.Add(new M_DetailTransaksi
                    {
                        id_jasa_perbaikan = jasaPerbaikan?.id_jasa_perbaikan ?? 0,
                        biaya = jasaPerbaikan?.biaya ?? 0
                    });
                }

                // Ambil data detail komponen
                List<M_DetailKomponen> detailKomponens = new List<M_DetailKomponen>();
                foreach (string komponen in listBoxKomponen.Items)
                {
                    string[] parts = komponen.Split(new string[] { " - Jumlah: " }, StringSplitOptions.None);
                    if (parts.Length == 2)
                    {
                        string namaKomponen = parts[0].Trim();
                        int jumlah = int.TryParse(parts[1], out int result) ? result : 0;

                        // Cek komponen di database dan tambah detail komponen
                        var dataKomponen = KomponenContext.GetByNamaKomponen(namaKomponen);
                        detailKomponens.Add(new M_DetailKomponen
                        {
                            id_komponen = dataKomponen?.id_komponen ?? 0,
                            harga = dataKomponen?.harga ?? 0,
                            jumlah = jumlah
                        });
                    }
                }

                // Simpan transaksi
                TransaksiContext.TambahTransaksi(transaksi, detailTransaksi, detailKomponens);

                // Pesan sukses
                MessageBox.Show("Transaksi berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormAdmin1 formAdmin1 = new FormAdmin1();
                formAdmin1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxKomponen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdmin1 formAdmin1 = new FormAdmin1();
            formAdmin1.Show();
            this.Hide();
        }

        private void comboBoxTeknisi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
