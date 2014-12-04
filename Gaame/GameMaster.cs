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
        public static int PickedCardsCount { get; set; }
        public static int PairMultiplier { get; set; }
        public static GameBoard Board { get; set; }
        static bool FirstTurn { get; set; }

        public static void Start(GameBoard board)
        {
            PlayerCount = PlayerList.list.Count - 1;
            Board = board;
            FirstTurn = true;
            NewTurn();

        }

        public static void CardCLicked() 
        {
            if(FirstTurn)
            {
                FirstTurn = false;
                Board.timeLeft = SaveGameSettings.Timer;
                Board.timer1.Start();
            }
            PickedCardsCount++;
            if(PickedCardsCount == 2)
            {
                CardClickAllowence(false);
                PickedCardsCount = 0;
                if(FunkcheckAdd.Checkpic())
                {
                    EndTurn(true);
                }
                else
                {
                    EndTurn(false);
                }
            }
                
        }

        public static void TimeOver()
        {
            EndTurn(false);
        }

        static void EndTurn(bool playerHasScored)
        {
            if(playerHasScored)
            {
                PairMultiplier++;
                FunkcheckAdd.AddScore(ActivePlayerIndex, PairMultiplier);
                Board.timeLeft = SaveGameSettings.Timer;
                Board.timer1.Start();
                NewTurn();
                
            }
            else
            {
                PairMultiplier = 0;
                NextPlayer();
                Board.timeLeft = SaveGameSettings.Timer;
                Board.timer1.Start();
                NewTurn();
                
            }
            Board.update();
        }

        static void CardClickAllowence(bool set)
        {
            foreach(PlayCard card in CardList.Cards)
            {
                card.AllowedToTurn = set;
            }
        }

        static void NewTurn()
        {
            CardClickAllowence(true);
            TurnBackCards();
            

        }

        static void TurnBackCards()
        {
            foreach(PlayCard card in CardList.Cards)
            {
                card.TurnDownCard();
            }
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
