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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            panel1 = new Panel();
            panel2 = new Panel();
            buttonLOGIN = new Button();
            textBoxPASSWORD = new TextBox();
            textBoxUSERNAME = new TextBox();
            labelPASSWORD = new Label();
            labelUSERNAME = new Label();
            labelLOGIN = new Label();
            showPasswordCheckBox = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(buttonLOGIN);
            panel1.Controls.Add(textBoxPASSWORD);
            panel1.Controls.Add(textBoxUSERNAME);
            panel1.Controls.Add(labelPASSWORD);
            panel1.Controls.Add(labelUSERNAME);
            panel1.Controls.Add(labelLOGIN);
            panel1.Controls.Add(showPasswordCheckBox);
            panel1.Location = new Point(270, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 527);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Magenta;
            panel2.Location = new Point(270, 147);
            panel2.Name = "panel2";
            panel2.Size = new Size(564, 16);
            panel2.TabIndex = 6;
            // 
            // buttonLOGIN
            // 
            buttonLOGIN.BackColor = Color.Magenta;
            buttonLOGIN.BackgroundImage = (Image)resources.GetObject("buttonLOGIN.BackgroundImage");
            buttonLOGIN.BackgroundImageLayout = ImageLayout.Zoom;
            buttonLOGIN.Location = new Point(201, 392);
            buttonLOGIN.Name = "buttonLOGIN";
            buttonLOGIN.Size = new Size(188, 41);
            buttonLOGIN.TabIndex = 5;
            buttonLOGIN.UseVisualStyleBackColor = false;
            // 
            // textBoxPASSWORD
            // 
            textBoxPASSWORD.Location = new Point(174, 257);
            textBoxPASSWORD.Multiline = true;
            textBoxPASSWORD.Name = "textBoxPASSWORD";
            textBoxPASSWORD.Size = new Size(239, 36);
            textBoxPASSWORD.TabIndex = 4;
            // 
            // textBoxUSERNAME
            // 
            textBoxUSERNAME.Location = new Point(174, 162);
            textBoxUSERNAME.Multiline = true;
            textBoxUSERNAME.Name = "textBoxUSERNAME";
            textBoxUSERNAME.Size = new Size(239, 39);
            textBoxUSERNAME.TabIndex = 3;
            // 
            // labelPASSWORD
            // 
            labelPASSWORD.AutoSize = true;
            labelPASSWORD.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPASSWORD.ForeColor = SystemColors.Control;
            labelPASSWORD.Location = new Point(174, 219);
            labelPASSWORD.Name = "labelPASSWORD";
            labelPASSWORD.Size = new Size(126, 35);
            labelPASSWORD.TabIndex = 2;
            labelPASSWORD.Text = "Password";
            // 
            // labelUSERNAME
            // 
            labelUSERNAME.AutoSize = true;
            labelUSERNAME.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUSERNAME.ForeColor = SystemColors.Control;
            labelUSERNAME.Location = new Point(174, 124);
            labelUSERNAME.Name = "labelUSERNAME";
            labelUSERNAME.Size = new Size(134, 35);
            labelUSERNAME.TabIndex = 1;
            labelUSERNAME.Text = "Username";
            // 
            // labelLOGIN
            // 
            labelLOGIN.AutoSize = true;
            labelLOGIN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLOGIN.ForeColor = SystemColors.Control;
            labelLOGIN.Location = new Point(250, 15);
            labelLOGIN.Name = "labelLOGIN";
            labelLOGIN.Size = new Size(78, 32);
            labelLOGIN.TabIndex = 0;
            labelLOGIN.Text = "Login";
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPasswordCheckBox.ForeColor = SystemColors.Control;
            showPasswordCheckBox.Location = new Point(185, 312);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(183, 29);
            showPasswordCheckBox.TabIndex = 7;
            showPasswordCheckBox.Text = "Show Password";
            showPasswordCheckBox.CheckedChanged += showPasswordCheckBox_CheckedChanged;
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1098, 747);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "LOGIN";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelUSERNAME;
        private Label labelLOGIN;
        private Panel panel2;
        private Button buttonLOGIN;
        private TextBox textBoxPASSWORD;
        private TextBox textBoxUSERNAME;
        private Label labelPASSWORD;
        private CheckBox showPasswordCheckBox; // Deklarasi checkbox di sini
    }
}
