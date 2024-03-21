namespace DinazorOyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            dinozor = new PictureBox();
            label1 = new Label();
            lbl_skor = new Label();
            ((System.ComponentModel.ISupportInitialize)dinozor).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 32;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 17;
            timer2.Tick += timer2_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 482);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 55);
            panel1.TabIndex = 1;
            // 
            // dinozor
            // 
            dinozor.BackgroundImageLayout = ImageLayout.Stretch;
            dinozor.Location = new Point(151, 411);
            dinozor.Name = "dinozor";
            dinozor.Size = new Size(69, 71);
            dinozor.SizeMode = PictureBoxSizeMode.StretchImage;
            dinozor.TabIndex = 3;
            dinozor.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(21, 25);
            label1.Name = "label1";
            label1.Size = new Size(53, 24);
            label1.TabIndex = 4;
            label1.Text = "Skor";
            // 
            // lbl_skor
            // 
            lbl_skor.AutoSize = true;
            lbl_skor.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_skor.Location = new Point(73, 25);
            lbl_skor.Name = "lbl_skor";
            lbl_skor.Size = new Size(32, 24);
            lbl_skor.TabIndex = 5;
            lbl_skor.Text = "00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(910, 537);
            Controls.Add(lbl_skor);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(dinozor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dinozor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Panel panel1;
        private PictureBox dinozor;
        private Label label1;
        private Label lbl_skor;
    }
}
