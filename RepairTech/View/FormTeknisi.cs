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
    public partial class FormTeknisi : Form
    {
        public FormTeknisi()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
            this.Resize += FormTeknisi_Resize;
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

                DataTable teknisiData = TeknisiContext.All();
                if (teknisiData == null || teknisiData.Rows.Count == 0)
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


                dataGridView1.DataSource = teknisiData;


                if (dataGridView1.Columns["id_teknisi"] != null) dataGridView1.Columns["id_teknisi"].Visible = false;

                if (dataGridView1.Columns["nama"] != null)
                    dataGridView1.Columns["nama"].HeaderText = "Nama";

                if (dataGridView1.Columns["keahlian"] != null)
                    dataGridView1.Columns["keahlian"].HeaderText = "Keahlian";

                if (dataGridView1.Columns["jam_kerja"] != null)
                    dataGridView1.Columns["jam_kerja"].HeaderText = "Jam Kerja";

                if (dataGridView1.Columns["alamat"] != null)
                    dataGridView1.Columns["alamat"].HeaderText = "Alamat";

                if (dataGridView1.Columns["no_telepon"] != null)
                    dataGridView1.Columns["no_telepon"].HeaderText = "No Telepon";

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
                MessageBox.Show($"Error dalam LoadDataTeknisi: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void buttonTransaksi_Click(object sender, EventArgs e)
        {
            FormAdmin1 formTransaksi = new FormAdmin1();
            formTransaksi.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dataGridView1.Columns["Update"].Index)
            {
                try
                {
                    int teknisiId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_teknisi"].Value);

                    DataTable teknisiData = TeknisiContext.getTeknisiById(teknisiId);

                    if (teknisiData.Rows.Count > 0)
                    {
                        DataRow row = teknisiData.Rows[0];
                        M_Teknisi teknisi = new M_Teknisi
                        {
                            id_teknisi = (int)row["id_teknisi"],
                            nama = row["nama"].ToString(),
                            keahlian = row["keahlian"].ToString(),
                            jam_kerja = row["jam_kerja"].ToString(),
                            alamat = row["alamat"].ToString(),
                            no_telepon = row["no_telepon"].ToString()
                        };

                        this.Hide();
                        AddTeknisiForm addTeknisiForm = new AddTeknisiForm();
                        addTeknisiForm.PopulateForm(teknisi);
                        if (addTeknisiForm.ShowDialog() == DialogResult.OK)
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
            AddTeknisiForm addTeknisiForm = new AddTeknisiForm();

            if (addTeknisiForm.ShowDialog() == DialogResult.OK)
            {
                LoadDataKomponen();
            }

            this.Show();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            timerSidebar.Start();
        }

        bool sidebarExpand;
        private void timerSidebar_Tick(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormTeknisi_Resize(object sender, EventArgs e)
        {
            // Tentukan margin dari kanan dan bawah
            int marginRight = 0; // Misalnya 10px dari kanan
            int marginBottom = 0; // Misalnya 10px dari bawah

            // Atur lokasi tombol logout
            panel7.Location = new Point(
                this.ClientSize.Width - panel7.Width - marginRight,
                this.ClientSize.Height - panel7.Height - marginBottom
            );
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LOGIN formLogin = new LOGIN();
            formLogin.Show();
            this.Hide();
        }
    }
}
