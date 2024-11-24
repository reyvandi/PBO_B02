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
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            buttonCancel = new Button();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(234, 465);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(380, 43);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 431);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 30);
            label1.TabIndex = 1;
            label1.Text = "Nama Komponen";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(234, 578);
            textBox2.Margin = new Padding(4, 4, 4, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(380, 43);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(234, 544);
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
            label3.Location = new Point(234, 642);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 30);
            label3.TabIndex = 4;
            label3.Text = "Stok";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(234, 676);
            textBox3.Margin = new Padding(4, 4, 4, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(380, 43);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(1498, 1101);
            buttonCancel.Margin = new Padding(4, 4, 4, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(163, 44);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(1720, 1101);
            buttonAdd.Margin = new Padding(4, 4, 4, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(163, 44);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += button2_Click;
            // 
            // AddKomponenForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1170);
            Controls.Add(buttonAdd);
            Controls.Add(buttonCancel);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AddKomponenForm";
            Text = "AddKomponenForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Button buttonCancel;
        private Button buttonAdd;
    }
}