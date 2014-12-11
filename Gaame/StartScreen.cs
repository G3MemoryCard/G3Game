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
    
    public partial class StartScreen : Form
    {
        //Number in the index for playerlist.
        SoundPlayer IntroMusic = new SoundPlayer(Properties.Resources.Intro);
        string Say;
        string SaySkill;

        public StartScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                SaveGameSettings.Pairs = int.Parse(textBoxPairs.Text);
                IntroMusic.Stop();

                if (comboBoxTheme.Text == "Social Icons")
                {
                    SaveGameSettings.Theme = 0;
                    SaveGameSettings.ThemeBg = 0;
                }
                    
                else if (comboBoxTheme.Text == "Smileys")
                {
                    SaveGameSettings.Theme = 1;
                    SaveGameSettings.ThemeBg = 1;
                }
                else if (comboBoxTheme.Text == "Flags")
                {
                    SaveGameSettings.Theme = 2;
                    SaveGameSettings.ThemeBg = 2;
                }

                if(comboBoxDecks.Text == "Theme")
                {
                    if (comboBoxTheme.Text == "Social Icons")
                        SaveGameSettings.Deck = 5;
                    else if (comboBoxTheme.Text == "Smileys")
                        SaveGameSettings.Deck = 6;
                    else if (comboBoxTheme.Text == "Flags")
                        SaveGameSettings.Deck = 7;
                }
                else if (comboBoxDecks.Text == "Gold & Blue")
                    SaveGameSettings.Deck = 0;
                else if (comboBoxDecks.Text == "Gold & Grey")
                    SaveGameSettings.Deck = 1;
                else if (comboBoxDecks.Text == "Black & Orange")
                    SaveGameSettings.Deck = 2;
                else if (comboBoxDecks.Text == "Brown & Beige")
                    SaveGameSettings.Deck = 3;
                else if (comboBoxDecks.Text == "Gold & Purple")
                    SaveGameSettings.Deck = 4;
                if (comboBoxGameType.Text == "Classic")
                    SaveGameSettings.GameType = 0;
                else if (comboBoxGameType.Text == "ComboScore")
                    SaveGameSettings.GameType = 1;

                SaveGameSettings.Timer = int.Parse(textBoxTimer.Text);
                GameBoard frm = new GameBoard();    //New variable for Form3 aka. Gameboard.
                frm.Show();                 //For frm to show.
                this.Hide();                //Hide the startmenu.
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxPairs.Text, "[^0-9]"))
            // Regex expression to only allow numeric signs to be entered.
            {
                //MessageBox.Show("Please enter only numbers.");
                textBoxPairs.Text = "";
            }
            else if(textBoxPairs.Text=="")
            // Accepting an empty field.
            {
                textBoxPairs.Text = "";
            }            
            else if(int.Parse(this.textBoxPairs.Text) > 60)
                // Defaulting to max value if numbers entered exceeds 60.
            {
                textBoxPairs.Text = "60";
            }
            else if (int.Parse(this.textBoxPairs.Text) == 0)
            {
                textBoxPairs.Text = "1";
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxTimer.Text, "[^0-9]"))
                // Regex expression to only allow numeric signs to be entered.
            {
                //MessageBox.Show("Please enter only numbers.");
                textBoxTimer.Text = "";
            }
            else if (textBoxTimer.Text == "")
                // Accepting an empty field.
            {
                textBoxTimer.Text = "";
            }   
            else if (int.Parse(textBoxTimer.Text) < 1)
                // Showing error message if timer is set to 0.
            {
                textBoxTimer.Text = "1";
            }
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {

            if (checkBoxMusic.Checked)
            {
                IntroMusic.Play();
            }
            checkBoxMusic.Checked = SaveGameSettings.music; // Saves the music settings
            checkBoxSFX.Checked = SaveGameSettings.sfx; // Saves the setings for sound effects

            //Change the view of ListView to Details.
            listView1.View = View.Details; 
            
            //Adding 3 Columns to ListView1.
            listView1.Columns.Add("PLAYER", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("AI", 40, HorizontalAlignment.Left);
            listView1.Columns.Add("SKILL", 50, HorizontalAlignment.Left);

            
                for (int i = 0; i < PlayerList.list.Count; i++)
                {
                    PlayerList.list[i].Score = 0;
                    if (PlayerList.list[i].AI == true)
                        Say = "YES";
                    else if (PlayerList.list[i].AI == false)
                        Say = "NO";
                    else
                        Say = null;

                    if (PlayerList.list[i].Skill == 1)
                        SaySkill = "EASY";
                    else if (PlayerList.list[i].Skill == 2)
                        SaySkill = "HARD";
                    else
                        SaySkill = null;

                    listView1.Items.Add(PlayerList.list[i].Name.ToString());
                    listView1.Items[i].SubItems.Add(Say);
                    listView1.Items[i].SubItems.Add(SaySkill);
                }
                StartButton();
                this.comboBoxTheme.SelectedItem = "Social Icons";
                this.comboBoxDecks.SelectedItem = "Theme";
                this.comboBoxGameType.SelectedItem = "Classic";
                SaveGameSettings.addBot = 0;
                SaveGameSettings.addPlayer = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Creating a instance to AddPlayer and starts it in a Dialog Form.
            AddPlayer ad = new AddPlayer();
            ad.ShowDialog();
            StartButton();
            //Check if AI is true or false.
            if (PlayerList.list.Count > SaveGameSettings.Count && PlayerList.list[SaveGameSettings.Count] != null)
            {
                if (PlayerList.list[SaveGameSettings.Count].AI == true)
                    Say = "YES";
                else if (PlayerList.list[SaveGameSettings.Count].AI == false)
                    Say = "NO";
                else
                    Say = null;

                if (PlayerList.list[SaveGameSettings.Count].Skill == 1)
                    SaySkill = "EASY";
                else if (PlayerList.list[SaveGameSettings.Count].Skill == 2)
                    SaySkill = "HARD";
                else
                    SaySkill = null;

                //Add from playerlist to the listview1 and subitems for each player.
                listView1.Items.Add(PlayerList.list[SaveGameSettings.Count].Name.ToString());
                listView1.Items[SaveGameSettings.Count].SubItems.Add(Say);
                listView1.Items[SaveGameSettings.Count].SubItems.Add(SaySkill);
                //Add count for what player from playerlist would be added next.
                SaveGameSettings.Count++;
            }
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                //Remove listview1 index number from the playerlist.
                PlayerList.list.RemoveAt(listView1.SelectedItems[0].Index);
                //Remove selected item from listview1.
                listView1.SelectedItems[0].Remove();
                //Remove one from count.
               SaveGameSettings.Count--;
               StartButton();
            }
        }
        public void StartButton()
        {
            if (PlayerList.list.Count > 0)
                StartGame.Enabled = true;
            else
                StartGame.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMusic.Checked)
            {
                SaveGameSettings.music = true;
                IntroMusic.Play();
            }
            else
            {
                SaveGameSettings.music = false;
                IntroMusic.Stop();
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

    public static class SaveGameSettings
    {
         public static int Count { get; set; }
         public static int Pairs { get; set; }
         public static int Theme { get; set; }
         public static int Deck { get; set; }
         public static int Timer { get; set; }
         public static int GameType { get; set; }
         public static int addBot { get; set; }
         public static int addPlayer { get; set; }
         public static int ThemeBg { get; set; }
         public static bool sfx { get; set; }
         public static bool music { get; set; }
         public static bool GBmusic { get; set; }
    }

    public class Player
    {
        //Construtor for Playerlist to add players.
        public Player(string Name, bool AI, int Skill, int Score)
        {
            this.Name = Name;
            this.AI = AI;
            this.Skill = Skill;
            this.Score = Score;
        }
        //Varibals for the Playerlist.
        public string Name { get; set; }
        public bool AI { get; set; }
        public int Skill { get; set; }
        public int Score { get; set; }
    }

    public static class PlayerList
    {
        //generic playerlist name.
        public static List<Player> list { get; set; }
        //Method for create a new playlist.
        static PlayerList()
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
