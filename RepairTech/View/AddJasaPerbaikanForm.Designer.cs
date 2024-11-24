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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(1398, 1075);
            buttonCancel.Margin = new Padding(4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(161, 48);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(1624, 1075);
            buttonAdd.Margin = new Padding(4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(135, 48);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(120, 285);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 28);
            label1.TabIndex = 2;
            label1.Text = "Jenis kerusakan";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 317);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 45);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(120, 375);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(68, 28);
            label2.TabIndex = 4;
            label2.Text = "Solusi";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(120, 407);
            textBox2.Margin = new Padding(4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(302, 45);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(120, 501);
            textBox3.Margin = new Padding(4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(302, 45);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(120, 604);
            textBox4.Margin = new Padding(4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(302, 45);
            textBox4.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(120, 469);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 8;
            label3.Text = "Biaya";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(120, 572);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(154, 28);
            label4.TabIndex = 9;
            label4.Text = "Estimasi waktu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(744, 72);
            label5.Name = "label5";
            label5.Size = new Size(398, 74);
            label5.TabIndex = 10;
            label5.Text = "Jasa Perbaikan";
            // 
            // AddJasaPerbaikanForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1823, 1170);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(buttonAdd);
            Controls.Add(buttonCancel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
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
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}