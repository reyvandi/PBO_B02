namespace PROJECT_PBO
{
    partial class FormPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPelanggan));
            labelUsername = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            buttonLogout = new Button();
            sidebar = new FlowLayoutPanel();
            panelSidebar = new Panel();
            label2 = new Label();
            buttonMenu = new PictureBox();
            panel4 = new Panel();
            panel6 = new Panel();
            buttonTransaksi = new FontAwesome.Sharp.IconButton();
            panel8 = new Panel();
            buttonServis = new FontAwesome.Sharp.IconButton();
            panel9 = new Panel();
            dataGridViewTransaksi = new DataGridView();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonServisLaptop = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sidebar.SuspendLayout();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonMenu).BeginInit();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransaksi).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.rpimg;
            pictureBox1.Location = new Point(595, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // buttonLogout
            // 
            buttonLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonLogout.BackColor = Color.FromArgb(24, 30, 54);
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.ForeColor = SystemColors.ButtonHighlight;
            buttonLogout.Image = (Image)resources.GetObject("buttonLogout.Image");
            buttonLogout.Location = new Point(818, 707);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(166, 42);
            buttonLogout.TabIndex = 12;
            buttonLogout.Text = "Logout";
            buttonLogout.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(31, 30, 68);
            sidebar.Controls.Add(panelSidebar);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel8);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(169, 799);
            sidebar.MinimumSize = new Size(50, 49);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(169, 749);
            sidebar.TabIndex = 0;
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
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(buttonTransaksi);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 49);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(169, 49);
            panel4.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DeepSkyBlue;
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(6, 49);
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
            buttonTransaksi.Name = "buttonTransaksi";
            buttonTransaksi.Padding = new Padding(6, 5, 6, 5);
            buttonTransaksi.Size = new Size(169, 49);
            buttonTransaksi.TabIndex = 1;
            buttonTransaksi.Text = "Transaksi";
            buttonTransaksi.TextAlign = ContentAlignment.MiddleRight;
            buttonTransaksi.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(buttonServis);
            panel8.Location = new Point(0, 98);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(169, 49);
            panel8.TabIndex = 5;
            // 
            // buttonServis
            // 
            buttonServis.BackColor = Color.FromArgb(31, 30, 68);
            buttonServis.Dock = DockStyle.Fill;
            buttonServis.FlatAppearance.BorderSize = 0;
            buttonServis.FlatStyle = FlatStyle.Flat;
            buttonServis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonServis.ForeColor = SystemColors.Control;
            buttonServis.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            buttonServis.IconColor = Color.White;
            buttonServis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonServis.IconSize = 32;
            buttonServis.ImageAlign = ContentAlignment.MiddleLeft;
            buttonServis.Location = new Point(0, 0);
            buttonServis.Name = "buttonServis";
            buttonServis.Padding = new Padding(5);
            buttonServis.Size = new Size(169, 49);
            buttonServis.TabIndex = 2;
            buttonServis.Text = "Servis Laptop";
            buttonServis.TextAlign = ContentAlignment.MiddleRight;
            buttonServis.UseVisualStyleBackColor = false;
            buttonServis.Click += buttonServis_Click;
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
            panel9.Size = new Size(815, 70);
            panel9.TabIndex = 15;
            // 
            // dataGridViewTransaksi
            // 
            dataGridViewTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransaksi.Dock = DockStyle.Fill;
            dataGridViewTransaksi.Location = new Point(30, 30);
            dataGridViewTransaksi.Name = "dataGridViewTransaksi";
            dataGridViewTransaksi.Size = new Size(755, 437);
            dataGridViewTransaksi.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewTransaksi);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(169, 70);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30);
            panel1.Size = new Size(815, 497);
            panel1.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(buttonServisLaptop, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(815, 50);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // buttonServisLaptop
            // 
            buttonServisLaptop.Anchor = AnchorStyles.None;
            buttonServisLaptop.BackColor = Color.RoyalBlue;
            buttonServisLaptop.FlatAppearance.BorderSize = 0;
            buttonServisLaptop.FlatStyle = FlatStyle.Flat;
            buttonServisLaptop.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonServisLaptop.ForeColor = SystemColors.ButtonFace;
            buttonServisLaptop.IconChar = FontAwesome.Sharp.IconChar.Add;
            buttonServisLaptop.IconColor = Color.White;
            buttonServisLaptop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonServisLaptop.IconSize = 17;
            buttonServisLaptop.ImageAlign = ContentAlignment.MiddleRight;
            buttonServisLaptop.Location = new Point(332, 10);
            buttonServisLaptop.Name = "buttonServisLaptop";
            buttonServisLaptop.Size = new Size(150, 30);
            buttonServisLaptop.TabIndex = 8;
            buttonServisLaptop.Text = "Servis Laptop";
            buttonServisLaptop.TextAlign = ContentAlignment.MiddleLeft;
            buttonServisLaptop.UseVisualStyleBackColor = false;
            buttonServisLaptop.Click += buttonServisLaptop_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(169, 567);
            panel2.Name = "panel2";
            panel2.Size = new Size(815, 50);
            panel2.TabIndex = 17;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FormPelanggan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 749);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel9);
            Controls.Add(buttonLogout);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormPelanggan";
            Text = "FormPelanggan";
            WindowState = FormWindowState.Maximized;
            Load += FormPelanggan_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sidebar.ResumeLayout(false);
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)buttonMenu).EndInit();
            panel4.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransaksi).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label labelUsername;
        private Button buttonLogout;
        private FlowLayoutPanel sidebar;
        private Panel panelSidebar;
        private Label label2;
        private PictureBox buttonMenu;
        private Panel panel4;
        private Panel panel6;
        private FontAwesome.Sharp.IconButton buttonTransaksi;
        private Panel panel8;
        private Panel panel9;
        private DataGridView dataGridViewTransaksi;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton buttonServisLaptop;
        private Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton buttonServis;
    }
}