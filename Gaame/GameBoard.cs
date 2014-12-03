using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaame
{
    public partial class GameBoard : Form
    {
        int timeLeft; // parameter used for the timer.
        bool turnstate = false;

        public GameBoard()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EndScreen frm3 = new EndScreen();
            frm3.ShowDialog();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (turnstate == false)
            {
                (sender as PictureBox).Image = Properties.Resources.Youtube;
                turnstate = true;
            }
            else
            {
                (sender as PictureBox).Image = Properties.Resources.CardBackGoldBlue;
                turnstate = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (turnstate == false)
            {
                (sender as PictureBox).Image = Properties.Resources.Firefox;
                turnstate = true;
            }
            else
            {
                (sender as PictureBox).Image = Properties.Resources.CardBackGoldBlue;
                turnstate = false;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (turnstate == false)
            {
                (sender as PictureBox).Image = Properties.Resources.Firefox;
                turnstate = true;
            }
            else
            {
                (sender as PictureBox).Image = Properties.Resources.CardBackGoldBlue;
                turnstate = false;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (turnstate == false)
            {
                (sender as PictureBox).Image = Properties.Resources.Youtube;
                turnstate = true;
            }
            else
            {
                (sender as PictureBox).Image = Properties.Resources.CardBackGoldBlue;
                turnstate = false;
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            BoardGeneration.GenerateBoard(10, splitContainer1);
            // Show timer as "selected value" seconds, before countdown begins.
            timeLabel.Text = SaveGameSettings.Timer.ToString() + " seconds";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Button for timer testing.
            timeLeft = SaveGameSettings.Timer;
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (timeLeft > 0)
                // if there's time left reduce time by 1 and update label every sec.
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";

            }
            else
                // If time's up announce by changing label.
            {
                timer1.Stop();
                timeLabel.Text = "Time's up!";
            }
        }
    }
}
