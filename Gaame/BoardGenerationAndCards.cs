using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaame
{
    public static class BoardGeneration
    {
        //Shuffles list
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            Random rnd = new Random();
            while (n > 1)
            {
                int k = (rnd.Next(0, n) % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        //Generate tag list with two of each tag
        static List<int> GenerateTags(int pairs)
        {
            List<int> tagList = new List<int>();
            int i = 0;
            while (i < pairs)
            {
                tagList.Add(i);
                tagList.Add(i);
                i++;
            }
            Shuffle<int>(tagList);
            foreach (int a in tagList)
                Console.WriteLine(a);
            return tagList;
        }

        //Remove item from the refered list at the index
        static void RemoveFromListAtIndex(ref List<int> list, int index)
        {
            list.RemoveAt(index);
        }

        //Generates the board and returns an array of playcards
        public static PlayCard[] GenerateBoard(int x, SplitContainer container)
        {
            int maxBoardSize = 500;
            int cardMaxSize = 100;
            int margin = 10;

            int colums = 0;
            int rowNr = 0;
            int columNr = 0;

            Point generateStartPoint = new Point(10, 50);

            //Find a apropiate number of colums to create a field as square as possible
            colums = Convert.ToInt32(Math.Ceiling(Math.Sqrt(x)));

            //Calculate the card size depending on the max board size and the amount of columns
            //Then restrict the cards max size
            int cardSize = maxBoardSize / colums;
            if (cardSize > cardMaxSize)
            {
                cardSize = cardMaxSize;
            }

            //Generate tag list
            List<int> tagList = GenerateTags(x / 2);

            //Generate pictures
            PlayCard[] Cards = new PlayCard[x];
            int i = 0;
            while (i < x)
            {
                //If the end of the column count has been reached move down 1 row and reset colum counter
                if (columNr >= colums)
                {
                    rowNr++;
                    columNr = 0;
                }

                //Properties and deployment of picturebox
                PictureBox pic1 = new PictureBox();

                pic1.Location = new Point(generateStartPoint.X + columNr * (cardSize + margin), generateStartPoint.Y + rowNr * (cardSize + margin));
                pic1.Width = cardSize;
                pic1.Height = cardSize;
                pic1.Image = Properties.Resources.Theme_SI_pic20;
                pic1.SizeMode = PictureBoxSizeMode.StretchImage;
                container.Panel1.Controls.Add(pic1);
                PlayCard Card = new PlayCard(pic1);

                //Add a tag from the random tag list to the card
                Card.Tag = tagList[0];

                //Removes the used tag from the list
                tagList.RemoveAt(0);

                Cards[i] = Card;

                columNr++;
                i++;
            }
            return Cards;
        }
    }

    //Playcard class
    public class PlayCard
    {
        public PictureBox Pic { get; set; }
        public Bitmap FrontImage { get; set; }
        public Bitmap BackImage { get; set; }
        public bool Turned { get; set; }
        public int Tag { get; set; }
        public bool AllowedToTurn { get; set; }

        public PlayCard(PictureBox pic)
        {
            AllowedToTurn = true;
            this.Pic = pic;
            this.Pic.Click += new EventHandler(Pic_Click);

            BackImage = ThemeArrays.Back[0];
            this.Pic.Image = BackImage;
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            //The gamemaster decides if the player can turn a card
            //AllowedToTurn = Gamemaster.AllowCardTurn
            if (AllowedToTurn)
            {
                Console.WriteLine("My tag is: " + Tag);
                TurnUpCard();
            }
        }
        //Turns the card to diplay the picture up
        public void TurnUpCard()
        {
            FrontImage = ThemeArrays.Theme[Tag, 0];
            Console.WriteLine("Turning the card up");
            Turned = true;
            //Set image to the front image
            Pic.Image = FrontImage;
        }

        //Turns the card to display the back
        public void TurnDownCard()
        {
            BackImage = ThemeArrays.Back[0];
            Console.WriteLine("Turning the card down");
            Turned = false;
            //Set image to the back image
            Pic.Image = BackImage;
        }

    }

    //An array to get fronts and backs for cards depening on tags and settings
    public static class ThemeArrays
    {
        public static Bitmap[,] Theme { get; set; }
        public static Bitmap[] Back { get; set; }

        public static void Create()
        {
            
            //Make theme array
            Theme = new Bitmap[59, 2];
            Theme[0, 0] = Properties.Resources.Theme_SI_pic0;
            Theme[1, 0] = Properties.Resources.Theme_SI_pic1;
            Theme[2, 0] = Properties.Resources.Theme_SI_pic2;
            Theme[3, 0] = Properties.Resources.Back_BlackOrange;
            Theme[4, 0] = Properties.Resources.Back_BrownBeige;
            Theme[5, 0] = Properties.Resources.Back_GoldPurple;
            Theme[6, 0] = Properties.Resources.Theme_SI_pic18;
            Theme[7, 0] = Properties.Resources.Theme_SI_pic19;
            Theme[8, 0] = Properties.Resources.Theme_SI_pic20;

            //Make back array
            Back = new Bitmap[2];
            Back[0] = Properties.Resources.Back_GoldBlue;
        }
    }

    //Keeps track of the generated cards
    public static class CardList
    {
        public static PlayCard[] Cards { get; set; }

        //Creates the card list
        public static void Create(PlayCard[] cards)
        {
            Cards = cards;
        }

        //Looks through list to find a pair and returns the two card tags as an array
        //If there is not two cards fliped it returns the values 100 and 101
        public static int[] SearchForPairs()
        {
            int flipCount = 0;
            int[] cardTags = new int[2];
            foreach(PlayCard card in Cards)
            {
                if(card.Turned == true)
                {
                    flipCount++;
                    cardTags[0] = card.Tag;
                    if(flipCount == 1)
                    {
                        cardTags[1] = card.Tag;
                    }
                    
                    if(flipCount == 2)
                    {
                        return cardTags;
                    }
                }
            }
            return new int[]{100,101};
        }
    }
    
}
