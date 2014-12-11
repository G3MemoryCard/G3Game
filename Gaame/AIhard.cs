using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaame
{
    class AIhard
    {
        static Random rdn = new Random();
        public static GameBoard Board { get; set; }
        static int PickOne;
        static PlayCard Card1;
        static PlayCard Card2;
        public static bool firsttime { get; set; }

        public static void PlayAI(GameBoard board)
        {
            CheckifSafe();
            RndOne();

            Board = board;

            if (CheckCardList() == true)
                Card1.TurnUpCard();
            else
            {
                CheckifSafe();
                RndOne();
                Card1.TurnUpCard();
            }
            CARDLIST.list.Clear();
            Board.timeLeftCard = 2;
            board.timer5.Start();

        }
        public static void NextCard()
        {
            CheckifSafe();
            RndOne();

            if (CheckCardListCARD2() == true)
                Card2.TurnUpCard();
            else
            {
                CheckifSafe();
                RndOne();
                Card2.TurnUpCard();
            }
            CARDLIST.list.Clear();
        }

        static void Pic_Click(object sender, EventArgs e)
        {

        }

        public static void RndOne()
        {
            int cardCount = CARDLIST.list.Count();
            PickOne = rdn.Next(0, cardCount);
        }

        public static void CheckifSafe()
        {
            CARDLIST.list = new List<PlayCard>();
            foreach (PlayCard Card in CardList.Cards)
                if (Card.Pic.Visible == true && Card.Turned == false)
                    CARDLIST.list.Add(Card);
        }

        public static class CARDLIST
        {
            public static List<PlayCard> list { get; set; }
        }

        public static void RemeberCard(PlayCard Card)
        {
            if (firsttime)
            {
                RememberTag.list.Clear();
                RememberTag.list.Add(Card);
                firsttime = false;
            }
            else
            {
                foreach (PlayCard listcard in RememberTag.list)
                    if (listcard.ID != Card.ID)
                    {
                        RememberTag.list.Add(Card);
                        break;
                    }
            }
        }

        public static class RememberTag
        {
            public static List<PlayCard> list { get; set; }
        }

        public static bool CheckCardList()
        {
            foreach (PlayCard Card in RememberTag.list)
                foreach (PlayCard Carrd in RememberTag.list)
                    if (Card.Tag == Carrd.Tag && Card.ID != Carrd.ID && Card.Pic.Visible == true)
                    {
                        Card1 = Card;
                        Card2 = Carrd;
                        Console.WriteLine("hej");
                        return true;
                    }

            Card1 = CARDLIST.list[PickOne];
            return false;
        }

        public static bool CheckCardListCARD2()
        {
            //foreach (PlayCard Card in RememberTag.list)
            foreach (PlayCard Carrd in RememberTag.list)
                if (Card1.Tag == Carrd.Tag && Card1.ID != Carrd.ID && Carrd.Pic.Visible == true && Carrd.Turned == false)
                {
                    Card2 = Carrd;
                    Console.WriteLine("hejsan igen");
                    return true;
                }
            

            Card2 = CARDLIST.list[PickOne];
            return false;
        }
    }
}
