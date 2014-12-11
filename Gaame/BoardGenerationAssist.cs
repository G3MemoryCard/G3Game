using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaame
{
    //A class the provieds an alternative method of calculating the amunt of columns from icnoming pairs
    //to create a board that is allways a rectangle
    public static class BoardGenerationAssist
    {
        static double singles { get; set; }
        static List<SideProx> rectOptions { get; set; }
        static int i { get; set; }
        static double d { get; set; }
        static List<double> prox { get; set; }
        static List<SideProx> resultList { get; set; }
        
        //Gets called to callculate and return the amount of columns from the incoming pairs
        public static int getColumnsFromPairs(int pairs)
        {
            resultList = new List<SideProx>();
            rectOptions = new List<SideProx>();
            singles = pairs * 2;


            //Tries to devide the cards by all numbers from 1-12
            i = 1;
            while(i <= 12)
            {
                //Devides the total amount of cards by the the iterated number between 1-12
                d = singles / i;
                //Checks if the varible d contains any decimals
                //and deciding if the number can be devided and result in a natural number
                if ((d % 1) == 0)
                {
                    rectOptions.Add(new SideProx(i, 0));
                }
                i++;
            }

            //Creates a list where the proximity to a perfect sqaure is calculated and also saves the column count
            foreach (SideProx a in rectOptions)
                a.Prox = Math.Abs(Math.Sqrt(singles) - a.Columns + 1);

            //Sorts the list with poximitys and sorts them where the lowest proximity is at the top
            var spList = from p in rectOptions orderby p.Prox select p;

            //Adds the result of the sorting to a list 
            foreach(SideProx sp in spList)
            {
                resultList.Add(sp);
            }

            //Returns the value of the column count that is sorted to the top by the lowest proximity to a sqaure 
            return resultList[0].Columns;
        }

    }

    //Holds a varible for the columns and proximity to be used in the comparison of alternatives of columns counts
    public class SideProx
    {
        public int Columns { get; set; }
        public double Prox { get; set; }

        public SideProx(int columns, double prox) 
        {
            this.Columns = columns;
            this.Prox = prox;
        }
    }
}
