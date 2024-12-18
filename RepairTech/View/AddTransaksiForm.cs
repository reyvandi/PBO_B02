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

        public void LoadKomponen()
        {
            try
            {
                // Mengambil data komponen dari KomponenContext
                DataTable komponenList = KomponenContext.All();

                // Binding data ke ComboBox
                comboBoxKomponen.DataSource = komponenList;
                comboBoxKomponen.DisplayMember = "nama_komponen";  // Nama komponen yang akan ditampilkan
                comboBoxKomponen.ValueMember = "id_komponen";  // ID komponen sebagai nilai yang digunakan
                comboBoxKomponen.SelectedIndex = -1;  // Agar tidak ada item yang terpilih saat pertama kali
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

            // Ambil data komponen dari database
            var dataKomponen = KomponenContext.GetByNamaKomponen(selectedKomponen);
            if (dataKomponen == null)
            {
                MessageBox.Show("Komponen tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataKomponen.stok <= 0)
            {
                MessageBox.Show("Komponen yang anda pilih sudah habis.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hitung jumlah total dari komponen yang sudah ada di ListBox
            int totalJumlah = jumlah;
            if (jumlahKomponen.ContainsKey(selectedKomponen))
            {
                totalJumlah += jumlahKomponen[selectedKomponen];
            }

            // Cek apakah jumlah total melebihi stok
            if (totalJumlah > dataKomponen.stok)
            {
                MessageBox.Show($"Jumlah Komponen yang dipilih melebihi stok yang tersedia).", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tambahkan atau update komponen di dictionary
            if (jumlahKomponen.ContainsKey(selectedKomponen))
            {
                jumlahKomponen[selectedKomponen] += jumlah;
            }
            else
            {
                jumlahKomponen[selectedKomponen] = jumlah;
            }

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
                // Validasi input
                if (!ValidasiInput())
                    return;

                // Buat objek transaksi
                M_Transaksi transaksi = BuatTransaksiUtama();

                // Ambil detail transaksi
                var detailTransaksi = AmbilDetailKerusakan();
                var detailKomponens = AmbilDetailKomponen();

                // Simpan transaksi
                TransaksiContext.TambahTransaksi(transaksi, detailTransaksi, detailKomponens);

                // Berhasil
                MessageBox.Show("Transaksi berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NavigasiKeFormAdmin();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidasiInput()
        {
            if (listBoxKerusakan.Items.Count == 0 && listBoxKomponen.Items.Count == 0)
            {
                MessageBox.Show("Harap isi salah satu dari list Kerusakan atau Komponen!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private M_Transaksi BuatTransaksiUtama()
        {
            return new M_Transaksi
            {
                nama_pelanggan = textBoxPelanggan.Text,
                laptop = string.IsNullOrWhiteSpace(textBoxMerkLaptop.Text) ? null : textBoxMerkLaptop.Text,
                id_teknisi = comboBoxTeknisi.SelectedItem != null
                    ? (int?)((DataRowView)comboBoxTeknisi.SelectedItem)["id_teknisi"]
                    : null,
                tanggal = DateTime.Now,
                status_transaksi = "Telah Selesai",
                alamat = null
            };
        }

        private List<M_DetailTransaksi> AmbilDetailKerusakan()
        {
            var detailTransaksi = new List<M_DetailTransaksi>();

            foreach (string kerusakan in listBoxKerusakan.Items)
            {
                var jasaPerbaikan = JasaPerbaikanContext.GetByJenisKerusakan(kerusakan);
                detailTransaksi.Add(new M_DetailTransaksi
                {
                    id_jasa_perbaikan = jasaPerbaikan?.id_jasa_perbaikan ?? 0,
                    biaya = jasaPerbaikan?.biaya ?? 0
                });
            }

            return detailTransaksi;
        }

        private List<M_DetailKomponen> AmbilDetailKomponen()
        {
            var detailKomponens = new List<M_DetailKomponen>();

            foreach (string komponen in listBoxKomponen.Items)
            {
                string[] parts = komponen.Split(new string[] { " - Jumlah: " }, StringSplitOptions.None);
                if (parts.Length == 2)
                {
                    string namaKomponen = parts[0].Trim();
                    int jumlah = int.TryParse(parts[1], out int result) ? result : 0;

                    var dataKomponen = KomponenContext.GetByNamaKomponen(namaKomponen);
                    detailKomponens.Add(new M_DetailKomponen
                    {
                        id_komponen = dataKomponen?.id_komponen ?? 0,
                        harga = dataKomponen?.harga ?? 0,
                        jumlah = jumlah
                    });
                }
            }

            return detailKomponens;
        }

        private void NavigasiKeFormAdmin()
        {
            FormAdmin1 formAdmin1 = new FormAdmin1();
            formAdmin1.Show();
            this.Hide();
        }


        private void listBoxKomponen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigasiKeFormAdmin();
        }

        private void comboBoxTeknisi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
