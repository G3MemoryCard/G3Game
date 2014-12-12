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
        public static bool GameSetOver { get; set; }
        public static bool GameStarted { get; set; }
        public static bool GameHasEnded { get; set; }

        //Start the gamemaster
        public static void Start(GameBoard board)
        {
            GameHasEnded = false;
            ActivePlayerIndex = 0;
            PlayerCount = PlayerList.list.Count - 1;
            Board = board;
            FirstTurn = true;
            AIhard.firsttime = true;
            GameSetOver = false;
            NewTurn();

        }

        //Cards call this function when clicked
        public static void CardCLicked(PlayCard sender) 
        {
            //Sends the clicked card for the hard ai to rember
            AIhard.RemeberCard(sender);

            if(FirstTurn)
            {
                FirstTurn = false;
                GameStarted = true;
                Board.timeLeft = SaveGameSettings.Timer;
                Board.timer1.Start();
            }
            PickedCardsCount++;

            //When 2 cards have been picked locks cards and ends turn while checking if a pair has been chosen
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

        //Hides pairs that have been picked
        static void HideClickedCards()
        {
            //Each card that is currently turned up becomeds invisable
            foreach(PlayCard card in CardList.Cards)
            {
                if(card.Turned)
                {
                    card.Pic.Visible = false;
                }
            }
        }

        //Checks if all cards are invisable resulting in a game over
        public static bool CheckGameOver()
        {
            foreach(PlayCard card in CardList.Cards)
            {
                if(card.Pic.Visible == true)
                {
                    return false;
                }
            }
            return true;
        }

        // Gets called by a timer that ends the turn
        public static void TimeOver()
        {
            EndTurn(false);
        }

        //Ends the turn and takes a bool that says if the current player has scored
        static void EndTurn(bool playerHasScored)
        {
            if(playerHasScored)
            {
                PairMultiplier++;
                FunkcheckAdd.AddScore(ActivePlayerIndex, PairMultiplier);
                Board.timeLeft = SaveGameSettings.Timer;
                Board.timer1.Start();
                Board.timeLeftCard = 5;
                Board.timer3.Start();
            }
            else
            {
                PickedCardsCount = 0;
                PairMultiplier = 0;
                NextPlayer();
                Board.timeLeft = SaveGameSettings.Timer;
                Board.timer1.Start();
                Board.timeLeftCard = 5;
                Board.timer2.Start();
                
            }
            Board.update();
            
        }

        //Game over stops the game and goes to the end screen
        public static void GameOver()
        {
            if (!GameHasEnded)
            {
                GameHasEnded = true;
                Board.WMPlayer.Ctlcontrols.stop();
                EndScreen endS = new EndScreen();
                Board.timer1.Stop();
                endS.ShowDialog();
                Board.Hide();
                
            }
        }

        //Sets if cards on the board are allowed to be clicked depening on the ingcoming bool
        static void CardClickAllowence(bool set)
        {
            foreach(PlayCard card in CardList.Cards)
            {
                card.AllowedToTurn = set;
            }
        }

        //Starts a new turn
        public static void NewTurn()
        {
            //Checks if the game is over
            if (CheckGameOver() || GameSetOver)
            {
                GameOver();
                Board.timer1.Stop();
            }
            else
            {
                CardClickAllowence(true);
                TurnBackCards();
                Board.Namechange(ActivePlayerIndex);

                //Check if the active player is an AI player and what difficulty if so
                if (PlayerList.list[ActivePlayerIndex].AI == true && PlayerList.list[ActivePlayerIndex].Skill == 1)
                {
                    CardClickAllowence(false);
                    AIeasy.PlayAI(Board);
                }
                else if (PlayerList.list[ActivePlayerIndex].AI == true && PlayerList.list[ActivePlayerIndex].Skill == 2)
                {
                    CardClickAllowence(false);
                    AIhard.PlayAI(Board);
                }
            }

        }

        //Tells each card on the board to turn back
        static void TurnBackCards()
        {
            foreach(PlayCard card in CardList.Cards)
            {
                card.TurnDownCard();
            }
        }

        //Switches to the next player
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

        //Gets called by a timer that starts at the end of the turn to create a paus before each new turn
        public static void TimerCard()
        {
            NewTurn();
        }

        //Same function as the above but gets called by a timer that starts when a player gets a pair
        public static void TimerCardScore()
        {
            HideClickedCards();
            NewTurn();
        }
    }
}


