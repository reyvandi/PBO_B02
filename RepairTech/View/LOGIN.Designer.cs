namespace PROJECT_PBO
{
    partial class LOGIN
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            showPasswordCheckBox = new CheckBox();
            labelLOGIN = new Label();
            labelUSERNAME = new Label();
            labelPASSWORD = new Label();
            textBoxUSERNAME = new TextBox();
            textBoxPASSWORD = new TextBox();
            buttonLOGIN = new Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.Frame_4b;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(653, 669);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPasswordCheckBox.ForeColor = SystemColors.ActiveCaptionText;
            showPasswordCheckBox.Location = new Point(954, 445);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(136, 26);
            showPasswordCheckBox.TabIndex = 7;
            showPasswordCheckBox.Text = "Show Password";
            showPasswordCheckBox.CheckedChanged += showPasswordCheckBox_CheckedChanged;
            // 
            // labelLOGIN
            // 
            labelLOGIN.AutoSize = true;
            labelLOGIN.BackColor = Color.Transparent;
            labelLOGIN.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLOGIN.ForeColor = Color.DeepPink;
            labelLOGIN.Location = new Point(954, 250);
            labelLOGIN.Margin = new Padding(2, 0, 2, 0);
            labelLOGIN.Name = "labelLOGIN";
            labelLOGIN.Size = new Size(91, 33);
            labelLOGIN.TabIndex = 0;
            labelLOGIN.Text = "Login";
            // 
            // labelUSERNAME
            // 
            labelUSERNAME.AutoSize = true;
            labelUSERNAME.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUSERNAME.ForeColor = SystemColors.ActiveCaptionText;
            labelUSERNAME.Location = new Point(879, 310);
            labelUSERNAME.Margin = new Padding(2, 0, 2, 0);
            labelUSERNAME.Name = "labelUSERNAME";
            labelUSERNAME.Size = new Size(91, 23);
            labelUSERNAME.TabIndex = 1;
            labelUSERNAME.Text = "Username";
            // 
            // labelPASSWORD
            // 
            labelPASSWORD.AutoSize = true;
            labelPASSWORD.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPASSWORD.ForeColor = SystemColors.ActiveCaptionText;
            labelPASSWORD.Location = new Point(879, 376);
            labelPASSWORD.Margin = new Padding(2, 0, 2, 0);
            labelPASSWORD.Name = "labelPASSWORD";
            labelPASSWORD.Size = new Size(86, 23);
            labelPASSWORD.TabIndex = 2;
            labelPASSWORD.Text = "Password";
            // 
            // textBoxUSERNAME
            // 
            textBoxUSERNAME.BorderStyle = BorderStyle.FixedSingle;
            textBoxUSERNAME.ForeColor = Color.Black;
            textBoxUSERNAME.Location = new Point(879, 337);
            textBoxUSERNAME.Margin = new Padding(2);
            textBoxUSERNAME.Multiline = true;
            textBoxUSERNAME.Name = "textBoxUSERNAME";
            textBoxUSERNAME.Size = new Size(272, 24);
            textBoxUSERNAME.TabIndex = 3;
            textBoxUSERNAME.TextChanged += textBoxUSERNAME_TextChanged;
            // 
            // textBoxPASSWORD
            // 
            textBoxPASSWORD.BorderStyle = BorderStyle.FixedSingle;
            textBoxPASSWORD.ForeColor = Color.Black;
            textBoxPASSWORD.Location = new Point(879, 401);
            textBoxPASSWORD.Margin = new Padding(2);
            textBoxPASSWORD.Multiline = true;
            textBoxPASSWORD.Name = "textBoxPASSWORD";
            textBoxPASSWORD.Size = new Size(272, 23);
            textBoxPASSWORD.TabIndex = 4;
            textBoxPASSWORD.TextChanged += textBoxPASSWORD_TextChanged;
            textBoxPASSWORD.KeyDown += textBoxPASSWORD_KeyDown;
            // 
            // buttonLOGIN
            // 
            buttonLOGIN.BackColor = Color.FromArgb(31, 30, 68);
            buttonLOGIN.BackgroundImageLayout = ImageLayout.Zoom;
            buttonLOGIN.FlatAppearance.BorderSize = 0;
            buttonLOGIN.FlatStyle = FlatStyle.Flat;
            buttonLOGIN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLOGIN.ForeColor = SystemColors.Control;
            buttonLOGIN.Location = new Point(954, 489);
            buttonLOGIN.Margin = new Padding(2);
            buttonLOGIN.Name = "buttonLOGIN";
            buttonLOGIN.Size = new Size(131, 25);
            buttonLOGIN.TabIndex = 5;
            buttonLOGIN.Text = "Login";
            buttonLOGIN.UseVisualStyleBackColor = false;
            buttonLOGIN.Click += buttonLOGIN_Click_1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(996, 532);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(49, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1221, 669);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonLOGIN);
            Controls.Add(textBoxPASSWORD);
            Controls.Add(labelLOGIN);
            Controls.Add(textBoxUSERNAME);
            Controls.Add(labelPASSWORD);
            Controls.Add(showPasswordCheckBox);
            Controls.Add(labelUSERNAME);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "LOGIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += LOGIN_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private CheckBox showPasswordCheckBox;
        private Label labelLOGIN;
        private Label labelUSERNAME;
        private Label labelPASSWORD;
        private TextBox textBoxUSERNAME;
        private TextBox textBoxPASSWORD;
        private Button buttonLOGIN;
        private LinkLabel linkLabel1;
    }
}
