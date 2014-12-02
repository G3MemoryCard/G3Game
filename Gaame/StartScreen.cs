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
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            // Regex expression to only allow numeric signs to be entered.
            {
                MessageBox.Show("Please enter only numbers.");
                textBox2.Text = "";
            }
            else if(textBox2.Text=="")
            // Accepting an empty field.
            {
                textBox2.Text = "";
            }            
            else if(int.Parse(this.textBox2.Text) > 60)
                // Defaulting to max value if numbers entered exceeds 60.
            {
                textBox2.Text = "60";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
                // Regex expression to only allow numeric signs to be entered.
            {
                MessageBox.Show("Please enter only numbers.");
                textBox3.Text = "";
            }
            else if (textBox3.Text == "")
                // Accepting an empty field.
            {
                textBox3.Text = "";
            }   
            else if (int.Parse(textBox3.Text) < 1)
                // Showing error message if timer is set to 0.
            {
                MessageBox.Show("Round timer cannot be set lower than 1.");
            }
        }   
    }
}
