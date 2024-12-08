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
    public partial class AddTeknisiForm : Form
    {
        public bool IsEditMode { get; set; } = false;
        public int TeknisiId { get; set; }
        public AddTeknisiForm()
        {
            InitializeComponent();
            UpdateButtonText();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Inputan tidak valid");
                return;
            }

            M_Teknisi teknisi;

            if (IsEditMode)
            {
                teknisi = new M_Teknisi(
                    TeknisiId,
                    textBoxNama.Text,
                    comboBoxKeahlian.Text,
                    comboBoxJamKerja.Text,
                    textBoxAlamat.Text,
                    textBoxNoTelepon.Text
                    );

                TeknisiContext.UpdateTeknisi(teknisi);
                MessageBox.Show("Teknisi berhasil diupdate");
            }
            else
            {
                teknisi = new M_Teknisi(
                    textBoxNama.Text,
                    comboBoxKeahlian.Text,
                    comboBoxJamKerja.Text,
                    textBoxAlamat.Text,
                    textBoxNoTelepon.Text
                    );

                TeknisiContext.AddTeknisi(teknisi);
                MessageBox.Show("Teknisi baru berhasil ditambahkan");
            }

            ClearFields();

            FormTeknisi formTeknisi = new FormTeknisi();
            formTeknisi.Show();
            this.Hide();
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxNama.Text) ||
                string.IsNullOrWhiteSpace(comboBoxKeahlian.Text) ||
                string.IsNullOrWhiteSpace(comboBoxJamKerja.Text) ||
                string.IsNullOrWhiteSpace(textBoxAlamat.Text) ||
                string.IsNullOrWhiteSpace(textBoxNoTelepon.Text))
            {
                return false;
            }
            return true;
        }
        private void ClearFields()
        {
            textBoxNama.Clear();
            textBoxAlamat.Clear();
            textBoxNoTelepon.Clear();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormTeknisi formTeknisi = new FormTeknisi();
            formTeknisi.Show();
            this.Hide();
        }
        public void PopulateForm(M_Teknisi teknisi)
        {

            textBoxNama.Text = teknisi.nama;
            comboBoxKeahlian.Text = teknisi.keahlian;
            comboBoxJamKerja.Text = teknisi.jam_kerja;
            textBoxAlamat.Text = teknisi.alamat;
            textBoxNoTelepon.Text = teknisi.no_telepon;
            IsEditMode = true;
            TeknisiId = teknisi.id_teknisi;
            UpdateButtonText();
        }
        private void UpdateButtonText()
        {
            buttonAdd.Text = IsEditMode ? "Update" : "Add";
        }

        private void AddTeknisiForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTeknisi formTeknisi = new FormTeknisi();
            formTeknisi.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
