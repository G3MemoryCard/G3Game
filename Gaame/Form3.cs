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
    public partial class Form3 : Form
    {
        bool turnstate = false;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 frm3 = new Form1();
            frm3.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (turnstate == false)
            {
                (sender as PictureBox).Image = Properties.Resources.Youtube;
                turnstate = true;
            }
            else
            {
                (sender as PictureBox).Image = Properties.Resources.Backside1;
                turnstate = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (turnstate == false)
            {
                (sender as PictureBox).Image = Properties.Resources.Firefox;
                turnstate = true;
            }
            else
            {
                (sender as PictureBox).Image = Properties.Resources.Backside1;
                turnstate = false;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (turnstate == false)
            {
                (sender as PictureBox).Image = Properties.Resources.Firefox;
                turnstate = true;
            }
            else
            {
                (sender as PictureBox).Image = Properties.Resources.Backside1;
                turnstate = false;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (turnstate == false)
            {
                (sender as PictureBox).Image = Properties.Resources.Youtube;
                turnstate = true;
            }
            else
            {
                (sender as PictureBox).Image = Properties.Resources.Backside1;
                turnstate = false;
            }
        }
    }
}
