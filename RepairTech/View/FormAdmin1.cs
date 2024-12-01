using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using PROJECT_PBO;
using PROJECT_PBO.Controller;
using PROJECT_PBO.View;

namespace PROJECT_PBO
{


    public partial class FormAdmin1 : Form
    {
        public FormAdmin1()
        {
            InitializeComponent();

        }
        private void FormAdmin1_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            dataGridView1.SortCompare += DataGridView1_SortCompare;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
        }

        private void AddStatusComboBoxColumn()
        {
            // Periksa apakah kolom 'status_transaksi' ada sebelum menghapus
            if (dataGridView1.Columns.Contains("status_transaksi"))
            {
                dataGridView1.Columns.Remove("status_transaksi");
            }

            // Tambahkan ComboBox untuk kolom Status Transaksi
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Status Transaksi",
                Name = "StatusTransaksiComboBox",
                DataPropertyName = "status_transaksi", // Sesuaikan dengan nama kolom database
                DataSource = new string[] { "Belum Selesai", "Telah Selesai" },
                FlatStyle = FlatStyle.Flat
            };

            dataGridView1.Columns.Add(comboBoxColumn);
        }


        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "StatusTransaksiComboBox")
            {
                // Validasi keberadaan kolom
                if (!dataGridView1.Columns.Contains("id_transaksi"))
                {
                    MessageBox.Show("Kolom 'id_transaksi' tidak ditemukan di DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validasi nilai
                if (dataGridView1.Rows[e.RowIndex].Cells["id_transaksi"].Value == null)
                {
                    MessageBox.Show("ID Transaksi tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idTransaksi = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_transaksi"].Value);
                string statusBaru = dataGridView1.Rows[e.RowIndex].Cells["StatusTransaksiComboBox"].Value?.ToString();

                if (!string.IsNullOrEmpty(statusBaru))
                {
                    bool isUpdated = TransaksiContext.UpdateStatusTransaksi(idTransaksi, statusBaru);

                    if (isUpdated)
                    {
                        MessageBox.Show("Status transaksi berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui status transaksi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadDataToDataGridView()
        {
            try
            {
                // Ambil data transaksi dengan detailnya
                DataTable dataTable = TransaksiContext.GetAllTransaksiWithDetails();

                // Tambahkan kolom tersembunyi untuk penyortiran
                if (!dataTable.Columns.Contains("status_transaksi_sort"))
                {
                    dataTable.Columns.Add("status_transaksi_sort", typeof(int));
                    foreach (DataRow row in dataTable.Rows)
                    {
                        row["status_transaksi_sort"] = row["status_transaksi"].ToString() == "Belum Selesai" ? 1 : 2;
                    }
                }

                // Set DataSource untuk DataGridView
                dataGridView1.DataSource = dataTable;

                // Atur header kolom
                dataGridView1.Columns["id_transaksi"].Visible = false;
                dataGridView1.Columns["tanggal"].HeaderText = "Tanggal";
                dataGridView1.Columns["nama_pelanggan"].HeaderText = "Nama Pelanggan";
                dataGridView1.Columns["merk_laptop"].HeaderText = "Merk Laptop";
                dataGridView1.Columns["kerusakan"].HeaderText = "Kerusakan";
                dataGridView1.Columns["alamat"].HeaderText = "Alamat";
                dataGridView1.Columns["komponen"].HeaderText = "Komponen Yang Dibeli";  // Kolom Komponen
                dataGridView1.Columns["total_harga"].HeaderText = "Total Harga";  // Kolom Total Harga

                // Sembunyikan kolom penyortiran
                dataGridView1.Columns["status_transaksi_sort"].Visible = false;

                // Tambahkan ComboBox untuk kolom Status Transaksi
                AddStatusComboBoxColumn();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView1_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            // Jika kolom adalah StatusTransaksiComboBox
            if (e.Column.Name == "StatusTransaksiComboBox")
            {
                // Ambil nilai kolom penyortiran
                int value1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex1].Cells["status_transaksi_sort"].Value);
                int value2 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex2].Cells["status_transaksi_sort"].Value);

                // Bandingkan nilai
                e.SortResult = value1.CompareTo(value2);

                // Tentukan event sudah ditangani
                e.Handled = true;
            }
        }


        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LOGIN formLogin = new LOGIN();
            formLogin.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }


        private void buttonKomponen_Click(object sender, EventArgs e)
        {
            FormKomponen formKomponen = new FormKomponen();
            formKomponen.Show();
            this.Hide();
        }

        private void FormKomponen_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            timerSidebar.Start();
        }

        bool sidebarExpand;
        private void timerSidebar_Tick_1(object sender, EventArgs e)
        {
            {
                if (sidebarExpand)
                {
                    sidebar.Width -= 10;
                    if (sidebar.Width == sidebar.MinimumSize.Width)
                    {
                        sidebarExpand = false;
                        timerSidebar.Stop();
                    }
                }
                else
                {
                    sidebar.Width += 10;
                    if (sidebar.Width == sidebar.MaximumSize.Width)
                    {
                        sidebarExpand = true;
                        timerSidebar.Stop();
                    }
                }

            }
        }

        private void buttonTransaksi_Click(object sender, EventArgs e)
        {

        }

        private void buttonJasa_Click(object sender, EventArgs e)
        {
            FormJasaServis formJasa = new FormJasaServis();
            formJasa.Show();
            this.Hide();
        }

        private void buttonTeknisi_Click(object sender, EventArgs e)
        {
            FormTeknisi formTeknisi = new FormTeknisi();
            formTeknisi.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            AddTransaksiForm addTransaksiForm = new AddTransaksiForm();
            addTransaksiForm.Show();
            this.Hide();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            LOGIN formLogin = new LOGIN();
            formLogin.Show();
            this.Hide();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
