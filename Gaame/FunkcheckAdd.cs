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

            //if(Picturbox[0].image.tag == Picturbox[1].image.tag) return true;
            return false;
        }

        public void AddScore(string player, int PairCount)
        {
            //List Heloo = new List<string, int>();
            //heloo<player, playerscore>
            int playerScore = 0; //Nuvarande poängen
            int score = 5; //Poängen som ska delas ut
            score = score * PairCount; // Score gånger antal par för combo poäng
            playerScore = score + playerScore; // Score + nuvarande score för att få ut den nya poängen.
            //lägg till poängen i listan under "player, int".
        }
    }
}
