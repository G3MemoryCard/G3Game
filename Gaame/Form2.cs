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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();    //New varibel for Form3 aka. Gameboard.'
            frm.Show();                 //For frm to show.
            this.Hide();                //Hide the startmeny
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                //textBox2.Text.Remove(textBox2.Text.Length - 1);
                textBox2.Text = "";
            }
            else if(textBox2.Text=="")
            {
                textBox2.Text = "";
            }            
            else if(int.Parse(this.textBox2.Text) > 60)
            {
                textBox2.Text = "60";
            }
        }   
    }
}
