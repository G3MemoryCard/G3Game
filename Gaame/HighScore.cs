using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gaame
{
    public class HighScore
    {
        public static string Filename = Path.Combine((Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\G3Memory"), "MemoryHighScoreClassicList.txt");
        public static string Filename1 = Path.Combine((Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\G3Memory"), "MemoryHighScoreComboList.txt");
        public string Name { get; set; }
        public int Score { get; set; }

        public HighScore(string data)
        {
            var d = data.Split(' ');

            if (string.IsNullOrEmpty(data) || d.Length < 2)
                throw new ArgumentException("Invalid high score string", "data");

            this.Name = d[0];

            int num;
            if (int.TryParse(d[1], out num))
            {
                this.Score = num;
            }
            else
            {
                throw new ArgumentException("Invalid score", "data");
            }
        }

        public override string ToString()
        {
            return String.Format("{0}\t{1}", this.Name, this.Score);
        }

        public static List<Player> ReadScoresFromFile(string path)

        {
            var pList = new List<Player>();

            if(SaveGameSettings.GameType == 0)
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    try
                    {
                        var hScore = new HighScore(line);
                        pList.Add(new Player(hScore.Name, false, 0, hScore.Score));
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Invalid score at line \"{0}\": {1}", line, ex);
                    }
                }
                reader.Dispose();
            }

            else if(SaveGameSettings.GameType == 1)
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        try
                        {
                            var hScore = new HighScore(line);
                            pList.Add(new Player(hScore.Name, false, 0, hScore.Score));
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine("Invalid score at line \"{0}\": {1}", line, ex);
                        }
                    }
                    reader.Dispose();
                }
            return pList;
        }

        static public void CreateFolders()
        {
            //Variabel for the FolderPath.
            var CreateFolder = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\G3Memory");

            try
            {
                // Determine whether the directory exists. 
                if (Directory.Exists(CreateFolder))
                {
                    Console.WriteLine("That path exists already.");
                    return;
                }
                //Create a Directory.
                Directory.CreateDirectory(CreateFolder);

            }
            //Catches Exceptions.
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
        }
        

        public static void SortPlayer()
        {
            // Sorts the PlayerList and saves the result in WinnerList, ordered by score from high to low.
            var winner = from w in PlayerList.list
                         orderby w.Score descending
                         select w;

            foreach (Player p in winner)
                WinnerList.Record(p);

            if(SaveGameSettings.GameType == 0)
                currentScore.currentHscore = HighScore.ReadScoresFromFile(Filename);

            else if(SaveGameSettings.GameType == 1)
                currentScore.currentHscore = HighScore.ReadScoresFromFile(Filename1);

            var winners = from w in currentScore.currentHscore
                          orderby w.Score descending
                          select w;

            foreach (Player p in winners)
                HighscoreList.Record(p);

            foreach (Player p in winner)
                HighscoreList.Record(p);

        }

        public static void PickHighscoreList()
        {

            if(SaveGameSettings.GameType == 0)
                using (var sw = new StreamWriter(Filename, false))
                {
                    sw.WriteLine("CLASSICHIGHSCORE");
                    for (int i = 0; i < HighscoreList.list.Count; i++)
                    {
                        sw.WriteLine(HighscoreList.list[i].Name.ToString() + " " + HighscoreList.list[i].Score.ToString());
                    }
                    sw.Flush();
                    sw.Close();
                }

            else if(SaveGameSettings.GameType == 1)
                using (var sw = new StreamWriter(Filename1, false))
                {
                    sw.WriteLine("COMBOHIGHSCORE");
                    for (int i = 0; i < HighscoreList.list.Count; i++)
                    {
                        sw.WriteLine(HighscoreList.list[i].Name.ToString() + " " + HighscoreList.list[i].Score.ToString());
                    }
                    sw.Flush();
                    sw.Close();
                }
            
        }

        public static void CheckHighscoreExsist()
        {
            if (SaveGameSettings.GameType == 0)
            using (var sw = new StreamWriter(HighScore.Filename, true))
            {
                sw.WriteLine(" ");
            }
            else if (SaveGameSettings.GameType == 1)
            using (var sw = new StreamWriter(HighScore.Filename1, true))
            {
                sw.WriteLine(" ");
            }
        }



    }
    

}
