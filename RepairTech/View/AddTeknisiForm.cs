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

            M_Teknisi teknisi = new M_Teknisi
            {
                nama = textBox1.Text,
                keahlian = comboBox1.Text,
                jam_kerja = comboBox2.Text,
                alamat = textBox2.Text,
                no_telepon = textBox3.Text,
            };
            if (IsEditMode)
            {
                teknisi.id_teknisi = TeknisiId;
                TeknisiContext.UpdateTeknisi(teknisi);
                MessageBox.Show("Teknisi berhasil diupdate");
            }
            else
            {
                TeknisiContext.AddTeknisi(teknisi);
                MessageBox.Show("Teknisi baru berhasil ditambahkan");
            }

            ClearFields();

            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(comboBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
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
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
        public void PopulateForm(M_Teknisi teknisi)
        {

            textBox1.Text = teknisi.nama;
            comboBox1.Text = teknisi.keahlian;
            comboBox2.Text = teknisi.jam_kerja;
            textBox2.Text = teknisi.alamat;
            textBox3.Text = teknisi.no_telepon;
            IsEditMode = true;
            TeknisiId = teknisi.id_teknisi;
            UpdateButtonText();
        }
        private void UpdateButtonText()
        {
            buttonAdd.Text = IsEditMode ? "Update" : "Add";
        }
    }
}
