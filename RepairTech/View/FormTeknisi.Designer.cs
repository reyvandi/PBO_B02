﻿namespace PROJECT_PBO
{
    partial class FormTeknisi
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            timerSidebar = new System.Windows.Forms.Timer(components);
            buttonLogout = new Button();
            buttonTambah = new FontAwesome.Sharp.IconButton();
            panel13 = new Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            panel6 = new Panel();
            buttonTeknisi = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            buttonJasa = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            buttonKomponen = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            buttonTransaksi = new FontAwesome.Sharp.IconButton();
            panelSidebar = new Panel();
            panel7 = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            buttonMenu = new PictureBox();
            sidebar = new FlowLayoutPanel();
            panel8 = new Panel();
            panel9 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel13.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panelSidebar.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonMenu).BeginInit();
            sidebar.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
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
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.FromArgb(31, 30, 68);
            dataGridView1.Location = new Point(30, 0);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1501, 634);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.rpimg;
            pictureBox1.Location = new Point(1310, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(24, 23, 80);
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(iconButton1);
            panel5.Controls.Add(pictureBox1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(243, 0);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(1561, 83);
            panel5.TabIndex = 11;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(24, 23, 80);
            iconButton1.Dock = DockStyle.Left;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = SystemColors.Control;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconButton1.IconColor = Color.Cyan;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 50;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 0);
            iconButton1.Margin = new Padding(4, 5, 4, 5);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(209, 83);
            iconButton1.TabIndex = 8;
            iconButton1.Text = "Teknisi";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // timerSidebar
            // 
            timerSidebar.Interval = 10;
            timerSidebar.Tick += timerSidebar_Tick;
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(0, 0);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(75, 23);
            buttonLogout.TabIndex = 0;
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
            buttonTambah.Location = new Point(26, 16);
            buttonTambah.Margin = new Padding(4, 5, 4, 5);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(261, 50);
            buttonTambah.TabIndex = 13;
            buttonTambah.Text = "Tambah Teknisi";
            buttonTambah.TextAlign = ContentAlignment.MiddleLeft;
            buttonTambah.UseVisualStyleBackColor = false;
            buttonTambah.Click += buttonTambah_Click;
            // 
            // panel13
            // 
            panel13.Controls.Add(iconButton3);
            panel13.Location = new Point(4, 430);
            panel13.Margin = new Padding(4, 5, 4, 5);
            panel13.Name = "panel13";
            panel13.Padding = new Padding(0, 100, 0, 0);
            panel13.Size = new Size(239, 740);
            panel13.TabIndex = 12;
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
            iconButton3.Location = new Point(0, 658);
            iconButton3.Margin = new Padding(4, 5, 4, 5);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(239, 82);
            iconButton3.TabIndex = 10;
            iconButton3.Text = "Logout";
            iconButton3.TextAlign = ContentAlignment.MiddleRight;
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
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
            iconButton2.Location = new Point(4, 420);
            iconButton2.Margin = new Padding(4, 5, 4, 5);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(233, 0);
            iconButton2.TabIndex = 10;
            iconButton2.Text = "Logout";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(buttonTeknisi);
            panel4.Location = new Point(0, 332);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(243, 83);
            panel4.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Cyan;
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(9, 83);
            panel6.TabIndex = 3;
            // 
            // buttonTeknisi
            // 
            buttonTeknisi.BackColor = Color.FromArgb(31, 30, 68);
            buttonTeknisi.Dock = DockStyle.Right;
            buttonTeknisi.FlatAppearance.BorderSize = 0;
            buttonTeknisi.FlatStyle = FlatStyle.Flat;
            buttonTeknisi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTeknisi.ForeColor = SystemColors.Control;
            buttonTeknisi.IconChar = FontAwesome.Sharp.IconChar.Users;
            buttonTeknisi.IconColor = Color.Cyan;
            buttonTeknisi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonTeknisi.IconSize = 36;
            buttonTeknisi.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTeknisi.Location = new Point(0, 0);
            buttonTeknisi.Margin = new Padding(4, 5, 4, 5);
            buttonTeknisi.Name = "buttonTeknisi";
            buttonTeknisi.Padding = new Padding(7, 8, 7, 8);
            buttonTeknisi.Size = new Size(243, 83);
            buttonTeknisi.TabIndex = 1;
            buttonTeknisi.Text = "Teknisi";
            buttonTeknisi.TextAlign = ContentAlignment.MiddleRight;
            buttonTeknisi.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonJasa);
            panel3.Location = new Point(0, 249);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(243, 83);
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
            buttonJasa.IconColor = SystemColors.Control;
            buttonJasa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonJasa.IconSize = 32;
            buttonJasa.ImageAlign = ContentAlignment.MiddleLeft;
            buttonJasa.Location = new Point(0, 0);
            buttonJasa.Margin = new Padding(4, 5, 4, 5);
            buttonJasa.Name = "buttonJasa";
            buttonJasa.Padding = new Padding(7, 8, 7, 8);
            buttonJasa.Size = new Size(243, 83);
            buttonJasa.TabIndex = 1;
            buttonJasa.Text = "Jasa Servis";
            buttonJasa.TextAlign = ContentAlignment.MiddleRight;
            buttonJasa.UseVisualStyleBackColor = false;
            buttonJasa.Click += buttonJasa_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 30, 68);
            panel2.Controls.Add(buttonKomponen);
            panel2.Location = new Point(0, 166);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 83);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
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
            buttonKomponen.Padding = new Padding(7, 8, 7, 8);
            buttonKomponen.Size = new Size(243, 83);
            buttonKomponen.TabIndex = 2;
            buttonKomponen.Text = "Komponen";
            buttonKomponen.TextAlign = ContentAlignment.MiddleRight;
            buttonKomponen.UseVisualStyleBackColor = false;
            buttonKomponen.Click += buttonKomponen_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 30, 68);
            panel1.Controls.Add(buttonTransaksi);
            panel1.Location = new Point(0, 83);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 83);
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
            buttonTransaksi.Location = new Point(0, 0);
            buttonTransaksi.Margin = new Padding(4, 5, 4, 5);
            buttonTransaksi.Name = "buttonTransaksi";
            buttonTransaksi.Padding = new Padding(7, 8, 7, 8);
            buttonTransaksi.Size = new Size(243, 83);
            buttonTransaksi.TabIndex = 1;
            buttonTransaksi.Text = "Transaksi";
            buttonTransaksi.TextAlign = ContentAlignment.MiddleRight;
            buttonTransaksi.UseVisualStyleBackColor = false;
            buttonTransaksi.Click += buttonTransaksi_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(31, 30, 68);
            panelSidebar.Controls.Add(panel7);
            panelSidebar.Controls.Add(label1);
            panelSidebar.Controls.Add(buttonMenu);
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(243, 83);
            panelSidebar.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(iconButton4);
            panel7.Location = new Point(243, 66);
            panel7.Name = "panel7";
            panel7.Size = new Size(1681, 243);
            panel7.TabIndex = 17;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.Green;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton4.ForeColor = SystemColors.Control;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 17;
            iconButton4.ImageAlign = ContentAlignment.MiddleRight;
            iconButton4.Location = new Point(733, 82);
            iconButton4.Margin = new Padding(4, 5, 4, 5);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(261, 50);
            iconButton4.TabIndex = 13;
            iconButton4.Text = "Tambah Teknisi";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(71, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(172, 83);
            label1.TabIndex = 2;
            label1.Text = "Menu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
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
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(31, 30, 68);
            sidebar.Controls.Add(panelSidebar);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(iconButton2);
            sidebar.Controls.Add(panel13);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(4, 5, 4, 5);
            sidebar.MaximumSize = new Size(243, 1333);
            sidebar.MinimumSize = new Size(71, 1033);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(243, 1170);
            sidebar.TabIndex = 10;
            // 
            // panel8
            // 
            panel8.Controls.Add(buttonTambah);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(243, 83);
            panel8.Name = "panel8";
            panel8.Size = new Size(1561, 83);
            panel8.TabIndex = 14;
            // 
            // panel9
            // 
            panel9.Controls.Add(dataGridView1);
            panel9.Dock = DockStyle.Top;
            panel9.ForeColor = SystemColors.ControlText;
            panel9.Location = new Point(243, 166);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(30, 0, 30, 0);
            panel9.Size = new Size(1561, 634);
            panel9.TabIndex = 15;
            // 
            // FormTeknisi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1804, 1170);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel5);
            Controls.Add(sidebar);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormTeknisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTeknisi";
            WindowState = FormWindowState.Maximized;
            Load += FormTeknisi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelSidebar.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)buttonMenu).EndInit();
            sidebar.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Panel panel5;
        private System.Windows.Forms.Timer timerSidebar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Button buttonLogout;
        private Panel panel8;
        private FontAwesome.Sharp.IconButton buttonTambah;
        private Panel panel9;
        private Panel panel13;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel panel4;
        private Panel panel6;
        private FontAwesome.Sharp.IconButton buttonTeknisi;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton buttonJasa;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton buttonKomponen;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton buttonTransaksi;
        private Panel panelSidebar;
        private Label label1;
        private PictureBox buttonMenu;
        private FlowLayoutPanel sidebar;
        private Panel panel7;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}