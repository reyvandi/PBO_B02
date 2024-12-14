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
    public partial class AddJasaPerbaikanForm : Form
    {
        public bool IsEditMode { get; set; } = false;
        public int JasaPerbaikanId { get; set; }
        public AddJasaPerbaikanForm()
        {
            InitializeComponent();
            UpdateButtonText();
        }

        private void AddJasaPerbaikanForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Inputan tidak valid");
                return;
            }

            M_JasaPerbaikan jasaperbaikan;

            if (IsEditMode)
            {
                jasaperbaikan = new M_JasaPerbaikan(
                    JasaPerbaikanId,
                    textBoxJenisKerusakan.Text,
                    textBoxSolusi.Text,
                    decimal.Parse(textBoxBiaya.Text),
                    int.Parse(textBoxEstimasiWaktu.Text)
                    );

                JasaPerbaikanContext.UpdateJasaPerbaikan(jasaperbaikan);
                MessageBox.Show("Jasa perbaikan berhasil diupdate");
            }
            else
            {
                jasaperbaikan = new M_JasaPerbaikan(
                    textBoxJenisKerusakan.Text,
                    textBoxSolusi.Text,
                    decimal.Parse(textBoxBiaya.Text),
                    int.Parse(textBoxEstimasiWaktu.Text)
                    );

                JasaPerbaikanContext.AddJasaPerbaikan(jasaperbaikan);
                MessageBox.Show("Jasa perbaikan baru berhasil ditambahkan");
            }

            ClearFields();

            // Show FormJasaServis with updated data
            FormJasaPerbaikan formJasaServis = new FormJasaPerbaikan();
            formJasaServis.Show();
            this.Hide();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxJenisKerusakan.Text) ||
                string.IsNullOrWhiteSpace(textBoxSolusi.Text) ||
                !decimal.TryParse(textBoxBiaya.Text, out _) ||
                !int.TryParse(textBoxEstimasiWaktu.Text, out _))
            {
                return false;
            }
            return true;
        }
        private void ClearFields()
        {
            textBoxJenisKerusakan.Clear();
            textBoxSolusi.Clear();
            textBoxBiaya.Clear();
            textBoxEstimasiWaktu.Clear();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormJasaPerbaikan formJasaServis = new FormJasaPerbaikan();
            formJasaServis.Show();
            this.Hide();
        }
        public void PopulateForm(M_JasaPerbaikan jasaperbaikan)
        {
            textBoxJenisKerusakan.Text = jasaperbaikan.jenis_kerusakan;
            textBoxSolusi.Text = jasaperbaikan.solusi;
            textBoxBiaya.Text = jasaperbaikan.biaya.ToString();
            textBoxEstimasiWaktu.Text = jasaperbaikan.estimasi_waktu.ToString();
            IsEditMode = true;
            JasaPerbaikanId = jasaperbaikan.id_jasa_perbaikan;
            UpdateButtonText();
        }
        private void UpdateButtonText()
        {
            buttonAdd.Text = IsEditMode ? "Update" : "Add";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormJasaPerbaikan formJasPer = new FormJasaPerbaikan();
            formJasPer.Show();
            this.Hide();
        }
    }
}
