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
            textBoxNAMAKOMPONEN.Location = new Point(1290, 258);
            textBoxNAMAKOMPONEN.Margin = new Padding(4, 3, 4, 3);
            textBoxNAMAKOMPONEN.Multiline = true;
            textBoxNAMAKOMPONEN.Name = "textBoxNAMAKOMPONEN";
            textBoxNAMAKOMPONEN.Size = new Size(380, 41);
            textBoxNAMAKOMPONEN.TabIndex = 0;
            textBoxNAMAKOMPONEN.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(1290, 222);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 30);
            label1.TabIndex = 1;
            label1.Text = "Nama Komponen";
            label1.Click += label1_Click;
            // 
            // textBoxHARGA
            // 
            textBoxHARGA.Location = new Point(1290, 379);
            textBoxHARGA.Margin = new Padding(4, 3, 4, 3);
            textBoxHARGA.Multiline = true;
            textBoxHARGA.Name = "textBoxHARGA";
            textBoxHARGA.Size = new Size(380, 42);
            textBoxHARGA.TabIndex = 2;
            textBoxHARGA.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(1290, 343);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 30);
            label2.TabIndex = 3;
            label2.Text = "Harga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(1290, 478);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 30);
            label3.TabIndex = 4;
            label3.Text = "Stok";
            // 
            // textBoxSTOK
            // 
            textBoxSTOK.Location = new Point(1290, 514);
            textBoxSTOK.Margin = new Padding(4, 3, 4, 3);
            textBoxSTOK.Multiline = true;
            textBoxSTOK.Name = "textBoxSTOK";
            textBoxSTOK.Size = new Size(380, 41);
            textBoxSTOK.TabIndex = 5;
            textBoxSTOK.TextChanged += textBox3_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.SeaGreen;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = SystemColors.Control;
            buttonAdd.Location = new Point(1354, 631);
            buttonAdd.Margin = new Padding(4, 3, 4, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(264, 57);
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
            buttonCancel.Location = new Point(1715, 1094);
            buttonCancel.Margin = new Padding(4, 3, 4, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(181, 53);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // AddKomponenForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 23, 80);
            BackgroundImage = Properties.Resources.Frame_17;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1170);
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
            Margin = new Padding(4, 3, 4, 3);
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