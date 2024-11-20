using PROJECT_PBO.Controller;
using PROJECT_PBO.Model;
using PROJECT_PBO.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PBO
{
    public partial class FormJasaServis : Form
    {
        public FormJasaServis()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDataJasaPerbaikan();
        }
        private void LoadDataJasaPerbaikan()
        {
            try
            {
                dataGridView1.AllowUserToAddRows = false;

                DataTable jasaperbaikanData = JasaPerbaikanContext.All();
                if (jasaperbaikanData == null || jasaperbaikanData.Rows.Count == 0)
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


                dataGridView1.DataSource = jasaperbaikanData;


                if (dataGridView1.Columns["id_jasa_perbaikan"] != null) dataGridView1.Columns["id_jasa_perbaikan"].Visible = false;

                if (dataGridView1.Columns["jenis_kerusakan"] != null)
                    dataGridView1.Columns["jenis_kerusakan"].HeaderText = "Jenis Kerusakan";

                if (dataGridView1.Columns["solusi"] != null)
                    dataGridView1.Columns["solusi"].HeaderText = "Solusi";

                if (dataGridView1.Columns["biaya"] != null)
                    dataGridView1.Columns["biaya"].HeaderText = "Biaya";

                if (dataGridView1.Columns["estimasi_waktu"] != null)
                    dataGridView1.Columns["estimasi_waktu"].HeaderText = "Estimasi Waktu";

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
                MessageBox.Show($"Error dalam LoadDataJasaPerbaikan: {ex.Message}\n{ex.StackTrace}");
            }
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

        private void buttonTeknisi_Click(object sender, EventArgs e)
        {
            FormTeknisi formTeknisi = new FormTeknisi();
            formTeknisi.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dataGridView1.Columns["Update"].Index)
            {
                try
                {
                    int jasaperbaikanId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_jasa_perbaikan"].Value);

                    DataTable jasaperbaikanData = JasaPerbaikanContext.getJasaPerbaikanById(jasaperbaikanId);

                    if (jasaperbaikanData.Rows.Count > 0)
                    {
                        DataRow row = jasaperbaikanData.Rows[0];
                        M_JasaPerbaikan jasaperbaikan = new M_JasaPerbaikan
                        {
                            id_jasa_perbaikan = (int)row["id_jasa_perbaikan"],
                            jenis_kerusakan = row["jenis_kerusakan"].ToString(),
                            solusi = row["solusi"].ToString(),
                            biaya = (decimal)row["biaya"],
                            estimasi_waktu = (int)row["estimasi_waktu"]
                        };

                        this.Hide();
                        AddJasaPerbaikanForm addJasaPerbaikanForm = new AddJasaPerbaikanForm();
                        addJasaPerbaikanForm.PopulateForm(jasaperbaikan);
                        if (addJasaPerbaikanForm.ShowDialog() == DialogResult.OK)
                        {
                            LoadDataJasaPerbaikan();
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
            AddJasaPerbaikanForm addJasaPerbaikanForm = new AddJasaPerbaikanForm();

            if (addJasaPerbaikanForm.ShowDialog() == DialogResult.OK)
            {
                LoadDataJasaPerbaikan();
            }

            this.Show();
        }
    }
}
