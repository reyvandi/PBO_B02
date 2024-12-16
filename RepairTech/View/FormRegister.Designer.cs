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
            label3 = new Label();
            label4 = new Label();
            buttonBack = new Button();
            button1 = new Button();
            ButtonRegistrasi = new Button();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxUsername = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 0;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(0, 0);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(74, 1058);
            button1.Name = "button1";
            button1.Size = new Size(143, 45);
            button1.TabIndex = 0;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ButtonRegistrasi
            // 
            ButtonRegistrasi.BackColor = SystemColors.ActiveCaption;
            ButtonRegistrasi.ForeColor = SystemColors.ControlText;
            ButtonRegistrasi.Location = new Point(270, 717);
            ButtonRegistrasi.Name = "ButtonRegistrasi";
            ButtonRegistrasi.Size = new Size(160, 40);
            ButtonRegistrasi.TabIndex = 1;
            ButtonRegistrasi.Text = "Registrasi";
            ButtonRegistrasi.UseVisualStyleBackColor = false;
            ButtonRegistrasi.Click += buttonRegistrasi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(253, 307);
            label1.Name = "label1";
            label1.Size = new Size(143, 37);
            label1.TabIndex = 2;
            label1.Text = "Registrasi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(215, 398);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(215, 495);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(215, 596);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 6;
            label6.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(215, 442);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(282, 23);
            textBoxUsername.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(215, 536);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(282, 23);
            textBoxEmail.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(215, 633);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(282, 23);
            textBoxPassword.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(932, 185);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(703, 693);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // FormRegister
            // 
            BackColor = Color.FromArgb(24, 23, 80);
            BackgroundImage = Properties.Resources.Frame_20;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1744, 1061);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxUsername);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ButtonRegistrasi);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimizeBox = false;
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private Button buttonBack;
        private Button button1;
        private Button ButtonRegistrasi;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private TextBox textBoxUsername;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private PictureBox pictureBox1;
    }
}