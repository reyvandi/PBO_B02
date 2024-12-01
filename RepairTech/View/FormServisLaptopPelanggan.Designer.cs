namespace PROJECT_PBO.View
{
    partial class FormServisLaptopPelanggan
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
            components = new System.ComponentModel.Container();
            sidebar = new FlowLayoutPanel();
            panelSidebar = new Panel();
            label2 = new Label();
            buttonMenu = new PictureBox();
            panel8 = new Panel();
            buttonTransaksi = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panel1 = new Panel();
            buttonKomponen = new FontAwesome.Sharp.IconButton();
            panel9 = new Panel();
            pictureBox1 = new PictureBox();
            labelUsername = new Label();
            label1 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            textBoxNamaLaptop = new TextBox();
            label5 = new Label();
            comboBoxKerusakan = new ComboBox();
            label6 = new Label();
            comboBoxTeknisi = new ComboBox();
            textBoxAlamat = new TextBox();
            label7 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            buttonTambahTransaksi = new FontAwesome.Sharp.IconButton();
            listBoxKerusakan = new ListBox();
            panel4 = new Panel();
            panel5 = new Panel();
            btnHapusKerusakan = new Button();
            btnTambahKerusakan = new Button();
            panel6 = new Panel();
            panel7 = new Panel();
            panel10 = new Panel();
            sidebar.SuspendLayout();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonMenu).BeginInit();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(31, 30, 68);
            sidebar.Controls.Add(panelSidebar);
            sidebar.Controls.Add(panel8);
            sidebar.Controls.Add(panel2);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(169, 799);
            sidebar.MinimumSize = new Size(50, 49);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(169, 624);
            sidebar.TabIndex = 1;
            sidebar.WrapContents = false;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(31, 30, 68);
            panelSidebar.Controls.Add(label2);
            panelSidebar.Controls.Add(buttonMenu);
            panelSidebar.Dock = DockStyle.Top;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(169, 49);
            panelSidebar.TabIndex = 0;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(50, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(119, 49);
            label2.TabIndex = 2;
            label2.Text = "Menu";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonMenu
            // 
            buttonMenu.Cursor = Cursors.Hand;
            buttonMenu.Dock = DockStyle.Left;
            buttonMenu.Image = Properties.Resources.menu;
            buttonMenu.Location = new Point(0, 0);
            buttonMenu.Margin = new Padding(0);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Padding = new Padding(10, 11, 10, 11);
            buttonMenu.Size = new Size(50, 49);
            buttonMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            buttonMenu.TabIndex = 1;
            buttonMenu.TabStop = false;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(buttonTransaksi);
            panel8.Location = new Point(0, 49);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(169, 49);
            panel8.TabIndex = 5;
            // 
            // buttonTransaksi
            // 
            buttonTransaksi.BackColor = Color.FromArgb(31, 30, 68);
            buttonTransaksi.Dock = DockStyle.Fill;
            buttonTransaksi.FlatAppearance.BorderSize = 0;
            buttonTransaksi.FlatStyle = FlatStyle.Flat;
            buttonTransaksi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTransaksi.ForeColor = SystemColors.Control;
            buttonTransaksi.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            buttonTransaksi.IconColor = SystemColors.Control;
            buttonTransaksi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonTransaksi.IconSize = 32;
            buttonTransaksi.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTransaksi.Location = new Point(0, 0);
            buttonTransaksi.Name = "buttonTransaksi";
            buttonTransaksi.Size = new Size(169, 49);
            buttonTransaksi.TabIndex = 3;
            buttonTransaksi.Text = "Transaksi";
            buttonTransaksi.TextAlign = ContentAlignment.MiddleRight;
            buttonTransaksi.UseVisualStyleBackColor = false;
            buttonTransaksi.Click += buttonTransaksi_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 30, 68);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(buttonKomponen);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 98);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(169, 50);
            panel2.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 255);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(6, 50);
            panel1.TabIndex = 3;
            // 
            // buttonKomponen
            // 
            buttonKomponen.BackColor = Color.FromArgb(31, 30, 68);
            buttonKomponen.Dock = DockStyle.Right;
            buttonKomponen.FlatAppearance.BorderSize = 0;
            buttonKomponen.FlatStyle = FlatStyle.Flat;
            buttonKomponen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKomponen.ForeColor = SystemColors.Control;
            buttonKomponen.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            buttonKomponen.IconColor = Color.FromArgb(255, 128, 255);
            buttonKomponen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonKomponen.IconSize = 36;
            buttonKomponen.ImageAlign = ContentAlignment.MiddleLeft;
            buttonKomponen.Location = new Point(-6, 0);
            buttonKomponen.Name = "buttonKomponen";
            buttonKomponen.Padding = new Padding(5);
            buttonKomponen.Size = new Size(175, 50);
            buttonKomponen.TabIndex = 1;
            buttonKomponen.Text = "Servis Laptop";
            buttonKomponen.TextAlign = ContentAlignment.MiddleRight;
            buttonKomponen.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(24, 23, 80);
            panel9.Controls.Add(pictureBox1);
            panel9.Controls.Add(labelUsername);
            panel9.Controls.Add(label1);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(169, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1048, 70);
            panel9.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.rpimg;
            pictureBox1.Location = new Point(828, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Dock = DockStyle.Left;
            labelUsername.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = SystemColors.Control;
            labelUsername.Location = new Point(83, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Padding = new Padding(0, 20, 0, 0);
            labelUsername.Size = new Size(55, 50);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "       ";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(20, 20, 0, 0);
            label1.Size = new Size(83, 70);
            label1.TabIndex = 1;
            label1.Text = "Halo";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(429, 35);
            label3.Name = "label3";
            label3.Size = new Size(189, 30);
            label3.TabIndex = 17;
            label3.Text = "Form Servis Laptop";
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(169, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(1048, 100);
            panel3.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1048, 100);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(429, 1);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 20;
            label4.Text = "Merk Laptop";
            // 
            // textBoxNamaLaptop
            // 
            textBoxNamaLaptop.Location = new Point(429, 19);
            textBoxNamaLaptop.Name = "textBoxNamaLaptop";
            textBoxNamaLaptop.Size = new Size(185, 23);
            textBoxNamaLaptop.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(429, 9);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 21;
            label5.Text = "Kerusakan";
            // 
            // comboBoxKerusakan
            // 
            comboBoxKerusakan.FormattingEnabled = true;
            comboBoxKerusakan.Location = new Point(429, 27);
            comboBoxKerusakan.Name = "comboBoxKerusakan";
            comboBoxKerusakan.Size = new Size(185, 23);
            comboBoxKerusakan.TabIndex = 0;
            comboBoxKerusakan.SelectedIndexChanged += comboBoxKerusakan_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(429, 6);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 22;
            label6.Text = "Teknisi";
            // 
            // comboBoxTeknisi
            // 
            comboBoxTeknisi.FormattingEnabled = true;
            comboBoxTeknisi.Location = new Point(429, 24);
            comboBoxTeknisi.Name = "comboBoxTeknisi";
            comboBoxTeknisi.Size = new Size(185, 23);
            comboBoxTeknisi.TabIndex = 0;
            // 
            // textBoxAlamat
            // 
            textBoxAlamat.Location = new Point(429, 24);
            textBoxAlamat.Name = "textBoxAlamat";
            textBoxAlamat.Size = new Size(185, 23);
            textBoxAlamat.TabIndex = 22;
            textBoxAlamat.TextChanged += textBoxAlamat_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(429, 6);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 23;
            label7.Text = "Alamat";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
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
            buttonTambahTransaksi.Location = new Point(423, 32);
            buttonTambahTransaksi.Name = "buttonTambahTransaksi";
            buttonTambahTransaksi.Size = new Size(200, 35);
            buttonTambahTransaksi.TabIndex = 24;
            buttonTambahTransaksi.Text = "Tambah Transaksi";
            buttonTambahTransaksi.TextAlign = ContentAlignment.MiddleLeft;
            buttonTambahTransaksi.UseVisualStyleBackColor = false;
            buttonTambahTransaksi.Click += buttonTambahTransaksi_Click;
            // 
            // listBoxKerusakan
            // 
            listBoxKerusakan.FormattingEnabled = true;
            listBoxKerusakan.ItemHeight = 15;
            listBoxKerusakan.Location = new Point(429, 65);
            listBoxKerusakan.Name = "listBoxKerusakan";
            listBoxKerusakan.Size = new Size(185, 49);
            listBoxKerusakan.TabIndex = 25;
            listBoxKerusakan.SelectedIndexChanged += listBoxKerusakan_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Controls.Add(textBoxNamaLaptop);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(169, 170);
            panel4.Name = "panel4";
            panel4.Size = new Size(1048, 50);
            panel4.TabIndex = 28;
            // 
            // panel5
            // 
            panel5.Controls.Add(listBoxKerusakan);
            panel5.Controls.Add(btnHapusKerusakan);
            panel5.Controls.Add(btnTambahKerusakan);
            panel5.Controls.Add(comboBoxKerusakan);
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(169, 220);
            panel5.Name = "panel5";
            panel5.Size = new Size(1048, 138);
            panel5.TabIndex = 29;
            // 
            // btnHapusKerusakan
            // 
            btnHapusKerusakan.AutoSize = true;
            btnHapusKerusakan.Location = new Point(648, 75);
            btnHapusKerusakan.Name = "btnHapusKerusakan";
            btnHapusKerusakan.Size = new Size(169, 39);
            btnHapusKerusakan.TabIndex = 27;
            btnHapusKerusakan.Text = "Hapus Kerusakan";
            btnHapusKerusakan.UseVisualStyleBackColor = true;
            btnHapusKerusakan.Click += btnHapusKerusakan_Click;
            // 
            // btnTambahKerusakan
            // 
            btnTambahKerusakan.AutoSize = true;
            btnTambahKerusakan.Location = new Point(648, 18);
            btnTambahKerusakan.Name = "btnTambahKerusakan";
            btnTambahKerusakan.Size = new Size(169, 39);
            btnTambahKerusakan.TabIndex = 26;
            btnTambahKerusakan.Text = "Tambah Kerusakan";
            btnTambahKerusakan.UseVisualStyleBackColor = true;
            btnTambahKerusakan.Click += btnTambahKerusakan_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(comboBoxTeknisi);
            panel6.Controls.Add(label6);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(169, 358);
            panel6.Name = "panel6";
            panel6.Size = new Size(1048, 50);
            panel6.TabIndex = 30;
            // 
            // panel7
            // 
            panel7.Controls.Add(textBoxAlamat);
            panel7.Controls.Add(label7);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(169, 408);
            panel7.Name = "panel7";
            panel7.Size = new Size(1048, 50);
            panel7.TabIndex = 31;
            // 
            // panel10
            // 
            panel10.Controls.Add(buttonTambahTransaksi);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(169, 458);
            panel10.Name = "panel10";
            panel10.Size = new Size(1048, 70);
            panel10.TabIndex = 32;
            // 
            // FormServisLaptopPelanggan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 624);
            Controls.Add(panel10);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel9);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormServisLaptopPelanggan";
            Text = "FormServisLaptopPelanggan";
            WindowState = FormWindowState.Maximized;
            Load += FormServisLaptopPelanggan_Load;
            sidebar.ResumeLayout(false);
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)buttonMenu).EndInit();
            panel8.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel10.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panelSidebar;
        private Label label2;
        private PictureBox buttonMenu;
        private Panel panel9;
        private PictureBox pictureBox1;
        private Label labelUsername;
        private Label label1;
        private Panel panel8;
        private Panel panel2;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton buttonKomponen;
        private FontAwesome.Sharp.IconButton buttonTransaksi;
        private Label label3;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxNamaLaptop;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxKerusakan;
        private Label label6;
        private ComboBox comboBoxTeknisi;
        private TextBox textBoxAlamat;
        private Label label7;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton buttonTambahTransaksi;
        private ListBox listBoxKerusakan;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Button btnHapusKerusakan;
        private Button btnTambahKerusakan;
        private Panel panel10;
    }
}