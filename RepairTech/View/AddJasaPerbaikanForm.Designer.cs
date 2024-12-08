namespace PROJECT_PBO.View
{
    partial class AddJasaPerbaikanForm
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
            buttonCancel = new Button();
            buttonAdd = new Button();
            label1 = new Label();
            textBoxJenisKerusakan = new TextBox();
            label2 = new Label();
            textBoxSolusi = new TextBox();
            textBoxBiaya = new TextBox();
            textBoxEstimasiWaktu = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Red;
            buttonCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.ForeColor = SystemColors.Control;
            buttonCancel.Location = new Point(13, 1090);
            buttonCancel.Margin = new Padding(4, 3, 4, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(181, 53);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.DarkBlue;
            buttonAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = SystemColors.Control;
            buttonAdd.Location = new Point(851, 692);
            buttonAdd.Margin = new Padding(4, 3, 4, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(191, 57);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Submit";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(794, 272);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 30);
            label1.TabIndex = 2;
            label1.Text = "Jenis kerusakan";
            // 
            // textBoxJenisKerusakan
            // 
            textBoxJenisKerusakan.Location = new Point(794, 303);
            textBoxJenisKerusakan.Margin = new Padding(4, 3, 4, 3);
            textBoxJenisKerusakan.Multiline = true;
            textBoxJenisKerusakan.Name = "textBoxJenisKerusakan";
            textBoxJenisKerusakan.Size = new Size(303, 46);
            textBoxJenisKerusakan.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(794, 362);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(73, 30);
            label2.TabIndex = 4;
            label2.Text = "Solusi";
            // 
            // textBoxSolusi
            // 
            textBoxSolusi.Location = new Point(794, 393);
            textBoxSolusi.Margin = new Padding(4, 3, 4, 3);
            textBoxSolusi.Multiline = true;
            textBoxSolusi.Name = "textBoxSolusi";
            textBoxSolusi.Size = new Size(303, 46);
            textBoxSolusi.TabIndex = 5;
            // 
            // textBoxBiaya
            // 
            textBoxBiaya.Location = new Point(794, 488);
            textBoxBiaya.Margin = new Padding(4, 3, 4, 3);
            textBoxBiaya.Multiline = true;
            textBoxBiaya.Name = "textBoxBiaya";
            textBoxBiaya.Size = new Size(303, 46);
            textBoxBiaya.TabIndex = 6;
            // 
            // textBoxEstimasiWaktu
            // 
            textBoxEstimasiWaktu.Location = new Point(794, 592);
            textBoxEstimasiWaktu.Margin = new Padding(4, 3, 4, 3);
            textBoxEstimasiWaktu.Multiline = true;
            textBoxEstimasiWaktu.Name = "textBoxEstimasiWaktu";
            textBoxEstimasiWaktu.Size = new Size(303, 46);
            textBoxEstimasiWaktu.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(794, 457);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 30);
            label3.TabIndex = 8;
            label3.Text = "Biaya";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(794, 558);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(168, 30);
            label4.TabIndex = 9;
            label4.Text = "Estimasi waktu";
            // 
            // label6
            // 
            label6.BackColor = Color.DarkBlue;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(1924, 108);
            label6.TabIndex = 13;
            label6.Text = "Tambah Jasa Service";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddJasaPerbaikanForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 23, 80);
            ClientSize = new Size(1924, 1170);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxEstimasiWaktu);
            Controls.Add(textBoxBiaya);
            Controls.Add(textBoxSolusi);
            Controls.Add(label2);
            Controls.Add(textBoxJenisKerusakan);
            Controls.Add(label1);
            Controls.Add(buttonAdd);
            Controls.Add(buttonCancel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddJasaPerbaikanForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddJasaPerbaikanForm";
            WindowState = FormWindowState.Maximized;
            Load += AddJasaPerbaikanForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonAdd;
        private Label label1;
        private TextBox textBoxJenisKerusakan;
        private Label label2;
        private TextBox textBoxSolusi;
        private TextBox textBoxBiaya;
        private TextBox textBoxEstimasiWaktu;
        private Label label3;
        private Label label4;
        private Label label6;
    }
}