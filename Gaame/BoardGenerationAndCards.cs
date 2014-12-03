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
            return tagList;
        }

        //Remove item from the refered list at the index
        static void RemoveFromListAtIndex(ref List<int> list, int index)
        {
            list.RemoveAt(index);
        }

        public static void GenerateBoard(int x, SplitContainer container)
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
                pic1.Image = Properties.Resources.Facebook;
                pic1.SizeMode = PictureBoxSizeMode.StretchImage;
                container.Panel1.Controls.Add(pic1);
                PlayCard Card = new PlayCard(pic1);

                //Add a random tag from the tag list to the card
                Random random = new Random();
                int curTag = random.Next(tagList.Count);
                Card.Tag = tagList[curTag];
                Console.WriteLine(tagList[curTag]);

                //Removes the used tag from the list
                tagList.RemoveAt(curTag);

                Cards[i] = Card;

                columNr++;
                i++;
            }
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
            //FrontImage = ThemeLists[SaveGameSettings.theme, Tag];
            //BackImage = BackList[SaveGameSettings.backTheme];
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
        public void TurnUpCard()
        {
            Console.WriteLine("Turning the card up");
            Turned = true;
            //Set image to the front image
            Pic.Image = BackImage;
        }

        public void TurnDownCard()
        {
            Console.WriteLine("Turning the card down");
            Turned = false;
            //Set image to the back image
            Pic.Image = FrontImage;
        }

    }

    //An array to get fronts and backs for cards depening on tags
    public static class ThemeArray
    {
        public static Bitmap[,] FrontTheme { get; set; }
        public static Bitmap[] BackTheme { get; set; }

        public void Construct()
        {
            FrontTheme[0, 0] = Properties.Resources.Youtube;
        }
    }
}
