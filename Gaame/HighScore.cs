﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gaame
{
    public class HighScore
    {
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
    }


}
