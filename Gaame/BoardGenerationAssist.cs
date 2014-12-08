using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaame
{
    public static class BoardGenerationAssist
    {
        static double singles { get; set; }
        static List<SideProx> rectOptions { get; set; }
        static int i { get; set; }
        static double d { get; set; }
        static List<double> prox { get; set; }
        static List<SideProx> resultList { get; set; }
        

        public static int getColumnsFromPairs(int pairs)
        {
            resultList = new List<SideProx>();
            rectOptions = new List<SideProx>();
            singles = pairs * 2;



            i = 1;
            while(i <= 12)
            {
                d = singles / i;
                if ((d % 1) == 0)
                {
                    rectOptions.Add(new SideProx(i, 0));
                }
                i++;
            }

            foreach (SideProx a in rectOptions)
                a.Prox = Math.Abs(Math.Sqrt(singles) - a.Side + 1);

            var spList = from p in rectOptions orderby p.Prox select p;

            
            foreach(SideProx sp in spList)
            {
                resultList.Add(sp);
            }

            return resultList[0].Side;
        }

    }
    public class SideProx
    {
        public int Side { get; set; }
        public double Prox { get; set; }

        public SideProx(int side, double prox) 
        {
            this.Side = side;
            this.Prox = prox;
        }
    }
}
