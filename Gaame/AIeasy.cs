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

        public static void PlayAI(GameBoard board)
        {
            CheckifSafe();
            Board = board;

            RndOne();

            CARDFUCINGLIST.list[PickOne].Pic_Click(null, EventArgs.Empty);
            CheckifSafe();
            RndOne();

            Console.WriteLine(GameMaster.ActivePlayerIndex + " PickOne = " + PickOne);

            Board.timeLeftCard = 2;
            board.timer4.Start();

        }
        public static void NextCard()
        {
            CARDFUCINGLIST.list[PickOne].Pic_Click(null, EventArgs.Empty);
            CARDFUCINGLIST.list.Clear();
        }

        static void Pic_Click(object sender, EventArgs e)
        {

        }

        public static void RndOne()
        {
            int cardCount = CARDFUCINGLIST.list.Count();
            PickOne = rdn.Next(0, cardCount);
        }

        public static void CheckifSafe()
        {
            CARDFUCINGLIST.list = new List<PlayCard>();
            foreach (PlayCard Card in CardList.Cards)
                if (Card.Pic.Visible == true && Card.Turned == false)
                    CARDFUCINGLIST.list.Add(Card);
        }

        public static class CARDFUCINGLIST
        {
            public static List<PlayCard> list { get; set; }
        }
    }
}
