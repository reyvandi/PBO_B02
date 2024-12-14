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
            panel13 = new Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
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
            labelUsername.Location = new Point(119, 0);
            labelUsername.Margin = new Padding(4, 0, 4, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Padding = new Padding(0, 33, 0, 0);
            labelUsername.Size = new Size(83, 78);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "       ";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(29, 33, 0, 0);
            label1.Size = new Size(119, 117);
            label1.TabIndex = 1;
            label1.Text = "Halo";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.rpimg;
            pictureBox1.Location = new Point(1369, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 117);
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
            buttonLogout.Location = new Point(1687, 1178);
            buttonLogout.Margin = new Padding(4, 5, 4, 5);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(237, 70);
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
            sidebar.Controls.Add(panel13);
            sidebar.Controls.Add(iconButton3);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(4, 5, 4, 5);
            sidebar.MaximumSize = new Size(241, 1332);
            sidebar.MinimumSize = new Size(71, 82);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(241, 1170);
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
            panelSidebar.Size = new Size(241, 82);
            panelSidebar.TabIndex = 0;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(71, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(170, 82);
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
            buttonMenu.Padding = new Padding(14, 18, 14, 18);
            buttonMenu.Size = new Size(71, 82);
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
            panel4.Location = new Point(0, 82);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(241, 82);
            panel4.TabIndex = 5;
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
            // 
            // panel8
            // 
            panel8.Controls.Add(buttonServis);
            panel8.Location = new Point(0, 164);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(241, 82);
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
            buttonServis.Margin = new Padding(4, 5, 4, 5);
            buttonServis.Name = "buttonServis";
            buttonServis.Padding = new Padding(7, 8, 7, 8);
            buttonServis.Size = new Size(241, 82);
            buttonServis.TabIndex = 2;
            buttonServis.Text = "Servis Laptop";
            buttonServis.TextAlign = ContentAlignment.MiddleRight;
            buttonServis.UseVisualStyleBackColor = false;
            buttonServis.Click += buttonServis_Click;
            // 
            // panel13
            // 
            panel13.Location = new Point(4, 251);
            panel13.Margin = new Padding(4, 5, 4, 5);
            panel13.Name = "panel13";
            panel13.Padding = new Padding(0, 100, 0, 0);
            panel13.Size = new Size(233, 823);
            panel13.TabIndex = 10;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.FromArgb(31, 30, 68);
            iconButton3.Dock = DockStyle.Bottom;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton3.ForeColor = SystemColors.Control;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.ArrowUpRightFromSquare;
            iconButton3.IconColor = Color.Red;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 32;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(4, 1084);
            iconButton3.Margin = new Padding(4, 5, 4, 5);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(233, 82);
            iconButton3.TabIndex = 11;
            iconButton3.Text = "Logout";
            iconButton3.TextAlign = ContentAlignment.MiddleRight;
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(24, 23, 80);
            panel9.Controls.Add(pictureBox1);
            panel9.Controls.Add(labelUsername);
            panel9.Controls.Add(label1);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(241, 0);
            panel9.Margin = new Padding(4, 5, 4, 5);
            panel9.Name = "panel9";
            panel9.Size = new Size(1683, 117);
            panel9.TabIndex = 15;
            // 
            // dataGridViewTransaksi
            // 
            dataGridViewTransaksi.AllowUserToAddRows = false;
            dataGridViewTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTransaksi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTransaksi.BackgroundColor = SystemColors.Control;
            dataGridViewTransaksi.BorderStyle = BorderStyle.None;
            dataGridViewTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransaksi.Dock = DockStyle.Fill;
            dataGridViewTransaksi.Location = new Point(43, 50);
            dataGridViewTransaksi.Margin = new Padding(4, 5, 4, 5);
            dataGridViewTransaksi.Name = "dataGridViewTransaksi";
            dataGridViewTransaksi.RowHeadersWidth = 62;
            dataGridViewTransaksi.Size = new Size(1597, 728);
            dataGridViewTransaksi.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewTransaksi);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(241, 117);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(43, 50, 43, 50);
            panel1.Size = new Size(1683, 828);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(buttonServisLaptop, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1683, 83);
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
            buttonServisLaptop.Location = new Point(734, 16);
            buttonServisLaptop.Margin = new Padding(4, 5, 4, 5);
            buttonServisLaptop.Name = "buttonServisLaptop";
            buttonServisLaptop.Size = new Size(214, 50);
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
            panel2.Location = new Point(241, 945);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1683, 83);
            panel2.TabIndex = 17;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FormPelanggan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1170);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel9);
            Controls.Add(buttonLogout);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
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
        private Panel panel13;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}