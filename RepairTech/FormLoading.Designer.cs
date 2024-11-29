namespace PROJECT_PBO
{
    partial class FormLoading
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 23, 80);
            panel1.BackgroundImage = Properties.Resources.Group_341;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(0, 646);
            panel1.MaximumSize = new Size(1237, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(17, 30);
            panel1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FormLoading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Frame_12;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1237, 676);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLoading";
            Text = "FormLoading";
            Load += FormLoading_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}