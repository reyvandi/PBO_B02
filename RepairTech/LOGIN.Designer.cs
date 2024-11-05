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
            buttonLOGIN = new Button();
            textBoxPASSWORD = new TextBox();
            textBoxUSERNAME = new TextBox();
            labelPASSWORD = new Label();
            labelUSERNAME = new Label();
            labelLOGIN = new Label();
            showPasswordCheckBox = new CheckBox();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(buttonLOGIN);
            panel1.Controls.Add(textBoxPASSWORD);
            panel1.Controls.Add(textBoxUSERNAME);
            panel1.Controls.Add(labelPASSWORD);
            panel1.Controls.Add(labelUSERNAME);
            panel1.Controls.Add(labelLOGIN);
            panel1.Controls.Add(showPasswordCheckBox);
            panel1.Location = new Point(216, 64);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 422);
            panel1.TabIndex = 0;
            // 
            // buttonLOGIN
            // 
            buttonLOGIN.BackColor = Color.Magenta;
            buttonLOGIN.BackgroundImage = (Image)resources.GetObject("buttonLOGIN.BackgroundImage");
            buttonLOGIN.BackgroundImageLayout = ImageLayout.Zoom;
            buttonLOGIN.Location = new Point(161, 314);
            buttonLOGIN.Margin = new Padding(2);
            buttonLOGIN.Name = "buttonLOGIN";
            buttonLOGIN.Size = new Size(150, 33);
            buttonLOGIN.TabIndex = 5;
            buttonLOGIN.UseVisualStyleBackColor = false;
            // 
            // textBoxPASSWORD
            // 
            textBoxPASSWORD.Location = new Point(139, 206);
            textBoxPASSWORD.Margin = new Padding(2);
            textBoxPASSWORD.Multiline = true;
            textBoxPASSWORD.Name = "textBoxPASSWORD";
            textBoxPASSWORD.Size = new Size(192, 30);
            textBoxPASSWORD.TabIndex = 4;
            textBoxPASSWORD.TextChanged += textBoxPASSWORD_TextChanged;
            // 
            // textBoxUSERNAME
            // 
            textBoxUSERNAME.Location = new Point(139, 130);
            textBoxUSERNAME.Margin = new Padding(2);
            textBoxUSERNAME.Multiline = true;
            textBoxUSERNAME.Name = "textBoxUSERNAME";
            textBoxUSERNAME.Size = new Size(192, 32);
            textBoxUSERNAME.TabIndex = 3;
            textBoxUSERNAME.TextChanged += textBoxUSERNAME_TextChanged;
            // 
            // labelPASSWORD
            // 
            labelPASSWORD.AutoSize = true;
            labelPASSWORD.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPASSWORD.ForeColor = SystemColors.Control;
            labelPASSWORD.Location = new Point(139, 175);
            labelPASSWORD.Margin = new Padding(2, 0, 2, 0);
            labelPASSWORD.Name = "labelPASSWORD";
            labelPASSWORD.Size = new Size(111, 29);
            labelPASSWORD.TabIndex = 2;
            labelPASSWORD.Text = "Password";
            // 
            // labelUSERNAME
            // 
            labelUSERNAME.AutoSize = true;
            labelUSERNAME.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUSERNAME.ForeColor = SystemColors.Control;
            labelUSERNAME.Location = new Point(139, 99);
            labelUSERNAME.Margin = new Padding(2, 0, 2, 0);
            labelUSERNAME.Name = "labelUSERNAME";
            labelUSERNAME.Size = new Size(117, 29);
            labelUSERNAME.TabIndex = 1;
            labelUSERNAME.Text = "Username";
            // 
            // labelLOGIN
            // 
            labelLOGIN.AutoSize = true;
            labelLOGIN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLOGIN.ForeColor = SystemColors.Control;
            labelLOGIN.Location = new Point(200, 12);
            labelLOGIN.Margin = new Padding(2, 0, 2, 0);
            labelLOGIN.Name = "labelLOGIN";
            labelLOGIN.Size = new Size(64, 28);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1098, 747);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "LOGIN";
            Text = "Form1";
            Load += LOGIN_Load;
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
        private LinkLabel linkLabel1;
    }
}
