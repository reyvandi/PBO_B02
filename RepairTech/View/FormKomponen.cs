using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using PROJECT_PBO.Controller;
using PROJECT_PBO.Model;
using PROJECT_PBO.View;

namespace PROJECT_PBO
{


    public partial class FormKomponen : Form
    {
        public FormKomponen()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
            this.Resize += FormKomponen_Resize;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDataKomponen();
        }
        private void LoadDataKomponen()
        {
            try
            {
                dataGridView1.AllowUserToAddRows = false;

                DataTable komponenData = KomponenContext.All();
                if (komponenData == null || komponenData.Rows.Count == 0)
                {
                    MessageBox.Show("Tidak ada data yang ditemukan!");
                    return;
                }


                dataGridView1.Columns.Clear();


                DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = "No",
                    Name = "nomor"
                };
                dataGridView1.Columns.Add(nomorColumn);


                dataGridView1.DataSource = komponenData;


                if (dataGridView1.Columns["id_komponen"] != null) dataGridView1.Columns["id_komponen"].Visible = false;

                if (dataGridView1.Columns["nama_komponen"] != null)
                    dataGridView1.Columns["nama_komponen"].HeaderText = "Nama Komponen";

                if (dataGridView1.Columns["harga"] != null)
                    dataGridView1.Columns["harga"].HeaderText = "Harga";

                if (dataGridView1.Columns["stok"] != null)
                    dataGridView1.Columns["stok"].HeaderText = "Stok";

                // Isi kolom nomor urut
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["nomor"].Value = (i + 1).ToString();
                }

                // Tambahkan tombol Update
                DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Update",
                    HeaderText = "Update",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(updateButtonColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error dalam LoadDataKomponen: {ex.Message}\n{ex.StackTrace}");
            }
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

        private void FormKomponen_Load(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonMenu_Click_1(object sender, EventArgs e)
        {
            timerSidebar.Start();
        }

        private void buttonTransaksi_Click(object sender, EventArgs e)
        {
            FormAdmin1 formTransaksi = new FormAdmin1();
            formTransaksi.Show();
            this.Hide();

        }

        private void buttonKomponen_Click(object sender, EventArgs e)
        {
            FormKomponen formKomponen = new FormKomponen();
            formKomponen.Show();
            this.Hide();
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

        bool sidebarExpand;
        private void timerSidebar_Tick_1(object sender, EventArgs e)
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

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dataGridView1.Columns["Update"].Index)
            {
                try
                {
                    int komponenId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_komponen"].Value);

                    DataTable komponenData = KomponenContext.getKomponenById(komponenId);

                    if (komponenData.Rows.Count > 0)
                    {
                        DataRow row = komponenData.Rows[0];
                        M_Komponen komponen = new M_Komponen
                        {
                            id_komponen = (int)row["id_komponen"],
                            nama_komponen = row["nama_komponen"].ToString(),
                            harga = (decimal)row["harga"],
                            stok = (int)row["stok"]
                        };

                        this.Hide();
                        AddKomponenForm addKomponenForm = new AddKomponenForm();
                        addKomponenForm.PopulateForm(komponen);
                        if (addKomponenForm.ShowDialog() == DialogResult.OK)
                        {
                            LoadDataKomponen();
                        }
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddKomponenForm addKomponenForm = new AddKomponenForm();

            if (addKomponenForm.ShowDialog() == DialogResult.OK)
            {
                LoadDataKomponen();
            }

            this.Show();
        }

        private void FormKomponen_Resize(object sender, EventArgs e)
        {
           /* // Tentukan margin dari kanan dan bawah
            int marginRight = 0; // Misalnya 10px dari kanan
            int marginBottom = 0; // Misalnya 10px dari bawah

            // Atur lokasi tombol logout
            panel7.Location = new Point(
                this.ClientSize.Width - panel7.Width - marginRight,
                this.ClientSize.Height - panel7.Height - marginBottom
            );*/
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LOGIN formLogin = new LOGIN();
            formLogin.Show();
            this.Hide();
        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {
            LOGIN formLogin = new LOGIN();
            formLogin.Show();
            this.Hide();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                try
                {
                    DataTable searchResults = KomponenContext.Search(keyword);

                    if (searchResults.Rows.Count == 0)
                    {
                        MessageBox.Show("Tidak ada data yang ditemukan untuk pencarian ini.");
                        return;
                    }

                    dataGridView1.DataSource = null;
                    dataGridView1.Columns.Clear();

                    // Menampilkan hasil pencarian
                    dataGridView1.DataSource = searchResults;

                    if (dataGridView1.Columns["id_komponen"] != null) dataGridView1.Columns["id_komponen"].Visible = false;

                    if (dataGridView1.Columns["nama_komponen"] != null)
                        dataGridView1.Columns["nama_komponen"].HeaderText = "Nama Komponen";

                    if (dataGridView1.Columns["harga"] != null)
                        dataGridView1.Columns["harga"].HeaderText = "Harga";

                    if (dataGridView1.Columns["stok"] != null)
                        dataGridView1.Columns["stok"].HeaderText = "Stok";

                    // Tambahkan kolom nomor
                    DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn
                    {
                        HeaderText = "No",
                        Name = "nomor"
                    };
                    dataGridView1.Columns.Insert(0, nomorColumn);

                    // Isi kolom nomor urut
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells["nomor"].Value = (i + 1).ToString();
                    }

                    // Tambahkan tombol Update
                    DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
                    {
                        Name = "Update",
                        HeaderText = "Update",
                        Text = "Edit",
                        UseColumnTextForButtonValue = true
                    };
                    dataGridView1.Columns.Add(updateButtonColumn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saat melakukan pencarian: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Silakan masukkan kata kunci untuk pencarian.");
                LoadDataKomponen(); // Kembali ke data awal jika input kosong
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
