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

            M_JasaPerbaikan jasaperbaikan = new M_JasaPerbaikan
            {
                jenis_kerusakan = textBox1.Text,
                solusi = textBox2.Text,
                biaya = decimal.Parse(textBox3.Text),
                estimasi_waktu = int.Parse(textBox4.Text),
            };
            if (IsEditMode)
            {
                jasaperbaikan.id_jasa_perbaikan = JasaPerbaikanId;
                JasaPerbaikanContext.UpdateJasaPerbaikan(jasaperbaikan);
                MessageBox.Show("Jasa perbaikan berhasil diupdate");
            }
            else
            {
                JasaPerbaikanContext.AddJasaPerbaikan(jasaperbaikan);
                MessageBox.Show("Jasa perbaikan baru berhasil ditambahkan");
            }

            ClearFields();

            // Show FormJasaServis with updated data
            FormJasaServis formJasaServis = new FormJasaServis();
            formJasaServis.Show();
            this.Hide();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                !decimal.TryParse(textBox3.Text, out _) ||
                !int.TryParse(textBox4.Text, out _))
            {
                return false;
            }
            return true;
        }
        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormJasaServis formJasaServis = new FormJasaServis();
            formJasaServis.Show();
            this.Hide();
        }
        public void PopulateForm(M_JasaPerbaikan jasaperbaikan)
        {
            textBox1.Text = jasaperbaikan.jenis_kerusakan;
            textBox2.Text = jasaperbaikan.solusi;
            textBox3.Text = jasaperbaikan.biaya.ToString();
            textBox4.Text = jasaperbaikan.estimasi_waktu.ToString();
            IsEditMode = true;
            JasaPerbaikanId = jasaperbaikan.id_jasa_perbaikan;
            UpdateButtonText();
        }
        private void UpdateButtonText()
        {
            buttonAdd.Text = IsEditMode ? "Update" : "Add";
        }
    }
}
