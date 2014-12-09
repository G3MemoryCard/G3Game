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
    public partial class GameBoard : Form
    {
        public int timeLeft = SaveGameSettings.Timer; // parameter used for the timer.
        public int timeLeftCard = 5;
        SoundPlayer GBMusic = new SoundPlayer(Properties.Resources.GameBoardTheme);

        public GameBoard()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (GameMaster.GameStarted == true)
            GameMaster.GameSetOver = true;
            else
            GameMaster.GameOver();
        }


        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            AIhard.RememberTag.list = new List<PlayCard>();
            ThemeArrays.Create();
            PlayCard[] CardArray = BoardGeneration.GenerateBoard(SaveGameSettings.Pairs * 2, splitContainer1);
            CardList.Create(CardArray);
            GameMaster.Start(this);

            // Background depending on chosen theme.
            if (SaveGameSettings.ThemeBg == 0)
            {
                splitContainer1.Panel1.BackgroundImage = Properties.Resources.bg_hi_tech_2;
            }

            else if (SaveGameSettings.ThemeBg == 1)
            {
                splitContainer1.Panel1.BackgroundImage = Properties.Resources.bg_myLittlePony;
            }

            else if (SaveGameSettings.ThemeBg == 2)
            {
                splitContainer1.Panel1.BackgroundImage = Properties.Resources.bg_worldmap_2;
            }
            

            // Show timer as "selected value" seconds, before countdown begins.
            timeLabel.Text = SaveGameSettings.Timer.ToString() + " seconds";

            listView1.View = View.Details;
            
            listView1.Columns.Add("PLAYER", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("SCORE", 100, HorizontalAlignment.Left);

            for (int i = 0; i < PlayerList.list.Count; i++)
            {
                listView1.Items.Add(PlayerList.list[i].Name.ToString());
                listView1.Items[i].SubItems.Add(PlayerList.list[i].Score.ToString());
            }
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
                GameMaster.TimeOver();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void update()
        {
            this.listView1.Items.Clear();
            for (int i = 0; i < PlayerList.list.Count; i++)
            {
                listView1.Items.Add(PlayerList.list[i].Name.ToString());
                listView1.Items[i].SubItems.Add(PlayerList.list[i].Score.ToString());
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timeLeftCard > 0)
            // if there's time left reduce time by 1 and update label every sec.
            {
                timeLeftCard = timeLeftCard - 1;

            }
            else
            // If time's up announce by changing label.
            {
                timer2.Stop();
                GameMaster.TimerCard();
            }

        }
        
        public void Namechange(int player)
        {
            label1.Text = PlayerList.list[player].Name.ToString();
            label2.Text = "Current Player: ";

        }
        private void timer3_Tick_1(object sender, EventArgs e)
        {
            if (timeLeftCard > 0)
            // if there's time left reduce time by 1 and update label every sec.
            {
                timeLeftCard = timeLeftCard - 1;
            }
            else
            // If time's up announce by changing label.
            {
                timer3.Stop();
                GameMaster.TimerCardScore();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (timeLeftCard > 0)
            // if there's time left reduce time by 1 and update label every sec.
            {
                timeLeftCard = timeLeftCard - 1;
            }
            else
            // If time's up announce by changing label.
            {
                timer4.Stop();
                AIeasy.NextCard();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (timeLeftCard > 0)
            // if there's time left reduce time by 1 and update label every sec.
            {
                timeLeftCard = timeLeftCard - 1;
            }
            else
            // If time's up announce by changing label.
            {
                timer5.Stop();
                AIhard.NextCard();
            }
        }

        private void checkBoxMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMusic.Checked)
            {
                SaveGameSettings.GBmusic = true;
                SaveGameSettings.music = true;
                GBMusic.Play();
            }
            else
            {
                SaveGameSettings.GBmusic = false;
                GBMusic.Stop();
            }
        }

        private void checkBoxSFX_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSFX.Checked)
            {
                SaveGameSettings.sfx = true;
            }

            else
            {
                SaveGameSettings.sfx = false;
            }
        }

        }
    }
