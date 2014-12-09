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

        public static void Start(GameBoard board)
        {
            ActivePlayerIndex = 0;
            PlayerCount = PlayerList.list.Count - 1;
            Board = board;
            FirstTurn = true;
            AIhard.firsttime = true;
            GameSetOver = false;
            NewTurn();

        }

        public static void CardCLicked(PlayCard sender) 
        {
            AIhard.RemeberCard(sender);
            if(FirstTurn)
            {
                FirstTurn = false;
                GameStarted = true;
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

        static void HideClickedCards()
        {
            foreach(PlayCard card in CardList.Cards)
            {
                if(card.Turned)
                {
                    card.Pic.Visible = false;
                }
            }
        }

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
                Board.timeLeftCard = 5;
                Board.timer3.Start();
            }
            else
            {
                PairMultiplier = 0;
                NextPlayer();
                Board.timeLeft = SaveGameSettings.Timer;
                Board.timer1.Start();
                Board.timeLeftCard = 5;
                Board.timer2.Start();
                
            }
            Board.update();
            
        }
        public static void GameOver()
        {
            Board.timer1.Stop();
            EndScreen endS = new EndScreen();
            endS.ShowDialog();
            Board.Hide();
        }

        static void CardClickAllowence(bool set)
        {
            foreach(PlayCard card in CardList.Cards)
            {
                card.AllowedToTurn = set;
            }
        }

        public static void NewTurn()
        {
            if (CheckGameOver() || GameSetOver)
            {
                GameOver();
            }
            else
            {
                CardClickAllowence(true);
                TurnBackCards();
                Board.Namechange(ActivePlayerIndex);
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
        public static void TimerCard()
        {
            NewTurn();
        }
        public static void TimerCardScore()
        {
            HideClickedCards();
            NewTurn();
        }
    }
}


