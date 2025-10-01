namespace FlappyBirdGamee
{
    partial class Form1
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
            altBoru = new PictureBox();
            yer = new PictureBox();
            ustBoru = new PictureBox();
            kus = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            skor = new Label();
            ((System.ComponentModel.ISupportInitialize)altBoru).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ustBoru).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kus).BeginInit();
            SuspendLayout();
            // 
            // altBoru
            // 
            altBoru.Image = Properties.Resources.pipe;
            altBoru.Location = new Point(319, 239);
            altBoru.Name = "altBoru";
            altBoru.Size = new Size(87, 159);
            altBoru.SizeMode = PictureBoxSizeMode.StretchImage;
            altBoru.TabIndex = 0;
            altBoru.TabStop = false;
            altBoru.Click += pictureBox1_Click;
            // 
            // yer
            // 
            yer.Image = Properties.Resources.ground;
            yer.Location = new Point(1, 390);
            yer.Name = "yer";
            yer.Size = new Size(796, 62);
            yer.SizeMode = PictureBoxSizeMode.StretchImage;
            yer.TabIndex = 1;
            yer.TabStop = false;
            yer.Click += pictureBox2_Click;
            // 
            // ustBoru
            // 
            ustBoru.Image = Properties.Resources.pipe_down;
            ustBoru.Location = new Point(584, 12);
            ustBoru.Name = "ustBoru";
            ustBoru.Size = new Size(84, 143);
            ustBoru.SizeMode = PictureBoxSizeMode.StretchImage;
            ustBoru.TabIndex = 2;
            ustBoru.TabStop = false;
            ustBoru.Click += ustBoru_Click;
            // 
            // kus
            // 
            kus.Image = Properties.Resources.flappybird;
            kus.Location = new Point(12, 93);
            kus.Name = "kus";
            kus.Size = new Size(77, 62);
            kus.SizeMode = PictureBoxSizeMode.StretchImage;
            kus.TabIndex = 3;
            kus.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += gameTimerEvent;
            // 
            // skor
            // 
            skor.AutoSize = true;
            skor.Location = new Point(36, 403);
            skor.Name = "skor";
            skor.Size = new Size(43, 20);
            skor.TabIndex = 4;
            skor.Text = "skor: ";
            skor.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(skor);
            Controls.Add(kus);
            Controls.Add(ustBoru);
            Controls.Add(yer);
            Controls.Add(altBoru);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)altBoru).EndInit();
            ((System.ComponentModel.ISupportInitialize)yer).EndInit();
            ((System.ComponentModel.ISupportInitialize)ustBoru).EndInit();
            ((System.ComponentModel.ISupportInitialize)kus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox altBoru;
        private PictureBox yer;
        private PictureBox ustBoru;
        private PictureBox kus;
        private System.Windows.Forms.Timer timer1;
        private Label skor;
    }
}