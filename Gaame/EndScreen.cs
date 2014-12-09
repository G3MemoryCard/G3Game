using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Gaame
{
    public partial class EndScreen : Form
    {
        SoundPlayer EndScreenMusic = new SoundPlayer(Properties.Resources.EndScreen);
        HighScore hs = new HighScore();

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
            EndScreenMusic.Stop();
            WinnerList.list.Clear();
            StartScreen frm2 = new StartScreen();
            frm2.Show();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (SaveGameSettings.music == true)
            {
                EndScreenMusic.Play();
            }
            // Sorts the PlayerList and saves the result in WinnerList, ordered by score from high to low.
            var winner = from w in PlayerList.list
                         orderby w.Score descending
                         select w;
            foreach (Player p in winner)
                WinnerList.Record(p);

            // Displays the winner alone on screen.
            textBox1.Text = WinnerList.list[0].Name + " has won with the score of: " + WinnerList.list[0].Score + "!";

            hs.highscore();
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
    public static class WinnerList
    {
        //generic playerlist name.
        public static List<Player> list { get; set; }
        //Method for create a new playlist.
        static WinnerList()
        {
            list = new List<Player>();
        }
        //To record the value for the new players.
        public static void Record(Player value)
        {
            list.Add(value);
        }
    }
}
