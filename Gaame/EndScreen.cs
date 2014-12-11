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
using System.IO;

namespace Gaame
{
    public partial class EndScreen : Form
    {
        SoundPlayer EndScreenMusic = new SoundPlayer(Properties.Resources.EndScreen);

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
            HighscoreList.list.Clear();
            SortedHighscoreList.list.Clear();
            currentScore.currentHscore.Clear();
            WinnerList.list.Clear();

            StartScreen frm2 = new StartScreen();
            frm2.Show();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HighScore.CreateFolders();

            HighScore.CheckHighscoreExsist();

            if (SaveGameSettings.music == true)
            {
                EndScreenMusic.Play();
            }

            HighScore.SortPlayer();

            if (WinnerList.list.Count > 1)
            {
                Console.WriteLine("not null");
                if (WinnerList.list[0].Score == WinnerList.list[1].Score)
                {
                    labelWinningPlayer.Text = "The game is a draw";
                }
                else
                {
                    // Displays the winner alone on screen.
                    labelWinningPlayer.Text = WinnerList.list[0].Name + " has won with the score of: " + WinnerList.list[0].Score + "!";
                }
            }
            else
            {
                // Displays the winner alone on screen.
                labelWinningPlayer.Text = WinnerList.list[0].Name + " has won with the score of: " + WinnerList.list[0].Score + "!";
            }
            HighScore.PickHighscoreList();
            
        }

        private void btnScrBoard_Click(object sender, EventArgs e)
        {
            Scoreboard scr = new Scoreboard();
            scr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sorted = from s in HighscoreList.list
                          orderby s.Score descending
                          select s;

            foreach (Player p in sorted)
                SortedHighscoreList.Record(p);

            HighscoreWindow hsw = new HighscoreWindow();
            if(SaveGameSettings.GameType == 0)
                hsw.Text = "HighScore Classic";
            else if(SaveGameSettings.GameType == 1)
                hsw.Text = "HighScore Combo";
            hsw.ShowDialog();
            SortedHighscoreList.list.Clear();
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
    public static class HighscoreList
    {
        //generic playerlist name.
        public static List<Player> list { get; set; }
        //Method for create a new playlist.
        static HighscoreList()
        {
            list = new List<Player>();
        }
        //To record the value for the new players.
        public static void Record(Player value)
        {
            list.Add(value);
        }
    }
    public static class SortedHighscoreList
    {
        //generic playerlist name.
        public static List<Player> list { get; set; }
        //Method for create a new playlist.
        static SortedHighscoreList()
        {
            list = new List<Player>();
        }
        //To record the value for the new players.
        public static void Record(Player value)
        {
            list.Add(value);
        }
    }
    public static class currentScore
    {
        public static List<Player> currentHscore { get; set; }

        static currentScore()
        {
            currentHscore = new List<Player>();
        }
        public static void Record(Player value)
        {
            currentHscore.Add(value);
        }
    }
}
