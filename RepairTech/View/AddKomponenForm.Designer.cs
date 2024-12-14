namespace PROJECT_PBO.View
{
    partial class AddKomponenForm
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
            textBoxNAMAKOMPONEN = new TextBox();
            label1 = new Label();
            textBoxHARGA = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxSTOK = new TextBox();
            buttonAdd = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // textBoxNAMAKOMPONEN
            // 
            textBoxNAMAKOMPONEN.Location = new Point(993, 128);
            textBoxNAMAKOMPONEN.Margin = new Padding(3, 2, 3, 2);
            textBoxNAMAKOMPONEN.Multiline = true;
            textBoxNAMAKOMPONEN.Name = "textBoxNAMAKOMPONEN";
            textBoxNAMAKOMPONEN.Size = new Size(267, 26);
            textBoxNAMAKOMPONEN.TabIndex = 0;
            textBoxNAMAKOMPONEN.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(993, 106);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 1;
            label1.Text = "Nama Komponen";
            label1.Click += label1_Click;
            // 
            // textBoxHARGA
            // 
            textBoxHARGA.Location = new Point(993, 227);
            textBoxHARGA.Margin = new Padding(3, 2, 3, 2);
            textBoxHARGA.Multiline = true;
            textBoxHARGA.Name = "textBoxHARGA";
            textBoxHARGA.Size = new Size(267, 27);
            textBoxHARGA.TabIndex = 2;
            textBoxHARGA.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(993, 205);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 3;
            label2.Text = "Harga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(993, 286);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 4;
            label3.Text = "Stok";
            // 
            // textBoxSTOK
            // 
            textBoxSTOK.Location = new Point(993, 308);
            textBoxSTOK.Margin = new Padding(3, 2, 3, 2);
            textBoxSTOK.Multiline = true;
            textBoxSTOK.Name = "textBoxSTOK";
            textBoxSTOK.Size = new Size(267, 26);
            textBoxSTOK.TabIndex = 5;
            textBoxSTOK.TextChanged += textBox3_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.SeaGreen;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = SystemColors.Control;
            buttonAdd.Location = new Point(1038, 378);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(185, 34);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Submit";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += button2_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Red;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(1071, 439);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(127, 32);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // AddKomponenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 23, 80);
            BackgroundImage = Properties.Resources.Frame_17;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1347, 637);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxSTOK);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxHARGA);
            Controls.Add(label1);
            Controls.Add(textBoxNAMAKOMPONEN);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddKomponenForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddKomponenForm";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNAMAKOMPONEN;
        private Label label1;
        private TextBox textBoxHARGA;
        private Label label2;
        private Label label3;
        private TextBox textBoxSTOK;
        private Button buttonAdd;
        private Button buttonCancel;
    }
}