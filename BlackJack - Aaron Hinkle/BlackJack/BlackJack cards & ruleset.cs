namespace BlackJack
{

    public class BlackJack
    {
        //Overall, project assumes that the blackjack game is only between two players, the dealer and the user.

        //class
        /*
        //fields
        private int yourOneCard;
        private int yourTwoCard;
        private int dealerCard;
        private int overallCardCount;
        private int cardValue;

        */

        //properties
        public int YourOneCardValue { get; set; }
        public int YourTwoCardValue { get; set; }
        public int DealerCard1 { get; set; }

        public int DealerCard2 { get; set; }
        public int OverallCardCount { get; set; }

        public int HitCardValue { get; set; }

        public int NewTotal { get; set; }

        public int DealerCardHitValue { get; set; }





        //constructor

        public BlackJack(int yourOneCardValue, int yourTwoCardValue, int dealerCard1, int dealerCard2, int overallCardCount, int hitCardValue, int dealerHitCardvalue, int newTotal)

        {
            YourOneCardValue = yourOneCardValue;
            YourTwoCardValue = yourTwoCardValue;
            DealerCard1 = dealerCard1;
            DealerCard2 = dealerCard2;
            OverallCardCount = overallCardCount;
            HitCardValue = hitCardValue;
            NewTotal = newTotal;
            DealerCardHitValue = dealerHitCardvalue;

        }


        public void newHand()
        {
            // This method will give both faces and card types based on a random integer, invoked by the enum below 


            var rnd = new Random();

            YourOneCardValue = rnd.Next(0, 13);
            CARDS card1 = (CARDS)YourOneCardValue;

            int faceCard1 = rnd.Next(0, 4);
            FACE cardFace1 = (FACE)faceCard1;

            YourTwoCardValue = rnd.Next(0, 13);
            CARDS card2 = (CARDS)YourTwoCardValue;

            int faceCard2 = rnd.Next(0, 4);
            FACE cardFace2 = (FACE)faceCard2;

            int dealerCardFaceRand1 = rnd.Next(0, 4);
            FACE dealerCardFace = (FACE)dealerCardFaceRand1;

            DealerCard2 = rnd.Next(0, 13);

            DealerCard1 = rnd.Next(0, 13);
            CARDS Card3 = (CARDS)DealerCard1;






            Console.WriteLine($"You were dealt a {card1} of {cardFace1} and a {card2} of {cardFace2}");
            Console.WriteLine($"The dealer is showing a {Card3} of {dealerCardFace}");

        }




        /// <summary>
        /// enums set values to each of the cards in the random function invoked above 
        /// </summary>
        enum CARDS { Two = 0, Three = 1, Four = 2, Five = 3, Six = 4, Seven = 5, Eight = 6, Nine = 7, Ten = 8, Jack = 9, Queen = 10, King = 11, Ace = 12 }
        enum FACE { Diamonds = 0, Spades = 1, Hearts = 2, Clubs = 3 }





        /// CardValues will conver the card randomly generated above into a value that can be used in mathmatical equations to calculate whether the dealer won or lost a hand or the player. 


        public static int CardValues(int x)
        {
            int z = 0;
            if (x == 12)
            {

                Console.WriteLine($"Is the Ace a 1 or 11?");
                String Y = Console.ReadLine();
                if (Y == "1")
                {
                    return x = 1;
                }
                if (Y == "11")
                {
                    return x = 11;
                }
            }
            else switch (x)
                {
                    case 11:
                        z = 10;
                        break;

                    case 10:
                        z = 10;
                        break;

                    case 9:
                        z = 10;
                        break;

                    case 8:
                        z = 10;
                        break;

                    case 7:
                        z = 9;
                        break;

                    case 6:
                        z = 8;
                        break;

                    case 5:
                        z = 7;
                        break;

                    case 4:
                        z = 6;
                        break;

                    case 3:
                        z = 5;
                        break;

                    case 2:
                        z = 4;
                        break;

                    case 1:
                        z = 3;
                        break;

                    case 0:
                        z = 2;
                        break;

                }
            return z;
        }







        public static int InitialWin(int l, int m)

        {
            int w = l + m;
            return w;

        }

        public static void CardCount(int x)
        //keeps track of how many cards are left in the deck, the assumption is that there is only one deck. However, Blackjack is typically played with more than one deck at a time. 
        {

            int overallCardCount = x - 4;


            Console.WriteLine("There are " + overallCardCount + " cards left in the game");

        }

        public void HitOrStay()

        {


            var rnd = new Random();
            int hitCardFace = rnd.Next(0, 4);
            FACE hitCardFace1 = (FACE)hitCardFace;

            HitCardValue = rnd.Next(0, 13);
            CARDS hitCardValue1 = (CARDS)HitCardValue;

            Console.WriteLine("You have been dealt a " + hitCardValue1 + " of " + hitCardFace1);


        }


        public void DealerReveal()
        {

            var rand = new Random();
            CARDS Card4 = (CARDS)DealerCard2;

            int dealerCardFaceRand2 = rand.Next(0, 4);
            FACE dealerCardFace4 = (FACE)dealerCardFaceRand2;

            Console.WriteLine("Dealer flips over a " + Card4 + " of " + dealerCardFace4);

        }

        public void DealerHit()
        {
            var rnd = new Random();
            int hitCardFace = rnd.Next(0, 4);
            FACE hitCardFace4 = (FACE)hitCardFace;

            DealerCardHitValue = rnd.Next(0, 13);
            CARDS hitCardValue1 = (CARDS)DealerCardHitValue;

            Console.WriteLine("Dealer is under 17, dealer hits themselves for a  " + hitCardValue1 + " of " + hitCardFace4);
        }
            public void CardsLeft()
        {
            if (HitCardValue >= 1)
            { Console.WriteLine("There are " + (OverallCardCount - 5) + " cards left in the game"); }
            else
            {
                Console.WriteLine("There are " + (OverallCardCount - 4) + " cards left in the game");
            }
        }





    }
}



















/*



       public void CardCount()
       //keeps track of how many cards are left in the deck, the assumption is that there is only one deck. However, Blackjack is typically played with more than one deck at a time. 
       {

           Console.WriteLine("How many extra cards in that hand were dealt?");
           int extraCards = Convert.ToInt32(Console.ReadLine());
           if (extraCards == 0)
           { Overallcardcount = Overallcardcount - 4; }
           else
           {
               Overallcardcount = Overallcardcount - 4 - extraCards;
           }

           Console.WriteLine("The number of cards left in the deck is" + Overallcardcount);

       }
    */










