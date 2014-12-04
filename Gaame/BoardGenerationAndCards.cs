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

            BackImage = ThemeArrays.Back[SaveGameSettings.Deck];
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
            FrontImage = ThemeArrays.Theme[Tag, SaveGameSettings.Theme];
            Console.WriteLine("Turning the card up");
            Turned = true;
            //Set image to the front image
            Pic.Image = FrontImage;
        }

        //Turns the card to display the back
        public void TurnDownCard()
        {
            BackImage = ThemeArrays.Back[SaveGameSettings.Deck];
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
            Theme = new Bitmap[60, 3];
            //Social Icons theme
            #region Social Icons
            Theme[0, 0] = Properties.Resources.Theme_SI_pic0;
            Theme[1, 0] = Properties.Resources.Theme_SI_pic1;
            Theme[2, 0] = Properties.Resources.Theme_SI_pic2;
            Theme[3, 0] = Properties.Resources.Theme_SI_pic3;
            Theme[4, 0] = Properties.Resources.Theme_SI_pic4;
            Theme[5, 0] = Properties.Resources.Theme_SI_pic5;
            Theme[6, 0] = Properties.Resources.Theme_SI_pic6;
            Theme[7, 0] = Properties.Resources.Theme_SI_pic7;
            Theme[8, 0] = Properties.Resources.Theme_SI_pic8;
            Theme[9, 0] = Properties.Resources.Theme_SI_pic9;
            Theme[10, 0] = Properties.Resources.Theme_SI_pic10;
            Theme[11, 0] = Properties.Resources.Theme_SI_pic11;
            Theme[12, 0] = Properties.Resources.Theme_SI_pic12;
            Theme[13, 0] = Properties.Resources.Theme_SI_pic13;
            Theme[14, 0] = Properties.Resources.Theme_SI_pic14;
            Theme[15, 0] = Properties.Resources.Theme_SI_pic15;
            Theme[16, 0] = Properties.Resources.Theme_SI_pic16;
            Theme[17, 0] = Properties.Resources.Theme_SI_pic17;
            Theme[18, 0] = Properties.Resources.Theme_SI_pic18;
            Theme[19, 0] = Properties.Resources.Theme_SI_pic19;
            Theme[20, 0] = Properties.Resources.Theme_SI_pic20;
            Theme[21, 0] = Properties.Resources.Theme_SI_pic21;
            Theme[22, 0] = Properties.Resources.Theme_SI_pic22;
            Theme[23, 0] = Properties.Resources.Theme_SI_pic23;
            Theme[24, 0] = Properties.Resources.Theme_SI_pic24;
            Theme[25, 0] = Properties.Resources.Theme_SI_pic25;
            Theme[26, 0] = Properties.Resources.Theme_SI_pic26;
            Theme[27, 0] = Properties.Resources.Theme_SI_pic27;
            Theme[28, 0] = Properties.Resources.Theme_SI_pic28;
            Theme[29, 0] = Properties.Resources.Theme_SI_pic29;
            Theme[30, 0] = Properties.Resources.Theme_SI_pic30;
            Theme[31, 0] = Properties.Resources.Theme_SI_pic31;
            Theme[32, 0] = Properties.Resources.Theme_SI_pic32;
            Theme[33, 0] = Properties.Resources.Theme_SI_pic33;
            Theme[34, 0] = Properties.Resources.Theme_SI_pic34;
            Theme[35, 0] = Properties.Resources.Theme_SI_pic35;
            Theme[36, 0] = Properties.Resources.Theme_SI_pic36;
            Theme[37, 0] = Properties.Resources.Theme_SI_pic37;
            Theme[38, 0] = Properties.Resources.Theme_SI_pic38;
            Theme[39, 0] = Properties.Resources.Theme_SI_pic39;
            Theme[40, 0] = Properties.Resources.Theme_SI_pic40;
            Theme[41, 0] = Properties.Resources.Theme_SI_pic41;
            Theme[42, 0] = Properties.Resources.Theme_SI_pic42;
            Theme[43, 0] = Properties.Resources.Theme_SI_pic43;
            Theme[44, 0] = Properties.Resources.Theme_SI_pic44;
            Theme[45, 0] = Properties.Resources.Theme_SI_pic45;
            Theme[46, 0] = Properties.Resources.Theme_SI_pic46;
            Theme[47, 0] = Properties.Resources.Theme_SI_pic47;
            Theme[48, 0] = Properties.Resources.Theme_SI_pic48;
            Theme[49, 0] = Properties.Resources.Theme_SI_pic49;
            Theme[50, 0] = Properties.Resources.Theme_SI_pic50;
            Theme[51, 0] = Properties.Resources.Theme_SI_pic51;
            Theme[52, 0] = Properties.Resources.Theme_SI_pic52;
            Theme[53, 0] = Properties.Resources.Theme_SI_pic53;
            Theme[54, 0] = Properties.Resources.Theme_SI_pic54;
            Theme[55, 0] = Properties.Resources.Theme_SI_pic55;
            Theme[56, 0] = Properties.Resources.Theme_SI_pic56;
            Theme[57, 0] = Properties.Resources.Theme_SI_pic57;
            Theme[58, 0] = Properties.Resources.Theme_SI_pic58;
            Theme[59, 0] = Properties.Resources.Theme_SI_pic59;
            #endregion Social Icons

            //Smiley theme
            #region Smiley
            Theme[0, 1] = Properties.Resources.Theme_Smile_pic0;
            Theme[1, 1] = Properties.Resources.Theme_Smile_pic1;
            Theme[2, 1] = Properties.Resources.Theme_Smile_pic2;
            Theme[3, 1] = Properties.Resources.Theme_Smile_pic3;
            Theme[4, 1] = Properties.Resources.Theme_Smile_pic4;
            Theme[5, 1] = Properties.Resources.Theme_Smile_pic5;
            Theme[6, 1] = Properties.Resources.Theme_Smile_pic6;
            Theme[7, 1] = Properties.Resources.Theme_Smile_pic7;
            Theme[8, 1] = Properties.Resources.Theme_Smile_pic8;
            Theme[9, 1] = Properties.Resources.Theme_Smile_pic9;
            Theme[10, 1] = Properties.Resources.Theme_Smile_pic10;
            Theme[11, 1] = Properties.Resources.Theme_Smile_pic11;
            Theme[12, 1] = Properties.Resources.Theme_Smile_pic12;
            Theme[13, 1] = Properties.Resources.Theme_Smile_pic13;
            Theme[14, 1] = Properties.Resources.Theme_Smile_pic14;
            Theme[15, 1] = Properties.Resources.Theme_Smile_pic15;
            Theme[16, 1] = Properties.Resources.Theme_Smile_pic16;
            Theme[17, 1] = Properties.Resources.Theme_Smile_pic17;
            Theme[18, 1] = Properties.Resources.Theme_Smile_pic18;
            Theme[19, 1] = Properties.Resources.Theme_Smile_pic19;
            Theme[20, 1] = Properties.Resources.Theme_Smile_pic20;
            Theme[21, 1] = Properties.Resources.Theme_Smile_pic21;
            Theme[22, 1] = Properties.Resources.Theme_Smile_pic22;
            Theme[23, 1] = Properties.Resources.Theme_Smile_pic23;
            Theme[24, 1] = Properties.Resources.Theme_Smile_pic24;
            Theme[25, 1] = Properties.Resources.Theme_Smile_pic25;
            Theme[26, 1] = Properties.Resources.Theme_Smile_pic26;
            Theme[27, 1] = Properties.Resources.Theme_Smile_pic27;
            Theme[28, 1] = Properties.Resources.Theme_Smile_pic28;
            Theme[29, 1] = Properties.Resources.Theme_Smile_pic29;
            Theme[30, 1] = Properties.Resources.Theme_Smile_pic30;
            Theme[31, 1] = Properties.Resources.Theme_Smile_pic31;
            Theme[32, 1] = Properties.Resources.Theme_Smile_pic32;
            Theme[33, 1] = Properties.Resources.Theme_Smile_pic33;
            Theme[34, 1] = Properties.Resources.Theme_Smile_pic34;
            Theme[35, 1] = Properties.Resources.Theme_Smile_pic35;
            Theme[36, 1] = Properties.Resources.Theme_Smile_pic36;
            Theme[37, 1] = Properties.Resources.Theme_Smile_pic37;
            Theme[38, 1] = Properties.Resources.Theme_Smile_pic38;
            Theme[39, 1] = Properties.Resources.Theme_Smile_pic39;
            Theme[40, 1] = Properties.Resources.Theme_Smile_pic40;
            Theme[41, 1] = Properties.Resources.Theme_Smile_pic41;
            Theme[42, 1] = Properties.Resources.Theme_Smile_pic42;
            Theme[43, 1] = Properties.Resources.Theme_Smile_pic43;
            Theme[44, 1] = Properties.Resources.Theme_Smile_pic44;
            Theme[45, 1] = Properties.Resources.Theme_Smile_pic45;
            Theme[46, 1] = Properties.Resources.Theme_Smile_pic46;
            Theme[47, 1] = Properties.Resources.Theme_Smile_pic47;
            Theme[48, 1] = Properties.Resources.Theme_Smile_pic48;
            Theme[49, 1] = Properties.Resources.Theme_Smile_pic49;
            Theme[50, 1] = Properties.Resources.Theme_Smile_pic50;
            Theme[51, 1] = Properties.Resources.Theme_Smile_pic51;
            Theme[52, 1] = Properties.Resources.Theme_Smile_pic52;
            Theme[53, 1] = Properties.Resources.Theme_Smile_pic53;
            Theme[54, 1] = Properties.Resources.Theme_Smile_pic54;
            Theme[55, 1] = Properties.Resources.Theme_Smile_pic55;
            Theme[56, 1] = Properties.Resources.Theme_Smile_pic56;
            Theme[57, 1] = Properties.Resources.Theme_Smile_pic57;
            Theme[58, 1] = Properties.Resources.Theme_Smile_pic58;
            Theme[59, 1] = Properties.Resources.Theme_Smile_pic59;
            #endregion Smiley

            //Flag theme
            #region Flags
            Theme[0, 2] = Properties.Resources.Theme_Flag_pic0;
            Theme[1, 2] = Properties.Resources.Theme_Flag_pic1;
            Theme[2, 2] = Properties.Resources.Theme_Flag_pic2;
            Theme[3, 2] = Properties.Resources.Theme_Flag_pic3;
            Theme[4, 2] = Properties.Resources.Theme_Flag_pic4;
            Theme[5, 2] = Properties.Resources.Theme_Flag_pic5;
            Theme[6, 2] = Properties.Resources.Theme_Flag_pic6;
            Theme[7, 2] = Properties.Resources.Theme_Flag_pic7;
            Theme[8, 2] = Properties.Resources.Theme_Flag_pic8;
            Theme[9, 2] = Properties.Resources.Theme_Flag_pic9;
            Theme[10, 2] = Properties.Resources.Theme_Flag_pic10;
            Theme[11, 2] = Properties.Resources.Theme_Flag_pic11;
            Theme[12, 2] = Properties.Resources.Theme_Flag_pic12;
            Theme[13, 2] = Properties.Resources.Theme_Flag_pic13;
            Theme[14, 2] = Properties.Resources.Theme_Flag_pic14;
            Theme[15, 2] = Properties.Resources.Theme_Flag_pic15;
            Theme[16, 2] = Properties.Resources.Theme_Flag_pic16;
            Theme[17, 2] = Properties.Resources.Theme_Flag_pic17;
            Theme[18, 2] = Properties.Resources.Theme_Flag_pic18;
            Theme[19, 2] = Properties.Resources.Theme_Flag_pic19;
            Theme[20, 2] = Properties.Resources.Theme_Flag_pic20;
            Theme[21, 2] = Properties.Resources.Theme_Flag_pic21;
            Theme[22, 2] = Properties.Resources.Theme_Flag_pic22;
            Theme[23, 2] = Properties.Resources.Theme_Flag_pic23;
            Theme[24, 2] = Properties.Resources.Theme_Flag_pic24;
            Theme[25, 2] = Properties.Resources.Theme_Flag_pic25;
            Theme[26, 2] = Properties.Resources.Theme_Flag_pic26;
            Theme[27, 2] = Properties.Resources.Theme_Flag_pic27;
            Theme[28, 2] = Properties.Resources.Theme_Flag_pic28;
            Theme[29, 2] = Properties.Resources.Theme_Flag_pic29;
            Theme[30, 2] = Properties.Resources.Theme_Flag_pic30;
            Theme[31, 2] = Properties.Resources.Theme_Flag_pic31;
            Theme[32, 2] = Properties.Resources.Theme_Flag_pic32;
            Theme[33, 2] = Properties.Resources.Theme_Flag_pic33;
            Theme[34, 2] = Properties.Resources.Theme_Flag_pic34;
            Theme[35, 2] = Properties.Resources.Theme_Flag_pic35;
            Theme[36, 2] = Properties.Resources.Theme_Flag_pic36;
            Theme[37, 2] = Properties.Resources.Theme_Flag_pic37;
            Theme[38, 2] = Properties.Resources.Theme_Flag_pic38;
            Theme[39, 2] = Properties.Resources.Theme_Flag_pic39;
            Theme[40, 2] = Properties.Resources.Theme_Flag_pic40;
            Theme[41, 2] = Properties.Resources.Theme_Flag_pic41;
            Theme[42, 2] = Properties.Resources.Theme_Flag_pic42;
            Theme[43, 2] = Properties.Resources.Theme_Flag_pic43;
            Theme[44, 2] = Properties.Resources.Theme_Flag_pic44;
            Theme[45, 2] = Properties.Resources.Theme_Flag_pic45;
            Theme[46, 2] = Properties.Resources.Theme_Flag_pic46;
            Theme[47, 2] = Properties.Resources.Theme_Flag_pic47;
            Theme[48, 2] = Properties.Resources.Theme_Flag_pic48;
            Theme[49, 2] = Properties.Resources.Theme_Flag_pic49;
            Theme[50, 2] = Properties.Resources.Theme_Flag_pic50;
            Theme[51, 2] = Properties.Resources.Theme_Flag_pic51;
            Theme[52, 2] = Properties.Resources.Theme_Flag_pic52;
            Theme[53, 2] = Properties.Resources.Theme_Flag_pic53;
            Theme[54, 2] = Properties.Resources.Theme_Flag_pic54;
            Theme[55, 2] = Properties.Resources.Theme_Flag_pic55;
            Theme[56, 2] = Properties.Resources.Theme_Flag_pic56;
            Theme[57, 2] = Properties.Resources.Theme_Flag_pic57;
            Theme[58, 2] = Properties.Resources.Theme_Flag_pic58;
            Theme[59, 2] = Properties.Resources.Theme_Flag_pic59;
            #endregion Flags

            //Make back array
            Back = new Bitmap[5];
            Back[0] = Properties.Resources.Back_GoldBlue;
            Back[1] = Properties.Resources.Back_GoldGrey;
            Back[2] = Properties.Resources.Back_BlackOrange;
            Back[3] = Properties.Resources.Back_BrownBeige;
            Back[4] = Properties.Resources.Back_GoldPurple;
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
