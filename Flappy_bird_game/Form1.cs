using static System.Formats.Asn1.AsnWriter;
using System;

namespace Flappy_bird_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int gravity = 20;
        int speed = 15;
        Random random = new Random();
        int score = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += gravity;
            pictureBox2.Left -= speed;
            pictureBox3.Left -= speed;
            label1.Text = "your score now is    " + score;
            if (pictureBox2.Left < 2) { pictureBox2.Left = random.Next(850, 950); score++; }
            if (pictureBox3.Left < 2) { pictureBox3.Left = random.Next(850, 950); score++; }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds) || pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds) || pictureBox1.Bottom == 300)
            {
                timer1.Stop();
                label1.Text = "Game over    " + score;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -30;
            }
            if (pictureBox1.Top < 2)
            {
                pictureBox1.Top = 16;
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (timer1.Enabled == false)
                {
                    timer1.Start();
                    score = 0;
                    pictureBox2.Left = random.Next(850, 950);
                    pictureBox3.Left = random.Next(850, 950);
                    pictureBox1.Top = 120;
                }


            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 30;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
