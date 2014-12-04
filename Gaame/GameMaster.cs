using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaame
{
    static class GameMaster
    {
        public static int ActivePlayerIndex { get; set; }
        public static int PlayerCount { get; set; }
        public static int PickedPairsCount { get; set; }
        public static int PiarMultiplier { get; set; }
        

        public static void Start()
        {
            PlayerCount = PlayerList.list.Count;
            

            //FunkcheckAdd.AddScore(ActivePlayerIndex, Pairs);

    
        }

        public static void TimeOver()
        {
            EndTurn(false);
        }

        static void EndTurn(bool playerHasScored)
        {
            if(playerHasScored)
            {
                FunkcheckAdd.AddScore(ActivePlayerIndex, PickedPairsCount);
                NewTurn();
            }
            else
            {
                NewTurn();
            }
        }

        static void AllowCards()
        {

        }

        static void NewTurn()
        {

        }

        static void NextPlayer()
        {
            if(ActivePlayerIndex < PlayerCount)
            {
                ActivePlayerIndex++;
            }
            else
            {
                ActivePlayerIndex = 0;
            }
        }
    
        //Active player



        //Check Pic



        //Add Score



        //Tidklocka



        //Next Player






    }
}
