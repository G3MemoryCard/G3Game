using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaame
{
    class HighScore
    {
        static string Filename = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "MemoryHighScore.txt");

        public static class HighScoreList
        {
            //generic playerlist name.
            public static List<Player> list { get; set; }
            //Method for create a new playlist.
            static HighScoreList()
            {
                list = new List<Player>();
            }
            //To record the value for the new players.
            public static void Record(Player value)
            {
                list.Add(value);
            }
        }
        public static class NewHighScoreList
        {
            //generic playerlist name.
            public static List<Player> list { get; set; }
            //Method for create a new playlist.
            static NewHighScoreList()
            {
                list = new List<Player>();
            }
            //To record the value for the new players.
            public static void Record(Player value)
            {
                list.Add(value);
            }
        }
            public void highscore()
            {
                HighScoreList.list.AddRange(WinnerList.list);

                var top10 = from hs in HighScoreList.list
                            orderby hs.Score descending
                            select hs;
                foreach (Player p in top10)
                    NewHighScoreList.Record(p);

                int i = 0;
                using (var sw = new System.IO.StreamWriter(Filename))
                {
                    sw.WriteLine("Highscore:");
                    sw.WriteLine();
                    foreach (Player p in NewHighScoreList.list)
                    {
                        sw.WriteLine(i+1+ ". " + NewHighScoreList.list[i].Name + "\t" + NewHighScoreList.list[i].Score + " pts.");
                        i++;
                    }
                    sw.Flush();
                    sw.Close();
                }
            }
        }
    
}
