using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaame
{
    public static class BoardGenerationAssist
    {
        static int singles { get; set; }
        static List<int> rectOptions { get; set; }
        static int i { get; set; }
        static decimal d { get; set; }

        public static void getColumnsFromPairs(int pairs)
        {
            rectOptions = new List<int>();
            singles = pairs * 2;

            i = 1;
            while(i <= 12)
            {
                d = singles / i;
                if ((d % 1) == 0)
                {
                    Console.WriteLine(d);
                    rectOptions.Add(i);
                }
                i++;
            }

            //foreach (int a in rectOptions)
                
            
        }

    }
}
