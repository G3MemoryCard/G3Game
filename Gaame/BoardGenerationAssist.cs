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

        public static void getColumnsFromPairs(int pairs)
        {
            singles = pairs * 2;

            i = 1;
            while(i <= 12)
            {
                if (((singles / i) % 1) == 0)
                {
                    rectOptions.Add(i);
                }
                i++;
            }

            foreach (int a in rectOptions)
                Console.WriteLine(a);
            
        }

    }
}
