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
    public partial class HighscoreWindow : Form
    {
        public HighscoreWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HighscoreWindow_Load(object sender, EventArgs e)
        {
            // Sets columns to the listview and adds results from WinnerList
            listView1.View = View.Details;

            listView1.Columns.Add("PLAYER", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("SCORE", 100, HorizontalAlignment.Left);

            for (int i = 0; i < 10 && i < SortedHighscoreList.list.Count; i++)
            {
                listView1.Items.Add(i + 1 + ". " + SortedHighscoreList.list[i].Name.ToString());
                listView1.Items[i].SubItems.Add(SortedHighscoreList.list[i].Score.ToString());
            }
        }
    }
}
