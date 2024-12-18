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
        private ErrorProvider errorProvider;

        public bool IsEditMode { get; set; } = false;
        public int KomponenId { get; set; }
        public AddKomponenForm()
        {
            InitializeComponent();
            UpdateButtonText();

            errorProvider = new ErrorProvider();

            textBoxHARGA.TextChanged += textBoxHARGA_TextChanged;
            textBoxSTOK.TextChanged += textBoxSTOK_TextChanged;
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

            M_Komponen komponen;

            if (IsEditMode)
            {
                komponen = new M_Komponen(
                    KomponenId,
                    textBoxNAMAKOMPONEN.Text,
                    decimal.Parse(textBoxHARGA.Text),
                    int.Parse(textBoxSTOK.Text)
                );

                KomponenContext.UpdateKomponen(komponen);
                MessageBox.Show("Komponen berhasil diupdate");
            }
            else
            {
                komponen = new M_Komponen(
                    textBoxNAMAKOMPONEN.Text,
                    decimal.Parse(textBoxHARGA.Text),
                    int.Parse(textBoxSTOK.Text)
                );

                KomponenContext.AddKomponen(komponen);
                MessageBox.Show("Komponen baru berhasil ditambahkan");
            }

            ClearFields();

            FormKomponen formKomponen = new FormKomponen();
            formKomponen.Show();
            this.Hide();
        }

        private bool ValidateInput()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(textBoxNAMAKOMPONEN.Text))
            {
                isValid = false;
            }

            if (!decimal.TryParse(textBoxHARGA.Text, out _))
            {
                errorProvider.SetError(textBoxHARGA, "Harga harus berupa angka.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(textBoxHARGA, string.Empty);
            }

            if (!int.TryParse(textBoxSTOK.Text, out _))
            {
                errorProvider.SetError(textBoxSTOK, "Stok harus berupa angka.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(textBoxSTOK, string.Empty);
            }

            return isValid;
        }

        private void ClearFields()
        {
            textBoxNAMAKOMPONEN.Clear();
            textBoxHARGA.Clear();
            textBoxSTOK.Clear();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormKomponen formKomponen = new FormKomponen();
            formKomponen.Show();
            this.Hide();    
        }

        public void PopulateForm(M_Komponen komponen)
        {
            textBoxNAMAKOMPONEN.Text = komponen.nama_komponen;
            textBoxHARGA.Text = komponen.harga.ToString();
            textBoxSTOK.Text = komponen.stok.ToString();
            IsEditMode = true;
            KomponenId = komponen.id_komponen;
            UpdateButtonText();
        }

        private void UpdateButtonText()
        {
            buttonAdd.Text = IsEditMode ? "Update" : "Submit";
        }

        private void textBoxHARGA_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textBoxHARGA.Text, out _))
            {
                errorProvider.SetError(textBoxHARGA, "Harga harus berupa angka.");
            }
            else
            {
                errorProvider.SetError(textBoxHARGA, string.Empty);
            }
        }

        private void textBoxSTOK_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxSTOK.Text, out _))
            {
                errorProvider.SetError(textBoxSTOK, "Stok harus berupa angka.");
            }
            else
            {
                errorProvider.SetError(textBoxSTOK, string.Empty);
            }
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