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
            buttonCancel = new Button();
            buttonAdd = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxNAMAKOMPONEN
            // 
            textBoxNAMAKOMPONEN.Location = new Point(236, 318);
            textBoxNAMAKOMPONEN.Margin = new Padding(4);
            textBoxNAMAKOMPONEN.Multiline = true;
            textBoxNAMAKOMPONEN.Name = "textBoxNAMAKOMPONEN";
            textBoxNAMAKOMPONEN.Size = new Size(380, 43);
            textBoxNAMAKOMPONEN.TabIndex = 0;
            textBoxNAMAKOMPONEN.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(236, 284);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 30);
            label1.TabIndex = 1;
            label1.Text = "Nama Komponen";
            label1.Click += label1_Click;
            // 
            // textBoxHARGA
            // 
            textBoxHARGA.Location = new Point(236, 431);
            textBoxHARGA.Margin = new Padding(4);
            textBoxHARGA.Multiline = true;
            textBoxHARGA.Name = "textBoxHARGA";
            textBoxHARGA.Size = new Size(380, 43);
            textBoxHARGA.TabIndex = 2;
            textBoxHARGA.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(236, 397);
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
            label3.Location = new Point(236, 495);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 30);
            label3.TabIndex = 4;
            label3.Text = "Stok";
            // 
            // textBoxSTOK
            // 
            textBoxSTOK.Location = new Point(236, 529);
            textBoxSTOK.Margin = new Padding(4);
            textBoxSTOK.Multiline = true;
            textBoxSTOK.Name = "textBoxSTOK";
            textBoxSTOK.Size = new Size(380, 43);
            textBoxSTOK.TabIndex = 5;
            textBoxSTOK.TextChanged += textBox3_TextChanged;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(1519, 109);
            buttonCancel.Margin = new Padding(4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(163, 44);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(1729, 109);
            buttonAdd.Margin = new Padding(4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(163, 44);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(buttonAdd);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 969);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 201);
            panel1.TabIndex = 8;
            // 
            // AddKomponenForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 23, 80);
            ClientSize = new Size(1924, 1170);
            Controls.Add(panel1);
            Controls.Add(textBoxSTOK);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxHARGA);
            Controls.Add(label1);
            Controls.Add(textBoxNAMAKOMPONEN);
            Margin = new Padding(4);
            Name = "AddKomponenForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddKomponenForm";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
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
        private Button buttonCancel;
        private Button buttonAdd;
        private Panel panel1;
    }
}