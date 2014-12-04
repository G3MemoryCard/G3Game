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
        public static int PickedPairs { get; set; }
        public static int PiarMultiplier { get; set; }
        

        public static void Start()
        {
            PlayerCount = PlayerList.list.Count;
            

            //FunkcheckAdd.AddScore(ActivePlayerIndex, Pairs);

    
        }

        public static void TimeOver()
        {

        }
        static void EndTurn(bool playerHasScored)
        {

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
