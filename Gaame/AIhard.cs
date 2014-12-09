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

        public static void PlayAI(GameBoard board)
        {
            CheckifSafe();
            RndOne();

            Board = board;

            if (CheckCardList() == true)
                Card1.Pic_Click(null, EventArgs.Empty);
            else
            {
                CheckifSafe();
                RndOne();
                Card1.Pic_Click(null, EventArgs.Empty);
            }
            Console.WriteLine(PickOne + "=" + Card1.Tag);
            Board.timeLeftCard = 2;
            board.timer5.Start();

        }
        public static void NextCard()
        {

            if(CheckCardListCARD2() == true)
            Card2.Pic_Click(null, EventArgs.Empty);
            else
            {
                CheckifSafe();
                RndOne();
                Card2.Pic_Click(null, EventArgs.Empty);
            }
            Console.WriteLine(PickOne + "=" + Card2.Tag);
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
            RememberTag.list.Add(Card);
        }

        public static class RememberTag
        {
            public static List<PlayCard> list { get; set; }
        }

        public static bool CheckCardList()
        {
            foreach (PlayCard Card in RememberTag.list)
                foreach (PlayCard Carrd in RememberTag.list)
                    if (Card.Tag == Carrd.Tag && Card != Carrd && Card.Pic.Visible == true)
                    {
                        Card1 = Card;
                        Card2 = Carrd;
                        return true;
                    }
                    else
                    {
                        Card1 = CARDLIST.list[PickOne];
                        return false;
                    }
            return false;
        }


        public static bool CheckCardListCARD2()
        {
            foreach (PlayCard Card in RememberTag.list)
                foreach (PlayCard Carrd in RememberTag.list)
                    if (Card1.Tag == Carrd.Tag && Card != Carrd && Card.Pic.Visible == true)
                    {
                        Card2 = Carrd;
                        return true;
                    }
                    else
                    {
                        Card2 = CARDLIST.list[PickOne];
                        return false;
                    }
            return false;
        }
    }
}
