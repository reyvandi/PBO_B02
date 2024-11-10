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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxEmail = new TextBox();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonRegistrasi = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 14);
            label1.Name = "label1";
            label1.Size = new Size(143, 37);
            label1.TabIndex = 0;
            label1.Text = "Registrasi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 95);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(306, 196);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(306, 293);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(306, 113);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(171, 23);
            textBoxEmail.TabIndex = 4;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(306, 214);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(171, 23);
            textBoxUsername.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(306, 311);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(171, 23);
            textBoxPassword.TabIndex = 6;
            // 
            // buttonRegistrasi
            // 
            buttonRegistrasi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegistrasi.Location = new Point(668, 391);
            buttonRegistrasi.Name = "buttonRegistrasi";
            buttonRegistrasi.Size = new Size(120, 47);
            buttonRegistrasi.TabIndex = 7;
            buttonRegistrasi.Text = "Registrasi";
            buttonRegistrasi.UseVisualStyleBackColor = true;
            buttonRegistrasi.Click += buttonRegistrasi_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRegistrasi);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRegister";
            Text = "FormRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxEmail;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonRegistrasi;
    }
}