using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaame
{
    public static class AIeasy
    {
        static int PickOne;
        static int PickTwo;

        public static void PlayAI()
        {
            do
            {
                Rnd();
            } while (PickOne == PickTwo);
            Console.WriteLine(PickOne);
            Console.WriteLine(PickTwo);
            CardList.Cards[PickOne].Pic_Click(null, EventArgs.Empty);
            CardList.Cards[PickTwo].Pic_Click(null, EventArgs.Empty);
                //SPELA
            
        }

        static void Pic_Click(object sender, EventArgs e)
        {
              
        }

        public static void Rnd()
        {
            Random rdn = new Random();
            int cardCount = CardList.Cards.Count() - 1;
            PickOne = rdn.Next(0, cardCount);
            PickTwo = rdn.Next(0, cardCount);
        }

    }
}
