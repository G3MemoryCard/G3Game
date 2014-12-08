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

        public void highscore()
        {
            using (var sw = new System.IO.StreamWriter(Filename, true))
            {
                sw.WriteLine("Highscore:");
                sw.Flush();
                sw.Close();
            }
        }
    }
}
