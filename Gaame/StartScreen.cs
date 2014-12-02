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
                MessageBox.Show("Please enter only numbers.");
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
                MessageBox.Show("Please enter only numbers.");
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
                MessageBox.Show("Round timer cannot be set lower than 1.");
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
}
