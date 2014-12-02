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
            StartScreen nrm = new StartScreen();
            string name;
            bool ai = true;
            int skill = 0;
            name = textBox1.Text.ToString();
            //ai = 
            //skill = 

            PlayerList.Record(new Player(name, ai, skill));
            nrm.DoitAll();
            this.Close();
        }
    }
}
