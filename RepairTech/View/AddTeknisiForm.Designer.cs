namespace PROJECT_PBO.View
{
    partial class AddTeknisiForm
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
            textBoxNama = new TextBox();
            label2 = new Label();
            comboBoxKeahlian = new ComboBox();
            label3 = new Label();
            comboBoxJamKerja = new ComboBox();
            label4 = new Label();
            textBoxAlamat = new TextBox();
            label5 = new Label();
            textBoxNoTelepon = new TextBox();
            buttonCancel = new Button();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(868, 131);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            label1.Click += label1_Click;
            // 
            // textBoxNama
            // 
            textBoxNama.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNama.Location = new Point(863, 164);
            textBoxNama.Margin = new Padding(3, 2, 3, 2);
            textBoxNama.Multiline = true;
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(300, 25);
            textBoxNama.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(867, 226);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Keahlian";
            label2.Click += label2_Click;
            // 
            // comboBoxKeahlian
            // 
            comboBoxKeahlian.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxKeahlian.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxKeahlian.FormattingEnabled = true;
            comboBoxKeahlian.Items.AddRange(new object[] { "Software", "Hardware" });
            comboBoxKeahlian.Location = new Point(867, 262);
            comboBoxKeahlian.Margin = new Padding(3, 2, 3, 2);
            comboBoxKeahlian.Name = "comboBoxKeahlian";
            comboBoxKeahlian.Size = new Size(297, 25);
            comboBoxKeahlian.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(867, 329);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 4;
            label3.Text = "Jam kerja";
            label3.Click += label3_Click;
            // 
            // comboBoxJamKerja
            // 
            comboBoxJamKerja.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxJamKerja.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxJamKerja.FormattingEnabled = true;
            comboBoxJamKerja.Items.AddRange(new object[] { "07.00 - 12.00", "12.00 -17.00" });
            comboBoxJamKerja.Location = new Point(867, 361);
            comboBoxJamKerja.Margin = new Padding(3, 2, 3, 2);
            comboBoxJamKerja.Name = "comboBoxJamKerja";
            comboBoxJamKerja.Size = new Size(297, 25);
            comboBoxJamKerja.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(868, 427);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 6;
            label4.Text = "Alamat";
            label4.Click += label4_Click;
            // 
            // textBoxAlamat
            // 
            textBoxAlamat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAlamat.Location = new Point(867, 460);
            textBoxAlamat.Margin = new Padding(3, 2, 3, 2);
            textBoxAlamat.Name = "textBoxAlamat";
            textBoxAlamat.Size = new Size(297, 25);
            textBoxAlamat.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(867, 520);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 8;
            label5.Text = "No Telepon";
            // 
            // textBoxNoTelepon
            // 
            textBoxNoTelepon.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNoTelepon.Location = new Point(867, 556);
            textBoxNoTelepon.Margin = new Padding(3, 2, 3, 2);
            textBoxNoTelepon.Multiline = true;
            textBoxNoTelepon.Name = "textBoxNoTelepon";
            textBoxNoTelepon.Size = new Size(297, 24);
            textBoxNoTelepon.TabIndex = 9;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Red;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.ForeColor = SystemColors.Control;
            buttonCancel.Location = new Point(952, 657);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(127, 32);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.SeaGreen;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = SystemColors.Control;
            buttonAdd.Location = new Point(922, 604);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(191, 32);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Submit";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // AddTeknisiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 23, 80);
            BackgroundImage = Properties.Resources.Frame_18;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1342, 723);
            ControlBox = false;
            Controls.Add(buttonAdd);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxNoTelepon);
            Controls.Add(label5);
            Controls.Add(textBoxAlamat);
            Controls.Add(label4);
            Controls.Add(comboBoxJamKerja);
            Controls.Add(label3);
            Controls.Add(comboBoxKeahlian);
            Controls.Add(label2);
            Controls.Add(textBoxNama);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddTeknisiForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddTeknisiForm";
            WindowState = FormWindowState.Maximized;
            Load += AddTeknisiForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNama;
        private Label label2;
        private ComboBox comboBoxKeahlian;
        private Label label3;
        private ComboBox comboBoxJamKerja;
        private Label label4;
        private TextBox textBoxAlamat;
        private Label label5;
        private TextBox textBoxNoTelepon;
        private Button buttonCancel;
        private Button buttonAdd;
    }
}