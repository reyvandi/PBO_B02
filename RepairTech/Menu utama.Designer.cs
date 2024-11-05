namespace PROJECT_PBO
{
    partial class Menu_utama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disprosed; otherwise, false.</param>
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
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 31);
            button1.Name = "button1";
            button1.Size = new Size(236, 76);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Magenta;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 703);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 163);
            label1.Name = "label1";
            label1.Size = new Size(56, 30);
            label1.TabIndex = 1;
            label1.Text = "Fitur";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 228);
            button2.Name = "button2";
            button2.Size = new Size(237, 39);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 273);
            button3.Name = "button3";
            button3.Size = new Size(237, 39);
            button3.TabIndex = 9;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 318);
            button4.Name = "button4";
            button4.Size = new Size(237, 39);
            button4.TabIndex = 9;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(11, 363);
            button5.Name = "button5";
            button5.Size = new Size(237, 39);
            button5.TabIndex = 9;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(11, 651);
            button6.Name = "button6";
            button6.Size = new Size(237, 39);
            button6.TabIndex = 9;
            button6.UseVisualStyleBackColor = true;
            // 
            // Menu_utama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1099, 747);
            Controls.Add(panel1);
            Name = "Menu_utama";
            Text = "Menu_utama";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button4;
        private Button button6;
        private Panel panel1;
        private Label label1;
        private Button button5;
        private Button button3;
    }
}