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
        int skill = 0;
        int check;
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
            string name;
            bool ai;
            name = textBox1.Text.ToString();

            if (check == 1)
                ai = true;
            else if (check == 0)
                ai = false;
            

            if (ai = true & comboBox1.Text.ToString() == "Easy")
                skill = 1;
            else if (ai = true & comboBox1.Text.ToString() == "Hard")
                skill = 2;
            else
                skill = 0;

            PlayerList.Record(new Player(name, ai, skill));
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = checkBox1.Checked;
            if (checkBox1.Checked == true)
                check = 1;
            else
                check = 0;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AddPlayer_Load(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            this.comboBox1.Items.Add("Easy");
            this.comboBox1.Items.Add("Hard");
        }
    }
}
