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
    public partial class AddPlayer : Form
    {
        //Variables for what skill the AI should have, if the checkbox is checked or not. 
        int skill = 0;
        bool check = false;
        public AddPlayer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // cancel
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Variables for player name, if it should be a AI.
            string name;
            bool ai = false;
            int score = 0;
            //Type in the player name.
            name = textBox1.Text.ToString();
            //IF is should be a AI
            if (check == true)
                ai = true;
            else if (check == false)
                ai = false;
            
            //What skill the AI should have
            if (check == true & comboBox1.Text.ToString() == "Hard")
                skill = 2;
            else if (check == true & comboBox1.Text.ToString() == "Easy (default)")
                skill = 1;
            else
                skill = 0;
            //Send the variables to the Playerlist.
            PlayerList.Record(new Player(name, ai, skill, score));
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //If the checkbox is checked unlock combobox1. change the state for Check from false <-> ture
            comboBox1.Enabled = checkBox1.Checked;
            check = !check;

        }
        private void AddPlayer_Load(object sender, EventArgs e)
        {
            //Disable combobox1, Add items for the combobox.
            comboBox1.Enabled = false;
            this.comboBox1.Items.Add("Hard");
        }
    }
}
