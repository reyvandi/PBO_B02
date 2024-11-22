namespace PROJECT_PBO.View
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonRegistrasi = new Button();
            buttonBack = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            textBoxEmail = new TextBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(666, 159);
            label1.TabIndex = 0;
            label1.Text = "Registrasi";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(200, 3);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(200, 3);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Dock = DockStyle.Fill;
            textBoxUsername.Location = new Point(200, 20);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(266, 23);
            textBoxUsername.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Dock = DockStyle.Fill;
            textBoxPassword.Location = new Point(200, 20);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(266, 23);
            textBoxPassword.TabIndex = 6;
            // 
            // buttonRegistrasi
            // 
            buttonRegistrasi.BackColor = Color.Aqua;
            buttonRegistrasi.Dock = DockStyle.Fill;
            buttonRegistrasi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegistrasi.Location = new Point(150, 20);
            buttonRegistrasi.Name = "buttonRegistrasi";
            buttonRegistrasi.Size = new Size(366, 40);
            buttonRegistrasi.TabIndex = 7;
            buttonRegistrasi.Text = "Registrasi";
            buttonRegistrasi.UseVisualStyleBackColor = false;
            buttonRegistrasi.Click += buttonRegistrasi_Click;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonBack.BackColor = Color.Red;
            buttonBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBack.ForeColor = SystemColors.Control;
            buttonBack.Location = new Point(21, 682);
            buttonBack.Margin = new Padding(10);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(105, 28);
            buttonBack.TabIndex = 8;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Location = new Point(666, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(20);
            pictureBox1.Size = new Size(684, 729);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 583);
            panel1.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.Controls.Add(buttonRegistrasi);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 339);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(150, 20, 150, 40);
            panel6.Size = new Size(666, 100);
            panel6.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBoxPassword);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 279);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(200, 20, 200, 0);
            panel5.Size = new Size(666, 60);
            panel5.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBoxUsername);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 219);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(200, 20, 200, 0);
            panel4.Size = new Size(666, 60);
            panel4.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBoxEmail);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 159);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(200, 20, 200, 0);
            panel3.Size = new Size(666, 60);
            panel3.TabIndex = 9;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(200, 3);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Dock = DockStyle.Fill;
            textBoxEmail.Location = new Point(200, 20);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(266, 23);
            textBoxEmail.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(666, 159);
            panel2.TabIndex = 8;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 68);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonBack);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegister";
            WindowState = FormWindowState.Maximized;
            Load += FormRegister_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonRegistrasi;
        private Button buttonBack;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
        private TextBox textBoxEmail;
        private Label label2;
        private Panel panel3;
    }
}