namespace PROJECT_PBO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeknisi));
            dataGridView1 = new DataGridView();
            panelSidebar = new Panel();
            label1 = new Label();
            buttonMenu = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            buttonTransaksi = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            buttonKomponen = new FontAwesome.Sharp.IconButton();
            panel6 = new Panel();
            timerSidebar = new System.Windows.Forms.Timer(components);
            buttonJasa = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            panel4 = new Panel();
            buttonTeknisi = new FontAwesome.Sharp.IconButton();
            buttonTambah = new FontAwesome.Sharp.IconButton();
            sidebar = new FlowLayoutPanel();
            panel7 = new Panel();
            buttonLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            sidebar.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
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
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.FromArgb(31, 30, 68);
            dataGridView1.Location = new Point(222, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1068, 483);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(31, 30, 68);
            panelSidebar.Controls.Add(label1);
            panelSidebar.Controls.Add(buttonMenu);
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(170, 50);
            panelSidebar.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(50, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(120, 50);
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
            buttonMenu.Padding = new Padding(10);
            buttonMenu.Size = new Size(50, 50);
            buttonMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            buttonMenu.TabIndex = 1;
            buttonMenu.TabStop = false;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.rpimg;
            pictureBox1.Location = new Point(1001, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 30, 68);
            panel1.Controls.Add(buttonTransaksi);
            panel1.Location = new Point(0, 50);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 50);
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
            buttonTransaksi.Name = "buttonTransaksi";
            buttonTransaksi.Padding = new Padding(5);
            buttonTransaksi.Size = new Size(170, 50);
            buttonTransaksi.TabIndex = 1;
            buttonTransaksi.Text = "Transaksi";
            buttonTransaksi.TextAlign = ContentAlignment.MiddleRight;
            buttonTransaksi.UseVisualStyleBackColor = false;
            buttonTransaksi.Click += buttonTransaksi_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(24, 23, 80);
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(iconButton1);
            panel5.Controls.Add(pictureBox1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(170, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1177, 50);
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
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(146, 50);
            iconButton1.TabIndex = 8;
            iconButton1.Text = "Teknisi";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 30, 68);
            panel2.Controls.Add(buttonKomponen);
            panel2.Location = new Point(0, 100);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(170, 50);
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
            buttonKomponen.Name = "buttonKomponen";
            buttonKomponen.Padding = new Padding(5);
            buttonKomponen.Size = new Size(170, 50);
            buttonKomponen.TabIndex = 2;
            buttonKomponen.Text = "Komponen";
            buttonKomponen.TextAlign = ContentAlignment.MiddleRight;
            buttonKomponen.UseVisualStyleBackColor = false;
            buttonKomponen.Click += buttonKomponen_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Cyan;
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(6, 50);
            panel6.TabIndex = 3;
            // 
            // timerSidebar
            // 
            timerSidebar.Interval = 10;
            timerSidebar.Tick += timerSidebar_Tick;
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
            buttonJasa.Name = "buttonJasa";
            buttonJasa.Padding = new Padding(5);
            buttonJasa.Size = new Size(170, 50);
            buttonJasa.TabIndex = 1;
            buttonJasa.Text = "Jasa Servis";
            buttonJasa.TextAlign = ContentAlignment.MiddleRight;
            buttonJasa.UseVisualStyleBackColor = false;
            buttonJasa.Click += buttonJasa_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonJasa);
            panel3.Location = new Point(0, 150);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(170, 50);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(buttonTeknisi);
            panel4.Location = new Point(0, 200);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(170, 50);
            panel4.TabIndex = 5;
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
            buttonTeknisi.Name = "buttonTeknisi";
            buttonTeknisi.Padding = new Padding(5);
            buttonTeknisi.Size = new Size(170, 50);
            buttonTeknisi.TabIndex = 1;
            buttonTeknisi.Text = "Teknisi";
            buttonTeknisi.TextAlign = ContentAlignment.MiddleRight;
            buttonTeknisi.UseVisualStyleBackColor = false;
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
            buttonTambah.Location = new Point(686, 595);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(183, 30);
            buttonTambah.TabIndex = 13;
            buttonTambah.Text = "Tambah Komponen";
            buttonTambah.TextAlign = ContentAlignment.MiddleLeft;
            buttonTambah.UseVisualStyleBackColor = false;
            buttonTambah.Click += buttonTambah_Click;
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
            sidebar.MaximumSize = new Size(170, 800);
            sidebar.MinimumSize = new Size(50, 620);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(170, 637);
            sidebar.TabIndex = 10;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel7.Controls.Add(buttonLogout);
            panel7.Location = new Point(1168, 628);
            panel7.Name = "panel7";
            panel7.Size = new Size(170, 50);
            panel7.TabIndex = 14;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.FromArgb(24, 30, 54);
            buttonLogout.Dock = DockStyle.Fill;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.ForeColor = SystemColors.ButtonHighlight;
            buttonLogout.Image = (Image)resources.GetObject("buttonLogout.Image");
            buttonLogout.Location = new Point(0, 0);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(170, 50);
            buttonLogout.TabIndex = 12;
            buttonLogout.Text = "Logout";
            buttonLogout.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // FormTeknisi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1347, 637);
            Controls.Add(panel7);
            Controls.Add(dataGridView1);
            Controls.Add(panel5);
            Controls.Add(buttonTambah);
            Controls.Add(sidebar);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormTeknisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTeknisi";
            WindowState = FormWindowState.Maximized;
            Load += FormTeknisi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)buttonMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            sidebar.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panelSidebar;
        private Label label1;
        private PictureBox buttonMenu;
        private PictureBox pictureBox1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton buttonTransaksi;
        private Panel panel5;
        private Panel panel2;
        private Panel panel6;
        private System.Windows.Forms.Timer timerSidebar;
        private FontAwesome.Sharp.IconButton buttonJasa;
        private Panel panel3;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton buttonTambah;
        private FlowLayoutPanel sidebar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton buttonTeknisi;
        private FontAwesome.Sharp.IconButton buttonKomponen;
        private Panel panel7;
        private Button buttonLogout;
    }
}