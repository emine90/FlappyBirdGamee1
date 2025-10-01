using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdGamee
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) {
                gravity = -10;
               
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }


        }
        private void endGame()
        {
            timer1.Stop();
            skor.Text += " Oyun Bitti!!!";
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            kus.Top += gravity;
            altBoru.Left -= pipeSpeed;

            ustBoru.Left -= pipeSpeed;
            skor.Text = "Skor: " + score;

            if (altBoru.Left < -150)
            {
                altBoru.Left = 800;
                score++;
            }
            if (ustBoru.Left < -180)
            {
                ustBoru.Left = 950;
                score++;
            }
            if (kus.Bounds.IntersectsWith(altBoru.Bounds) ||
                kus.Bounds.IntersectsWith(ustBoru.Bounds) ||
                kus.Bounds.IntersectsWith(yer.Bounds) ||
                kus.Top < -25)
            {
                endGame();
            }
            if (score > 5)
            {
                pipeSpeed = 15;
            }

        }

        private void ustBoru_Click(object sender, EventArgs e)
        {

        }
    }
}
