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
        public static int Pairs { get; set; }
        public static bool AllowTurn { get; set; }

        public static void Start()
        {
            PlayerCount = PlayerList.list.Count;
            AllowTurn = true;

            //FunkcheckAdd.AddScore(ActivePlayerIndex, Pairs);

    
        }
        

        static void NextPlayer()
        {
            if(ActivePlayerIndex < PlayerCount)
            {
                ActivePlayerIndex++;
            }
        }
    
        //Active player



        //Check Pic



        //Add Score



        //Tidklocka



        //Next Player






    }
}
