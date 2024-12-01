namespace PROJECT_PBO.View
{
    partial class AddTransaksiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxPelanggan = new TextBox();
            labelMerkLaptop = new Label();
            labelNamaPelanggan = new Label();
            textBoxMerkLaptop = new TextBox();
            comboBoxKerusakan = new ComboBox();
            labelKerusakan = new Label();
            listBoxKerusakan = new ListBox();
            btnTambahKerusakan = new Button();
            btnHapusKerusakan = new Button();
            comboBoxKomponen = new ComboBox();
            labelKomponen = new Label();
            listBoxKomponen = new ListBox();
            btnTambahKomponen = new Button();
            btnHapusKomponen = new Button();
            comboBoxTeknisi = new ComboBox();
            labelTeknisi = new Label();
            buttonTambahTransaksi = new FontAwesome.Sharp.IconButton();
            numericUpDownJumlah = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownJumlah).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(416, 8);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Tambah Transaksi";
            // 
            // textBoxPelanggan
            // 
            textBoxPelanggan.Location = new Point(378, 73);
            textBoxPelanggan.Name = "textBoxPelanggan";
            textBoxPelanggan.Size = new Size(185, 23);
            textBoxPelanggan.TabIndex = 1;
            // 
            // labelMerkLaptop
            // 
            labelMerkLaptop.AutoSize = true;
            labelMerkLaptop.Location = new Point(378, 111);
            labelMerkLaptop.Name = "labelMerkLaptop";
            labelMerkLaptop.Size = new Size(74, 15);
            labelMerkLaptop.TabIndex = 21;
            labelMerkLaptop.Text = "Merk Laptop";
            // 
            // labelNamaPelanggan
            // 
            labelNamaPelanggan.AutoSize = true;
            labelNamaPelanggan.Location = new Point(378, 55);
            labelNamaPelanggan.Name = "labelNamaPelanggan";
            labelNamaPelanggan.Size = new Size(98, 15);
            labelNamaPelanggan.TabIndex = 22;
            labelNamaPelanggan.Text = "Nama Pelanggan";
            // 
            // textBoxMerkLaptop
            // 
            textBoxMerkLaptop.Location = new Point(378, 129);
            textBoxMerkLaptop.Name = "textBoxMerkLaptop";
            textBoxMerkLaptop.Size = new Size(185, 23);
            textBoxMerkLaptop.TabIndex = 23;
            // 
            // comboBoxKerusakan
            // 
            comboBoxKerusakan.FormattingEnabled = true;
            comboBoxKerusakan.Location = new Point(378, 186);
            comboBoxKerusakan.Name = "comboBoxKerusakan";
            comboBoxKerusakan.Size = new Size(185, 23);
            comboBoxKerusakan.TabIndex = 24;
            // 
            // labelKerusakan
            // 
            labelKerusakan.AutoSize = true;
            labelKerusakan.Location = new Point(378, 168);
            labelKerusakan.Name = "labelKerusakan";
            labelKerusakan.Size = new Size(61, 15);
            labelKerusakan.TabIndex = 25;
            labelKerusakan.Text = "Kerusakan";
            // 
            // listBoxKerusakan
            // 
            listBoxKerusakan.FormattingEnabled = true;
            listBoxKerusakan.ItemHeight = 15;
            listBoxKerusakan.Location = new Point(378, 215);
            listBoxKerusakan.Name = "listBoxKerusakan";
            listBoxKerusakan.Size = new Size(185, 49);
            listBoxKerusakan.TabIndex = 26;
            // 
            // btnTambahKerusakan
            // 
            btnTambahKerusakan.AutoSize = true;
            btnTambahKerusakan.Location = new Point(584, 180);
            btnTambahKerusakan.Name = "btnTambahKerusakan";
            btnTambahKerusakan.Size = new Size(169, 39);
            btnTambahKerusakan.TabIndex = 27;
            btnTambahKerusakan.Text = "Tambah Kerusakan";
            btnTambahKerusakan.UseVisualStyleBackColor = true;
            btnTambahKerusakan.Click += btnTambahKerusakan_Click;
            // 
            // btnHapusKerusakan
            // 
            btnHapusKerusakan.AutoSize = true;
            btnHapusKerusakan.Location = new Point(584, 225);
            btnHapusKerusakan.Name = "btnHapusKerusakan";
            btnHapusKerusakan.Size = new Size(169, 39);
            btnHapusKerusakan.TabIndex = 28;
            btnHapusKerusakan.Text = "Hapus Kerusakan";
            btnHapusKerusakan.UseVisualStyleBackColor = true;
            btnHapusKerusakan.Click += btnHapusKerusakan_Click;
            // 
            // comboBoxKomponen
            // 
            comboBoxKomponen.FormattingEnabled = true;
            comboBoxKomponen.Location = new Point(378, 301);
            comboBoxKomponen.Name = "comboBoxKomponen";
            comboBoxKomponen.Size = new Size(185, 23);
            comboBoxKomponen.TabIndex = 29;
            // 
            // labelKomponen
            // 
            labelKomponen.AutoSize = true;
            labelKomponen.Location = new Point(378, 283);
            labelKomponen.Name = "labelKomponen";
            labelKomponen.Size = new Size(66, 15);
            labelKomponen.TabIndex = 30;
            labelKomponen.Text = "Komponen";
            // 
            // listBoxKomponen
            // 
            listBoxKomponen.FormattingEnabled = true;
            listBoxKomponen.ItemHeight = 15;
            listBoxKomponen.Location = new Point(378, 330);
            listBoxKomponen.Name = "listBoxKomponen";
            listBoxKomponen.Size = new Size(185, 49);
            listBoxKomponen.TabIndex = 31;
            // 
            // btnTambahKomponen
            // 
            btnTambahKomponen.AutoSize = true;
            btnTambahKomponen.Location = new Point(584, 292);
            btnTambahKomponen.Name = "btnTambahKomponen";
            btnTambahKomponen.Size = new Size(169, 39);
            btnTambahKomponen.TabIndex = 32;
            btnTambahKomponen.Text = "Tambah Komponen";
            btnTambahKomponen.UseVisualStyleBackColor = true;
            btnTambahKomponen.Click += btnTambahKomponen_Click;
            // 
            // btnHapusKomponen
            // 
            btnHapusKomponen.AutoSize = true;
            btnHapusKomponen.Location = new Point(584, 340);
            btnHapusKomponen.Name = "btnHapusKomponen";
            btnHapusKomponen.Size = new Size(169, 39);
            btnHapusKomponen.TabIndex = 33;
            btnHapusKomponen.Text = "Hapus Komponen";
            btnHapusKomponen.UseVisualStyleBackColor = true;
            btnHapusKomponen.Click += btnHapusKomponen_Click;
            // 
            // comboBoxTeknisi
            // 
            comboBoxTeknisi.FormattingEnabled = true;
            comboBoxTeknisi.Location = new Point(378, 422);
            comboBoxTeknisi.Name = "comboBoxTeknisi";
            comboBoxTeknisi.Size = new Size(185, 23);
            comboBoxTeknisi.TabIndex = 34;
            // 
            // labelTeknisi
            // 
            labelTeknisi.AutoSize = true;
            labelTeknisi.Location = new Point(378, 404);
            labelTeknisi.Name = "labelTeknisi";
            labelTeknisi.Size = new Size(42, 15);
            labelTeknisi.TabIndex = 35;
            labelTeknisi.Text = "Teknisi";
            // 
            // buttonTambahTransaksi
            // 
            buttonTambahTransaksi.BackColor = Color.Blue;
            buttonTambahTransaksi.FlatAppearance.BorderSize = 0;
            buttonTambahTransaksi.FlatStyle = FlatStyle.Flat;
            buttonTambahTransaksi.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTambahTransaksi.ForeColor = SystemColors.Control;
            buttonTambahTransaksi.IconChar = FontAwesome.Sharp.IconChar.Add;
            buttonTambahTransaksi.IconColor = Color.White;
            buttonTambahTransaksi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonTambahTransaksi.IconSize = 17;
            buttonTambahTransaksi.ImageAlign = ContentAlignment.MiddleRight;
            buttonTambahTransaksi.Location = new Point(792, 539);
            buttonTambahTransaksi.Name = "buttonTambahTransaksi";
            buttonTambahTransaksi.Size = new Size(200, 35);
            buttonTambahTransaksi.TabIndex = 36;
            buttonTambahTransaksi.Text = "Tambah Transaksi";
            buttonTambahTransaksi.TextAlign = ContentAlignment.MiddleLeft;
            buttonTambahTransaksi.UseVisualStyleBackColor = false;
            buttonTambahTransaksi.Click += buttonTambahTransaksi_Click;
            // 
            // numericUpDownJumlah
            // 
            numericUpDownJumlah.Location = new Point(233, 340);
            numericUpDownJumlah.Name = "numericUpDownJumlah";
            numericUpDownJumlah.Size = new Size(120, 23);
            numericUpDownJumlah.TabIndex = 37;
            // 
            // AddTransaksiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 621);
            Controls.Add(numericUpDownJumlah);
            Controls.Add(buttonTambahTransaksi);
            Controls.Add(labelTeknisi);
            Controls.Add(comboBoxTeknisi);
            Controls.Add(btnHapusKomponen);
            Controls.Add(btnTambahKomponen);
            Controls.Add(listBoxKomponen);
            Controls.Add(labelKomponen);
            Controls.Add(comboBoxKomponen);
            Controls.Add(btnHapusKerusakan);
            Controls.Add(btnTambahKerusakan);
            Controls.Add(listBoxKerusakan);
            Controls.Add(labelKerusakan);
            Controls.Add(comboBoxKerusakan);
            Controls.Add(textBoxMerkLaptop);
            Controls.Add(labelNamaPelanggan);
            Controls.Add(labelMerkLaptop);
            Controls.Add(textBoxPelanggan);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddTransaksiForm";
            Text = "AddTransaksiForm";
            WindowState = FormWindowState.Maximized;
            Load += AddTransaksiForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownJumlah).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxPelanggan;
        private Label labelMerkLaptop;
        private Label labelNamaPelanggan;
        private TextBox textBoxMerkLaptop;
        private ComboBox comboBoxKerusakan;
        private Label labelKerusakan;
        private ListBox listBoxKerusakan;
        private Button btnTambahKerusakan;
        private Button btnHapusKerusakan;
        private ComboBox comboBoxKomponen;
        private Label labelKomponen;
        private ListBox listBoxKomponen;
        private Button btnTambahKomponen;
        private Button btnHapusKomponen;
        private ComboBox comboBoxTeknisi;
        private Label labelTeknisi;
        private FontAwesome.Sharp.IconButton buttonTambahTransaksi;
        private NumericUpDown numericUpDownJumlah;
    }
}