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
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
        }

        private void AddStatusComboBoxColumn()
        {
            if (!dataGridView1.Columns.Contains("StatusTransaksiComboBox"))
            {
                DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn
                {
                    Name = "StatusTransaksiComboBox",
                    HeaderText = "Status Transaksi",
                    DataSource = new string[] { "Belum Selesai", "Telah Selesai" },
                    ValueType = typeof(string)
                };

                dataGridView1.Columns.Add(comboBoxColumn);

                // Sinkronkan nilai default dengan kolom status_transaksi
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells["StatusTransaksiComboBox"].Value = row.Cells["status_transaksi"].Value?.ToString();
                }
            }
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "StatusTransaksiComboBox")
            {
                int idTransaksi = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_transaksi"].Value);
                string statusBaru = dataGridView1.Rows[e.RowIndex].Cells["StatusTransaksiComboBox"].Value?.ToString();

                if (!string.IsNullOrEmpty(statusBaru))
                {
                    TransaksiContext.UpdateStatusTransaksi(idTransaksi, statusBaru);
                }
            }
        }

        private void LoadDataToDataGridView()
        {
            try
            {
                // Ambil data transaksi dari context
                DataTable dataTable = TransaksiContext.GetAllTransaksiWithDetails();

                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = null;

                // Atur DataSource untuk DataGridView
                dataGridView1.DataSource = dataTable;

                // Tambahkan kolom nomor (jika belum ada)
                if (!dataGridView1.Columns.Contains("No"))
                {
                    DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn
                    {
                        HeaderText = "No",
                        Name = "No",
                        ReadOnly = true,
                        Width = 50,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                    };
                    dataGridView1.Columns.Insert(0, nomorColumn);
                }

                // Set nomor urut di kolom "No"
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["No"].Value = i + 1; // Mulai dari 1
                }

                // Tambahkan ComboBox langsung ke kolom status_transaksi
                if (dataGridView1.Columns.Contains("status_transaksi"))
                {
                    int index = dataGridView1.Columns["status_transaksi"].Index;
                    dataGridView1.Columns.Remove("status_transaksi");

                    DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn
                    {
                        DataPropertyName = "status_transaksi",
                        HeaderText = "Status Transaksi",
                        DataSource = new string[] { "Belum Selesai", "Telah Selesai" },
                        ValueType = typeof(string),
                        Name = "StatusTransaksiComboBox",
                        SortMode = DataGridViewColumnSortMode.Automatic
                    };
                    dataGridView1.Columns.Insert(index, comboBoxColumn);
                }

                // Atur header kolom lainnya
                dataGridView1.Columns["id_transaksi"].Visible = false;
                dataGridView1.Columns["tanggal"].HeaderText = "Tanggal";
                dataGridView1.Columns["nama_pelanggan"].HeaderText = "Nama Pelanggan";
                dataGridView1.Columns["merk_laptop"].HeaderText = "Merk Laptop";
                dataGridView1.Columns["kerusakan"].HeaderText = "Kerusakan";
                dataGridView1.Columns["alamat"].HeaderText = "Alamat";
                dataGridView1.Columns["komponen"].HeaderText = "Komponen Yang Dibeli";
                dataGridView1.Columns["total_harga"].HeaderText = "Total Harga";

                // Tambahkan gaya header kolom
                DataGridViewCellStyle headerStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.FromArgb(31, 31, 68),
                    ForeColor = Color.White,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                };
                dataGridView1.ColumnHeadersDefaultCellStyle = headerStyle;
                dataGridView1.EnableHeadersVisualStyles = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            FormJasaPerbaikan formJasa = new FormJasaPerbaikan();
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

        private void buttonTambah_Click_1(object sender, EventArgs e)
        {
            AddTransaksiForm addTransaksiForm = new AddTransaksiForm();
            addTransaksiForm.Show();
            this.Hide();
        }
    }
}
