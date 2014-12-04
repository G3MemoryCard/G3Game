using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaame
{
    public static class FunkcheckAdd
    {

        public static bool Checkpic()
        {
            int[] Cards = CardList.SearchForPairs();

            if (Cards[0] == Cards[1]) return true;
            
            return false;
        }

        public static void AddScore(int player, int PairCount)
        {
            int playerScore = PlayerList.list[player].Score; //Check the score for the current player.
            int score = 5; //Points for a pair.
            score = score * PairCount; //Calculate the combo for pairs.
            playerScore = score + playerScore; //Add playerscore to the new score.
            PlayerList.list[player].Score = playerScore; //Put back the score to the player.
        }
    }
}
