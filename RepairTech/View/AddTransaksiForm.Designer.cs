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
            // textBoxPelanggan
            // 
            textBoxPelanggan.BackColor = Color.White;
            textBoxPelanggan.BorderStyle = BorderStyle.None;
            textBoxPelanggan.Location = new Point(677, 103);
            textBoxPelanggan.Name = "textBoxPelanggan";
            textBoxPelanggan.Size = new Size(247, 16);
            textBoxPelanggan.TabIndex = 1;
            // 
            // labelMerkLaptop
            // 
            labelMerkLaptop.AutoSize = true;
            labelMerkLaptop.BackColor = Color.White;
            labelMerkLaptop.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMerkLaptop.Location = new Point(677, 137);
            labelMerkLaptop.Name = "labelMerkLaptop";
            labelMerkLaptop.Size = new Size(86, 17);
            labelMerkLaptop.TabIndex = 21;
            labelMerkLaptop.Text = "Merk Laptop";
            // 
            // labelNamaPelanggan
            // 
            labelNamaPelanggan.AutoSize = true;
            labelNamaPelanggan.BackColor = Color.White;
            labelNamaPelanggan.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNamaPelanggan.Location = new Point(677, 78);
            labelNamaPelanggan.Name = "labelNamaPelanggan";
            labelNamaPelanggan.Size = new Size(113, 17);
            labelNamaPelanggan.TabIndex = 22;
            labelNamaPelanggan.Text = "Nama Pelanggan";
            // 
            // textBoxMerkLaptop
            // 
            textBoxMerkLaptop.BackColor = Color.White;
            textBoxMerkLaptop.BorderStyle = BorderStyle.None;
            textBoxMerkLaptop.Location = new Point(677, 160);
            textBoxMerkLaptop.Name = "textBoxMerkLaptop";
            textBoxMerkLaptop.Size = new Size(247, 16);
            textBoxMerkLaptop.TabIndex = 23;
            // 
            // comboBoxKerusakan
            // 
            comboBoxKerusakan.FormattingEnabled = true;
            comboBoxKerusakan.Location = new Point(670, 221);
            comboBoxKerusakan.Name = "comboBoxKerusakan";
            comboBoxKerusakan.Size = new Size(262, 23);
            comboBoxKerusakan.TabIndex = 24;
            // 
            // labelKerusakan
            // 
            labelKerusakan.AutoSize = true;
            labelKerusakan.BackColor = Color.White;
            labelKerusakan.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelKerusakan.Location = new Point(677, 201);
            labelKerusakan.Name = "labelKerusakan";
            labelKerusakan.Size = new Size(71, 17);
            labelKerusakan.TabIndex = 25;
            labelKerusakan.Text = "Kerusakan";
            // 
            // listBoxKerusakan
            // 
            listBoxKerusakan.BorderStyle = BorderStyle.None;
            listBoxKerusakan.FormattingEnabled = true;
            listBoxKerusakan.ItemHeight = 15;
            listBoxKerusakan.Location = new Point(678, 259);
            listBoxKerusakan.Name = "listBoxKerusakan";
            listBoxKerusakan.Size = new Size(243, 75);
            listBoxKerusakan.TabIndex = 26;
            // 
            // btnTambahKerusakan
            // 
            btnTambahKerusakan.AutoSize = true;
            btnTambahKerusakan.BackColor = Color.FromArgb(255, 192, 255);
            btnTambahKerusakan.FlatAppearance.BorderSize = 0;
            btnTambahKerusakan.FlatStyle = FlatStyle.Flat;
            btnTambahKerusakan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTambahKerusakan.Location = new Point(949, 221);
            btnTambahKerusakan.Name = "btnTambahKerusakan";
            btnTambahKerusakan.Size = new Size(62, 27);
            btnTambahKerusakan.TabIndex = 27;
            btnTambahKerusakan.Text = "Tambah";
            btnTambahKerusakan.UseVisualStyleBackColor = false;
            btnTambahKerusakan.Click += btnTambahKerusakan_Click;
            // 
            // btnHapusKerusakan
            // 
            btnHapusKerusakan.AutoSize = true;
            btnHapusKerusakan.BackColor = Color.FromArgb(255, 192, 255);
            btnHapusKerusakan.FlatAppearance.BorderSize = 0;
            btnHapusKerusakan.FlatStyle = FlatStyle.Flat;
            btnHapusKerusakan.Location = new Point(949, 282);
            btnHapusKerusakan.Name = "btnHapusKerusakan";
            btnHapusKerusakan.Size = new Size(62, 27);
            btnHapusKerusakan.TabIndex = 28;
            btnHapusKerusakan.Text = "Hapus";
            btnHapusKerusakan.UseVisualStyleBackColor = false;
            btnHapusKerusakan.Click += btnHapusKerusakan_Click;
            // 
            // comboBoxKomponen
            // 
            comboBoxKomponen.FormattingEnabled = true;
            comboBoxKomponen.Location = new Point(669, 375);
            comboBoxKomponen.Name = "comboBoxKomponen";
            comboBoxKomponen.Size = new Size(263, 23);
            comboBoxKomponen.TabIndex = 29;
            // 
            // labelKomponen
            // 
            labelKomponen.AutoSize = true;
            labelKomponen.BackColor = Color.White;
            labelKomponen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelKomponen.Location = new Point(677, 355);
            labelKomponen.Name = "labelKomponen";
            labelKomponen.Size = new Size(75, 17);
            labelKomponen.TabIndex = 30;
            labelKomponen.Text = "Komponen";
            // 
            // listBoxKomponen
            // 
            listBoxKomponen.BorderStyle = BorderStyle.None;
            listBoxKomponen.FormattingEnabled = true;
            listBoxKomponen.ItemHeight = 15;
            listBoxKomponen.Location = new Point(678, 414);
            listBoxKomponen.Name = "listBoxKomponen";
            listBoxKomponen.Size = new Size(243, 75);
            listBoxKomponen.TabIndex = 31;
            // 
            // btnTambahKomponen
            // 
            btnTambahKomponen.AutoSize = true;
            btnTambahKomponen.BackColor = Color.FromArgb(255, 192, 255);
            btnTambahKomponen.FlatAppearance.BorderSize = 0;
            btnTambahKomponen.FlatStyle = FlatStyle.Flat;
            btnTambahKomponen.Location = new Point(949, 375);
            btnTambahKomponen.Name = "btnTambahKomponen";
            btnTambahKomponen.Size = new Size(62, 27);
            btnTambahKomponen.TabIndex = 32;
            btnTambahKomponen.Text = "Tambah";
            btnTambahKomponen.UseVisualStyleBackColor = false;
            btnTambahKomponen.Click += btnTambahKomponen_Click;
            // 
            // btnHapusKomponen
            // 
            btnHapusKomponen.AutoSize = true;
            btnHapusKomponen.BackColor = Color.FromArgb(255, 192, 255);
            btnHapusKomponen.FlatAppearance.BorderSize = 0;
            btnHapusKomponen.FlatStyle = FlatStyle.Flat;
            btnHapusKomponen.Location = new Point(949, 436);
            btnHapusKomponen.Name = "btnHapusKomponen";
            btnHapusKomponen.Size = new Size(62, 27);
            btnHapusKomponen.TabIndex = 33;
            btnHapusKomponen.Text = "Hapus";
            btnHapusKomponen.UseVisualStyleBackColor = false;
            btnHapusKomponen.Click += btnHapusKomponen_Click;
            // 
            // comboBoxTeknisi
            // 
            comboBoxTeknisi.FormattingEnabled = true;
            comboBoxTeknisi.Location = new Point(669, 527);
            comboBoxTeknisi.Name = "comboBoxTeknisi";
            comboBoxTeknisi.Size = new Size(263, 23);
            comboBoxTeknisi.TabIndex = 34;
            // 
            // labelTeknisi
            // 
            labelTeknisi.AutoSize = true;
            labelTeknisi.BackColor = Color.White;
            labelTeknisi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTeknisi.Location = new Point(677, 507);
            labelTeknisi.Name = "labelTeknisi";
            labelTeknisi.Size = new Size(51, 17);
            labelTeknisi.TabIndex = 35;
            labelTeknisi.Text = "Teknisi";
            // 
            // buttonTambahTransaksi
            // 
            buttonTambahTransaksi.BackColor = Color.FromArgb(192, 0, 192);
            buttonTambahTransaksi.FlatAppearance.BorderSize = 0;
            buttonTambahTransaksi.FlatStyle = FlatStyle.Flat;
            buttonTambahTransaksi.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTambahTransaksi.ForeColor = SystemColors.Control;
            buttonTambahTransaksi.IconChar = FontAwesome.Sharp.IconChar.Add;
            buttonTambahTransaksi.IconColor = Color.White;
            buttonTambahTransaksi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonTambahTransaksi.IconSize = 17;
            buttonTambahTransaksi.ImageAlign = ContentAlignment.MiddleRight;
            buttonTambahTransaksi.Location = new Point(712, 574);
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
            numericUpDownJumlah.Location = new Point(533, 376);
            numericUpDownJumlah.Name = "numericUpDownJumlah";
            numericUpDownJumlah.Size = new Size(120, 23);
            numericUpDownJumlah.TabIndex = 37;
            // 
            // AddTransaksiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Frame_13b1;
            BackgroundImageLayout = ImageLayout.Stretch;
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
            DoubleBuffered = true;
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