using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaame
{
    class FunkcheckAdd
    {

        public bool Checkpic()
        {
            int[] Cards = CardList.SearchForPairs();

            if(Cards[0] == Cards[1]) return true;
            return false;
        }

        public void AddScore(int player, int PairCount)
        {
            int playerScore = PlayerList.list[player].Score; //Nuvarande poängen
            int score = 5; //Poängen som ska delas ut
            score = score * PairCount; // Score gånger antal par för combo poäng
            playerScore = score + playerScore; // Score + nuvarande score för att få ut den nya poängen.
            PlayerList.list[player].Score = playerScore;
        }
    }
}
