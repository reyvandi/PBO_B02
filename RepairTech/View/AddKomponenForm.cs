using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT_PBO.Controller;
using PROJECT_PBO.Model;

namespace PROJECT_PBO.View
{
    public partial class AddKomponenForm : Form
    {
        public bool IsEditMode { get; set; } = false;
        public int KomponenId { get; set; }
        public AddKomponenForm()
        {
            InitializeComponent();
            UpdateButtonText();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Inputan tidak valid");
                return;
            }

            M_Komponen komponen = new M_Komponen
            {
                nama_komponen = textBox1.Text,
                harga = decimal.Parse(textBox2.Text),
                stok = int.Parse(textBox3.Text),
            };
            if (IsEditMode)
            {
                komponen.id_komponen = KomponenId;
                KomponenContext.UpdateKomponen(komponen);
                MessageBox.Show("Komponen berhasil diupdate");
            }
            else
            {
                KomponenContext.AddKomponen(komponen);
                MessageBox.Show("Komponen baru berhasil ditambahkan");
            }

            ClearFields();

            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                !decimal.TryParse(textBox2.Text, out _) ||
                !int.TryParse(textBox3.Text, out _))
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

        public void PopulateForm(M_Komponen komponen)
        {

            textBox1.Text = komponen.nama_komponen;
            textBox2.Text = komponen.harga.ToString();
            textBox3.Text = komponen.stok.ToString();
            IsEditMode = true;
            KomponenId = komponen.id_komponen;
            UpdateButtonText();
        }

        private void UpdateButtonText()
        {
            buttonAdd.Text = IsEditMode ? "Update" : "Add";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}