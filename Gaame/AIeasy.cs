using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaame
{
    public static class AIeasy
    {
        static Random rdn = new Random();
        public static GameBoard Board { get; set; }
        static int PickOne;
        static int PickTwo;

        public static void PlayAI(GameBoard board)
        {
            Board = board;

            RndOne();
            RndTwo();


            while (CardList.Cards[PickOne].Pic.Visible == false || CardList.Cards[PickTwo].Pic.Visible == false)
            {
                if (CardList.Cards[PickOne].Turned == false && CardList.Cards[PickOne].Pic.Visible == false)
                    RndOne();
                if (CardList.Cards[PickTwo].Turned == false && CardList.Cards[PickTwo].Pic.Visible == false)
                    RndTwo();
            }

            while (CardList.Cards[PickTwo].Pic.Visible == false || CardList.Cards[PickOne].Pic.Visible == false)
            {
                if (CardList.Cards[PickTwo].Turned == false && CardList.Cards[PickTwo].Pic.Visible == false)
                    RndTwo();
                if (CardList.Cards[PickOne].Turned == false && CardList.Cards[PickOne].Pic.Visible == false)
                    RndOne();
            }

            while (PickOne == PickTwo)
            {
                RndOne();
                if (CardList.Cards[PickOne].Pic.Visible == false && CardList.Cards[PickOne].Turned == true && PickOne == PickTwo)
                    RndOne();

                RndTwo();
                if (CardList.Cards[PickTwo].Pic.Visible == false && CardList.Cards[PickTwo].Turned == true && PickTwo == PickOne)
                    RndTwo();
            }

            Console.WriteLine(GameMaster.ActivePlayerIndex + " PickOne = " + PickOne);
            Console.WriteLine(GameMaster.ActivePlayerIndex + " PickTwo = " + PickTwo);

            CardList.Cards[PickOne].Pic_Click(null, EventArgs.Empty);
            Board.timeLeftCard = 2;
            board.timer4.Start();

        }
        public static void NextCard()
        {
            CardList.Cards[PickTwo].Pic_Click(null, EventArgs.Empty);
        }

        static void Pic_Click(object sender, EventArgs e)
        {

        }

        public static void RndOne()
        {

            int cardCount = CardList.Cards.Count() - 1;
            PickOne = rdn.Next(0, cardCount);
        }
        public static void RndTwo()
        {
            int cardCount = CardList.Cards.Count() - 1;
            PickTwo = rdn.Next(0, cardCount);
        }




        public class IfVisable
        {
            
            public IfVisable(bool Visable, int CardTag)
            {
                this.CardTag = CardTag;
                this.Visable = Visable;
            }

            public bool Visable { get; set; }
            public int CardTag { get; set; }
        }

        public static class CardVisableList
        {
            
            public static List<IfVisable> list { get; set; }
            
            static CardVisableList()
            {
                list = new List<IfVisable>();
            }
            
            public static void Record(IfVisable value)
            {
                list.Add(value);
            }
        }
    }
}
