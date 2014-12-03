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
    
    public partial class StartScreen : Form
    {
        //Number in the index for playerlist.
        public int count = 0;
        string Say;
        string SaySkill;

        public StartScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveGameSettings.Pairs = int.Parse(textBoxPairs.Text);
            SaveGameSettings.Theme = comboBoxTheme.Text;
            SaveGameSettings.Deck = comboBoxDecks.Text;
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
            //Change the view of ListView to Details.
            listView1.View = View.Details; 
            
            //Adding 3 Columns to ListView1.
            listView1.Columns.Add("PLAYER", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("AI", 40, HorizontalAlignment.Left);
            listView1.Columns.Add("SKILL", 50, HorizontalAlignment.Left);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Creating a instance to AddPlayer and starts it in a Dialog Form.
            AddPlayer ad = new AddPlayer();
            ad.ShowDialog();

            //Check if AI is true or false.
            if (PlayerList.list.Count > count && PlayerList.list[count] != null)
            {
                if (PlayerList.list[count].AI == true)
                    Say = "YES";
                else if (PlayerList.list[count].AI == false)
                    Say = "NO";
                else
                    Say = null;

                if (PlayerList.list[count].Skill == 1)
                    SaySkill = "EASY";
                else if (PlayerList.list[count].Skill == 2)
                    SaySkill = "HARD";
                else
                    SaySkill = null;

                //Add from playerlist to the listview1 and subitems for each player.
                listView1.Items.Add(PlayerList.list[count].Name.ToString());
                listView1.Items[count].SubItems.Add(Say);
                listView1.Items[count].SubItems.Add(SaySkill);
                //Add count for what player from playerlist would be added next.
                count++;
            }
                
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (listView1.SelectedItems[null] != null)
            {
                //Remove listview1 index number from the playerlist.
                PlayerList.list.RemoveAt(listView1.SelectedItems[0].Index);
                //Remove selected item from listview1.
                listView1.SelectedItems[0].Remove();
                //Remove one from count.
                count--;
            }
        }
    }

    public static class SaveGameSettings
    {
         public static int Pairs { get; set; }
         public static string Theme { get; set; }
         public static string Deck { get; set; }
         public static int Timer { get; set; }
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
