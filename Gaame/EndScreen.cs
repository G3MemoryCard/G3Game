﻿using System;
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
    public partial class EndScreen : Form
    {
        public EndScreen()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)  // Closes the application on click.
        {
            this.Close();
            Application.Exit();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e) // Closes the current window and returns to the start window.
        {
            StartScreen frm2 = new StartScreen();
            frm2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Sort players by current score.
            var winner = from w in PlayerList.list
                         orderby w.Score descending
                         select w;

            // Display the player with the highest score in a textbox.
            textBox1.Text = PlayerList.list[0].Name.ToString() 
                         + " has won with a score of " 
                         + PlayerList.list[0].Score.ToString() 
                         + "!";
        }

        private void labelPlayer_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnScrBoard_Click(object sender, EventArgs e)
        {
            Scoreboard scr = new Scoreboard();
            scr.ShowDialog();
        }
    }
}
