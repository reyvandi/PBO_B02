namespace PROJECT_PBO
{
    partial class FormAdmin1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            sidebar = new FlowLayoutPanel();
            panelSidebar = new Panel();
            label1 = new Label();
            buttonMenu = new PictureBox();
            panel1 = new Panel();
            panel6 = new Panel();
            buttonTransaksi = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            buttonKomponen = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            buttonJasa = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            buttonTeknisi = new FontAwesome.Sharp.IconButton();
            panel11 = new Panel();
            panel13 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel7 = new Panel();
            buttonLogout = new Button();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            timerSidebar = new System.Windows.Forms.Timer(components);
            panelSearch = new Panel();
            panel8 = new Panel();
            panel10 = new Panel();
            panel9 = new Panel();
            panel12 = new Panel();
            buttonTambah = new FontAwesome.Sharp.IconButton();
            sidebar.SuspendLayout();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonMenu).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelSearch.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(31, 30, 68);
            sidebar.Controls.Add(panelSidebar);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel11);
            sidebar.Controls.Add(panel13);
            sidebar.Controls.Add(iconButton2);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(4, 5, 4, 5);
            sidebar.MaximumSize = new Size(241, 1332);
            sidebar.MinimumSize = new Size(71, 82);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(241, 1062);
            sidebar.TabIndex = 0;
            sidebar.WrapContents = false;
            sidebar.Paint += flowLayoutPanel1_Paint;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(31, 30, 68);
            panelSidebar.Controls.Add(label1);
            panelSidebar.Controls.Add(buttonMenu);
            panelSidebar.Dock = DockStyle.Top;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(241, 82);
            panelSidebar.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(71, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(170, 82);
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
            buttonMenu.Padding = new Padding(14, 18, 14, 18);
            buttonMenu.Size = new Size(71, 82);
            buttonMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            buttonMenu.TabIndex = 1;
            buttonMenu.TabStop = false;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(buttonTransaksi);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 82);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 82);
            panel1.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DeepSkyBlue;
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(9, 82);
            panel6.TabIndex = 4;
            // 
            // buttonTransaksi
            // 
            buttonTransaksi.BackColor = Color.FromArgb(31, 30, 68);
            buttonTransaksi.Dock = DockStyle.Right;
            buttonTransaksi.FlatAppearance.BorderSize = 0;
            buttonTransaksi.FlatStyle = FlatStyle.Flat;
            buttonTransaksi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTransaksi.ForeColor = SystemColors.Control;
            buttonTransaksi.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            buttonTransaksi.IconColor = Color.DeepSkyBlue;
            buttonTransaksi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonTransaksi.IconSize = 32;
            buttonTransaksi.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTransaksi.Location = new Point(0, 0);
            buttonTransaksi.Margin = new Padding(4, 5, 4, 5);
            buttonTransaksi.Name = "buttonTransaksi";
            buttonTransaksi.Padding = new Padding(9, 8, 9, 8);
            buttonTransaksi.Size = new Size(241, 82);
            buttonTransaksi.TabIndex = 1;
            buttonTransaksi.Text = "Transaksi";
            buttonTransaksi.TextAlign = ContentAlignment.MiddleRight;
            buttonTransaksi.UseVisualStyleBackColor = false;
            buttonTransaksi.Click += buttonTransaksi_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonKomponen);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 164);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(241, 82);
            panel2.TabIndex = 5;
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
            buttonKomponen.Size = new Size(241, 82);
            buttonKomponen.TabIndex = 1;
            buttonKomponen.Text = "Komponen";
            buttonKomponen.TextAlign = ContentAlignment.MiddleRight;
            buttonKomponen.UseVisualStyleBackColor = false;
            buttonKomponen.Click += buttonKomponen_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonJasa);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 246);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(241, 82);
            panel3.TabIndex = 5;
            // 
            // buttonJasa
            // 
            buttonJasa.BackColor = Color.FromArgb(31, 30, 68);
            buttonJasa.Dock = DockStyle.Fill;
            buttonJasa.FlatAppearance.BorderSize = 0;
            buttonJasa.FlatStyle = FlatStyle.Flat;
            buttonJasa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonJasa.ForeColor = SystemColors.Control;
            buttonJasa.IconChar = FontAwesome.Sharp.IconChar.Screwdriver;
            buttonJasa.IconColor = Color.White;
            buttonJasa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonJasa.IconSize = 32;
            buttonJasa.ImageAlign = ContentAlignment.MiddleLeft;
            buttonJasa.Location = new Point(0, 0);
            buttonJasa.Margin = new Padding(4, 5, 4, 5);
            buttonJasa.Name = "buttonJasa";
            buttonJasa.Padding = new Padding(9, 8, 9, 8);
            buttonJasa.Size = new Size(241, 82);
            buttonJasa.TabIndex = 1;
            buttonJasa.Text = "Jasa Servis";
            buttonJasa.TextAlign = ContentAlignment.MiddleRight;
            buttonJasa.UseVisualStyleBackColor = false;
            buttonJasa.Click += buttonJasa_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(buttonTeknisi);
            panel4.Location = new Point(0, 328);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(241, 82);
            panel4.TabIndex = 5;
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
            buttonTeknisi.Size = new Size(241, 82);
            buttonTeknisi.TabIndex = 1;
            buttonTeknisi.Text = "Teknisi";
            buttonTeknisi.TextAlign = ContentAlignment.MiddleRight;
            buttonTeknisi.UseVisualStyleBackColor = false;
            buttonTeknisi.Click += buttonTeknisi_Click;
            // 
            // panel11
            // 
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(4, 415);
            panel11.Margin = new Padding(4, 5, 4, 5);
            panel11.Name = "panel11";
            panel11.Size = new Size(233, 82);
            panel11.TabIndex = 8;
            // 
            // panel13
            // 
            panel13.Location = new Point(4, 507);
            panel13.Margin = new Padding(4, 5, 4, 5);
            panel13.Name = "panel13";
            panel13.Padding = new Padding(0, 100, 0, 0);
            panel13.Size = new Size(233, 950);
            panel13.TabIndex = 9;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(31, 30, 68);
            iconButton2.Dock = DockStyle.Left;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.ForeColor = SystemColors.Control;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowUpRightFromSquare;
            iconButton2.IconColor = Color.Red;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 32;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(4, 1467);
            iconButton2.Margin = new Padding(4, 5, 4, 5);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(233, 82);
            iconButton2.TabIndex = 9;
            iconButton2.Text = "Logout";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel7.Controls.Add(buttonLogout);
            panel7.Location = new Point(4254, 2820);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(251, 82);
            panel7.TabIndex = 13;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.Red;
            buttonLogout.Dock = DockStyle.Fill;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.ForeColor = SystemColors.ButtonHighlight;
            buttonLogout.Image = (Image)resources.GetObject("buttonLogout.Image");
            buttonLogout.Location = new Point(0, 0);
            buttonLogout.Margin = new Padding(4, 5, 4, 5);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(251, 82);
            buttonLogout.TabIndex = 15;
            buttonLogout.Text = "Logout";
            buttonLogout.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click_1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(24, 23, 80);
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(iconButton1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(241, 0);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(1683, 82);
            panel5.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.rpimg;
            pictureBox1.Location = new Point(1432, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(24, 23, 80);
            iconButton1.Dock = DockStyle.Left;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = SystemColors.Control;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            iconButton1.IconColor = Color.DeepSkyBlue;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 50;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 0);
            iconButton1.Margin = new Padding(4, 5, 4, 5);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(259, 82);
            iconButton1.TabIndex = 2;
            iconButton1.Text = "Transaksi";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(46, 51, 73);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 30, 68);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.FromArgb(31, 30, 68);
            dataGridView1.Location = new Point(40, 0);
            dataGridView1.Margin = new Padding(6, 8, 6, 8);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1603, 832);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // timerSidebar
            // 
            timerSidebar.Interval = 10;
            timerSidebar.Tick += timerSidebar_Tick_1;
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(buttonTambah);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(241, 82);
            panelSearch.Margin = new Padding(4, 5, 4, 5);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1683, 99);
            panelSearch.TabIndex = 14;
            // 
            // panel8
            // 
            panel8.Controls.Add(dataGridView1);
            panel8.Controls.Add(panel10);
            panel8.Dock = DockStyle.Top;
            panel8.ForeColor = SystemColors.ControlText;
            panel8.Location = new Point(241, 181);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(40, 0, 40, 0);
            panel8.Size = new Size(1683, 832);
            panel8.TabIndex = 15;
            panel8.Paint += panel8_Paint;
            // 
            // panel10
            // 
            panel10.Location = new Point(203, 537);
            panel10.Margin = new Padding(4, 5, 4, 5);
            panel10.Name = "panel10";
            panel10.Size = new Size(286, 167);
            panel10.TabIndex = 6;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel12);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(241, 1013);
            panel9.Margin = new Padding(4, 5, 4, 5);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(714, 20, 500, 40);
            panel9.Size = new Size(1683, 157);
            panel9.TabIndex = 16;
            panel9.Paint += panel9_Paint;
            // 
            // panel12
            // 
            panel12.Location = new Point(196, 50);
            panel12.Margin = new Padding(4, 5, 4, 5);
            panel12.Name = "panel12";
            panel12.Size = new Size(0, 0);
            panel12.TabIndex = 8;
            // 
            // buttonTambah
            // 
            buttonTambah.Anchor = AnchorStyles.None;
            buttonTambah.BackColor = Color.Green;
            buttonTambah.FlatAppearance.BorderSize = 0;
            buttonTambah.FlatStyle = FlatStyle.Flat;
            buttonTambah.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTambah.IconChar = FontAwesome.Sharp.IconChar.Add;
            buttonTambah.IconColor = Color.White;
            buttonTambah.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonTambah.IconSize = 17;
            buttonTambah.ImageAlign = ContentAlignment.MiddleRight;
            buttonTambah.Location = new Point(40, 24);
            buttonTambah.Margin = new Padding(4, 5, 4, 5);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(236, 58);
            buttonTambah.TabIndex = 8;
            buttonTambah.Text = "Tambah Transaksi";
            buttonTambah.TextAlign = ContentAlignment.MiddleLeft;
            buttonTambah.UseVisualStyleBackColor = false;
            buttonTambah.Click += buttonTambah_Click_1;
            // 
            // FormAdmin1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1924, 1062);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panelSearch);
            Controls.Add(panel5);
            Controls.Add(sidebar);
            Controls.Add(panel7);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormAdmin1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdmin1";
            WindowState = FormWindowState.Maximized;
            Load += FormAdmin1_Load;
            sidebar.ResumeLayout(false);
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)buttonMenu).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelSearch.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panelSidebar;
        private PictureBox buttonMenu;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton buttonTransaksi;
        private FontAwesome.Sharp.IconButton buttonKomponen;
        private FontAwesome.Sharp.IconButton buttonJasa;
        private FontAwesome.Sharp.IconButton buttonTeknisi;
        private Panel panel5;
        private Panel panel6;
        private FontAwesome.Sharp.IconButton iconButton1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private System.Windows.Forms.Timer timerSidebar;
        private Panel panel7;
        private Panel panelSearch;
        private Panel panel8;
        private Panel panel9;
        private Button buttonLogout;
        private Panel panel11;
        private Panel panel10;
        private Panel panel13;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel panel12;
        private FontAwesome.Sharp.IconButton buttonTambah;
    }
}