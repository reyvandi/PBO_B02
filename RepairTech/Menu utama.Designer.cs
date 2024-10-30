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
            button3 = new Button();
            button5 = new Button();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(200, 186);
            button1.Name = "button1";
            button1.Size = new Size(187, 138);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.System;
            button3.Location = new Point(806, 505);
            button3.Name = "button3";
            button3.Size = new Size(187, 138);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(506, 345);
            button5.Name = "button5";
            button5.Size = new Size(187, 138);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.Transparent;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(399, 20);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(323, 57);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "TECH REPAIR";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Magenta;
            panel1.Location = new Point(0, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 28);
            panel1.TabIndex = 7;
            // 
            // Menu_utama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1098, 747);
            Controls.Add(panel1);
            Controls.Add(linkLabel1);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "Menu_utama";
            Text = "Menu_utama";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private LinkLabel linkLabel1;
        private Panel panel1;
    }
}