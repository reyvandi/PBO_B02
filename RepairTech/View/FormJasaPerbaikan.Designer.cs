namespace PROJECT_PBO
{
    partial class FormJasaPerbaikan
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJasaPerbaikan));
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            timerSidebar = new System.Windows.Forms.Timer(components);
            buttonTeknisi = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            buttonJasa = new FontAwesome.Sharp.IconButton();
            buttonKomponen = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panel1 = new Panel();
            buttonTransaksi = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            buttonMenu = new PictureBox();
            panelSidebar = new Panel();
            panel3 = new Panel();
            panel6 = new Panel();
            sidebar = new FlowLayoutPanel();
            panel7 = new Panel();
            buttonLogout = new Button();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel9 = new Panel();
            buttonSearch = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            panel10 = new Panel();
            buttonTambah = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonMenu).BeginInit();
            panelSidebar.SuspendLayout();
            panel3.SuspendLayout();
            sidebar.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.rpimg;
            pictureBox1.Location = new Point(1432, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(24, 23, 80);
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(iconButton1);
            panel5.Controls.Add(pictureBox1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(241, 0);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(1683, 83);
            panel5.TabIndex = 9;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(24, 23, 80);
            iconButton1.Dock = DockStyle.Left;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = SystemColors.Control;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Screwdriver;
            iconButton1.IconColor = Color.Yellow;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 50;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 0);
            iconButton1.Margin = new Padding(4, 5, 4, 5);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(251, 83);
            iconButton1.TabIndex = 14;
            iconButton1.Text = "Jasa Servis";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // timerSidebar
            // 
            timerSidebar.Interval = 10;
            timerSidebar.Tick += timerSidebar_Tick;
            // 
            // buttonTeknisi
            // 
            buttonTeknisi.BackColor = Color.FromArgb(31, 30, 68);
            buttonTeknisi.Dock = DockStyle.Fill;
            buttonTeknisi.FlatAppearance.BorderSize = 0;
            buttonTeknisi.FlatStyle = FlatStyle.Flat;
            buttonTeknisi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTeknisi.ForeColor = SystemColors.Control;
            buttonTeknisi.IconChar = FontAwesome.Sharp.IconChar.Users;
            buttonTeknisi.IconColor = Color.White;
            buttonTeknisi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonTeknisi.IconSize = 32;
            buttonTeknisi.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTeknisi.Location = new Point(0, 0);
            buttonTeknisi.Margin = new Padding(4, 5, 4, 5);
            buttonTeknisi.Name = "buttonTeknisi";
            buttonTeknisi.Padding = new Padding(9, 8, 9, 8);
            buttonTeknisi.Size = new Size(241, 83);
            buttonTeknisi.TabIndex = 1;
            buttonTeknisi.Text = "Teknisi";
            buttonTeknisi.TextAlign = ContentAlignment.MiddleRight;
            buttonTeknisi.UseVisualStyleBackColor = false;
            buttonTeknisi.Click += buttonTeknisi_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(buttonTeknisi);
            panel4.Location = new Point(0, 332);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(241, 83);
            panel4.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(46, 51, 73);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(31, 30, 68);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.FromArgb(31, 30, 68);
            dataGridView1.ImeMode = ImeMode.On;
            dataGridView1.Location = new Point(30, 0);
            dataGridView1.Margin = new Padding(6, 8, 6, 8);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1623, 842);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonJasa
            // 
            buttonJasa.BackColor = Color.FromArgb(31, 30, 68);
            buttonJasa.Dock = DockStyle.Right;
            buttonJasa.FlatAppearance.BorderSize = 0;
            buttonJasa.FlatStyle = FlatStyle.Flat;
            buttonJasa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonJasa.ForeColor = SystemColors.Control;
            buttonJasa.IconChar = FontAwesome.Sharp.IconChar.Screwdriver;
            buttonJasa.IconColor = Color.Yellow;
            buttonJasa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonJasa.IconSize = 36;
            buttonJasa.ImageAlign = ContentAlignment.MiddleLeft;
            buttonJasa.Location = new Point(0, 0);
            buttonJasa.Margin = new Padding(4, 5, 4, 5);
            buttonJasa.Name = "buttonJasa";
            buttonJasa.Padding = new Padding(9, 8, 9, 8);
            buttonJasa.Size = new Size(241, 83);
            buttonJasa.TabIndex = 1;
            buttonJasa.Text = "Jasa Servis";
            buttonJasa.TextAlign = ContentAlignment.MiddleRight;
            buttonJasa.UseVisualStyleBackColor = false;
            // 
            // buttonKomponen
            // 
            buttonKomponen.BackColor = Color.FromArgb(31, 30, 68);
            buttonKomponen.Dock = DockStyle.Fill;
            buttonKomponen.FlatAppearance.BorderSize = 0;
            buttonKomponen.FlatStyle = FlatStyle.Flat;
            buttonKomponen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKomponen.ForeColor = SystemColors.Control;
            buttonKomponen.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            buttonKomponen.IconColor = Color.White;
            buttonKomponen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonKomponen.IconSize = 32;
            buttonKomponen.ImageAlign = ContentAlignment.MiddleLeft;
            buttonKomponen.Location = new Point(0, 0);
            buttonKomponen.Margin = new Padding(4, 5, 4, 5);
            buttonKomponen.Name = "buttonKomponen";
            buttonKomponen.Padding = new Padding(9, 8, 9, 8);
            buttonKomponen.Size = new Size(241, 83);
            buttonKomponen.TabIndex = 1;
            buttonKomponen.Text = "Komponen";
            buttonKomponen.TextAlign = ContentAlignment.MiddleRight;
            buttonKomponen.UseVisualStyleBackColor = false;
            buttonKomponen.Click += buttonKomponen_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonKomponen);
            panel2.Location = new Point(0, 166);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(241, 83);
            panel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonTransaksi);
            panel1.Location = new Point(0, 83);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(9, 8, 9, 8);
            panel1.Size = new Size(241, 83);
            panel1.TabIndex = 5;
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
            buttonTransaksi.Location = new Point(9, 8);
            buttonTransaksi.Margin = new Padding(4, 5, 4, 5);
            buttonTransaksi.Name = "buttonTransaksi";
            buttonTransaksi.Size = new Size(223, 67);
            buttonTransaksi.TabIndex = 2;
            buttonTransaksi.Text = "Transaksi";
            buttonTransaksi.TextAlign = ContentAlignment.MiddleRight;
            buttonTransaksi.UseVisualStyleBackColor = false;
            buttonTransaksi.Click += buttonTransaksi_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(71, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(170, 83);
            label1.TabIndex = 2;
            label1.Text = "Menu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonMenu
            // 
            buttonMenu.Cursor = Cursors.Hand;
            buttonMenu.Dock = DockStyle.Left;
            buttonMenu.Image = Properties.Resources.menu;
            buttonMenu.Location = new Point(0, 0);
            buttonMenu.Margin = new Padding(0);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Padding = new Padding(14, 17, 14, 17);
            buttonMenu.Size = new Size(71, 83);
            buttonMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            buttonMenu.TabIndex = 1;
            buttonMenu.TabStop = false;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(31, 30, 68);
            panelSidebar.Controls.Add(label1);
            panelSidebar.Controls.Add(buttonMenu);
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(241, 83);
            panelSidebar.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(buttonJasa);
            panel3.Location = new Point(0, 249);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(241, 83);
            panel3.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Yellow;
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(9, 83);
            panel6.TabIndex = 4;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(31, 30, 68);
            sidebar.Controls.Add(panelSidebar);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(4, 5, 4, 5);
            sidebar.MaximumSize = new Size(241, 1333);
            sidebar.MinimumSize = new Size(71, 1033);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(241, 1170);
            sidebar.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel7.Controls.Add(buttonLogout);
            panel7.Location = new Point(3757, 2568);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(241, 83);
            panel7.TabIndex = 14;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.FromArgb(24, 30, 54);
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.ForeColor = SystemColors.ButtonHighlight;
            buttonLogout.Image = (Image)resources.GetObject("buttonLogout.Image");
            buttonLogout.Location = new Point(241, 83);
            buttonLogout.Margin = new Padding(4, 5, 4, 5);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(714, 667);
            buttonLogout.TabIndex = 12;
            buttonLogout.Text = "Logout";
            buttonLogout.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.None;
            iconButton2.BackColor = Color.Green;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 17;
            iconButton2.ImageAlign = ContentAlignment.MiddleRight;
            iconButton2.Location = new Point(1214, 1337);
            iconButton2.Margin = new Padding(4, 5, 4, 5);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(276, 58);
            iconButton2.TabIndex = 13;
            iconButton2.Text = "Tambah Jasa Servis";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(buttonTambah);
            panel9.Controls.Add(buttonSearch);
            panel9.Controls.Add(textBox1);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(241, 83);
            panel9.Margin = new Padding(4, 5, 4, 5);
            panel9.Name = "panel9";
            panel9.Size = new Size(1683, 82);
            panel9.TabIndex = 16;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(24, 23, 80);
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = SystemColors.Control;
            buttonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            buttonSearch.IconColor = Color.White;
            buttonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonSearch.IconSize = 18;
            buttonSearch.ImageAlign = ContentAlignment.MiddleRight;
            buttonSearch.Location = new Point(1019, 17);
            buttonSearch.Margin = new Padding(4, 5, 4, 5);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(124, 45);
            buttonSearch.TabIndex = 19;
            buttonSearch.Text = "Search";
            buttonSearch.TextAlign = ContentAlignment.MiddleLeft;
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click_1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(529, 22);
            textBox1.Margin = new Padding(0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(489, 42);
            textBox1.TabIndex = 18;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel10
            // 
            panel10.Controls.Add(dataGridView1);
            panel10.Dock = DockStyle.Top;
            panel10.ForeColor = SystemColors.ControlText;
            panel10.Location = new Point(241, 165);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(30, 0, 30, 0);
            panel10.Size = new Size(1683, 842);
            panel10.TabIndex = 17;
            // 
            // buttonTambah
            // 
            buttonTambah.BackColor = Color.Green;
            buttonTambah.FlatAppearance.BorderSize = 0;
            buttonTambah.FlatStyle = FlatStyle.Flat;
            buttonTambah.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTambah.ForeColor = SystemColors.Control;
            buttonTambah.IconChar = FontAwesome.Sharp.IconChar.Add;
            buttonTambah.IconColor = Color.White;
            buttonTambah.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonTambah.IconSize = 17;
            buttonTambah.ImageAlign = ContentAlignment.MiddleRight;
            buttonTambah.Location = new Point(60, 16);
            buttonTambah.Margin = new Padding(4, 5, 4, 5);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(261, 50);
            buttonTambah.TabIndex = 20;
            buttonTambah.Text = "Tambah Jasa Servis";
            buttonTambah.TextAlign = ContentAlignment.MiddleLeft;
            buttonTambah.UseVisualStyleBackColor = false;
            buttonTambah.Click += buttonTambah_Click_1;
            // 
            // FormJasaPerbaikan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1924, 1170);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(sidebar);
            Controls.Add(iconButton2);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormJasaPerbaikan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormJasaServis";
            WindowState = FormWindowState.Maximized;
            Load += FormJasaServis_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)buttonMenu).EndInit();
            panelSidebar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            sidebar.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton buttonTambah;
        private PictureBox pictureBox1;
        private Panel panel5;
        private System.Windows.Forms.Timer timerSidebar;
        private FontAwesome.Sharp.IconButton buttonTeknisi;
        private Panel panel4;
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton buttonJasa;
        private FontAwesome.Sharp.IconButton buttonKomponen;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private PictureBox buttonMenu;
        private Panel panelSidebar;
        private Panel panel3;
        private FlowLayoutPanel sidebar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton buttonTransaksi;
        private Panel panel6;
        private Panel panel7;
        private Button buttonLogout;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel panel9;
        private FontAwesome.Sharp.IconButton buttonSearch;
        private TextBox textBox1;
        private Panel panel10;
    }
}