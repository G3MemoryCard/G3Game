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
    public partial class Scoreboard : Form
    {
        public Scoreboard()
        {
            InitializeComponent();
        }

        private void Scoreboard_Load(object sender, EventArgs e)
        {
            // Sets columns to the listview and adds results from WinnerList
            listView1.View = View.Details;

            listView1.Columns.Add("PLAYER", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("SCORE", 100, HorizontalAlignment.Left);

            for (int i = 0; i < WinnerList.list.Count; i++)
            {
                listView1.Items.Add(WinnerList.list[i].Name.ToString());
                listView1.Items[i].SubItems.Add(WinnerList.list[i].Score.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
