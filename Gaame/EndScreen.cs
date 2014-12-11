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

        
        string Filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "MemoryHighScore.txt");
             

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
            
            using (var sw = new StreamWriter(Filename, true))
            {
                sw.WriteLine("HighScore! SECRET MESSAGE!");
            }

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
            labelWinningPlayer.Text = WinnerList.list[0].Name + " has won with the score of: " + WinnerList.list[0].Score + "!";

            List<Player> currentHscore = new List<Player>();

            currentHscore = HighScore.ReadScoresFromFile(Filename);



            var winners = from w in currentHscore
                         orderby w.Score descending
                         select w;
            foreach (Player p in winners)
                HighscoreList.Record(p);
            //foreach (Player p in winners)
            //{
            //    MessageBox.Show(nr.ToString() + ". " + p.Name.ToString() + "\t" + p.Score.ToString());
            //    nr++;
            //}

            foreach (Player p in winner)
                HighscoreList.Record(p);


            using (var sw = new StreamWriter(Filename, true))
            {
                
                for (int i = 0; i < HighscoreList.list.Count; i++)
                {
                    sw.WriteLine(HighscoreList.list[i].Name.ToString() + " " + HighscoreList.list[i].Score.ToString());
                }
                sw.Flush();
                sw.Close();
            }
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
            hsw.ShowDialog();

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
}
