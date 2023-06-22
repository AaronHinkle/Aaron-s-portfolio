namespace BlackJack
{
    public class Program
    {
        static void Main(string[] args)
        {
            //menu to start new game 
            Console.WriteLine("Welcome to the BlackJack table");
            Console.WriteLine("Press enter to play");
            Console.ReadKey();

            Console.WriteLine("How many chips would you like to buy?");
            int buyIn = Convert.ToInt32(Console.ReadLine());
            Chips newHandChips = new Chips(buyIn);

            bool isRunning = true;
            while (isRunning)

            {
                Console.WriteLine("===================================================");
                Console.WriteLine("You have " + newHandChips.ChipCount + " chips remaining ");

                Console.WriteLine("===================================================");

                Console.WriteLine("Place a bet to start a new hand");

                int bet = Convert.ToInt32(Console.ReadLine());

                newHandChips.Bet(bet);


                //prob run this as a loop set against overall card #'s being > 0. Once that is false, game resets. 

                BlackJack newHand = new BlackJack(1, 2, 3, 4, 52, 0, 0, 0);

                //starts a new hand of cards 

                newHand.newHand();

                //calculates the value of the cards that are currently on the table 

                int card1Value = BlackJack.CardValues(newHand.YourOneCardValue);
                int card2Value = BlackJack.CardValues(newHand.YourTwoCardValue);
                int dealer1CardValue = BlackJack.CardValues(newHand.DealerCard1);
                int dealer2CardValue = BlackJack.CardValues(newHand.DealerCard2);

                newHand.NewTotal = (card1Value + card2Value);

                //Check if either person's first two cards = 21, game is automatically over if true. Dealer only shows one card, but the blackjack still needs to be calculated in the background if that is the case. 

                if (BlackJack.InitialWin(dealer1CardValue, dealer2CardValue) == 21)
                {
                    Console.WriteLine("Dealer has 21. You lose. Try again \n");
                        newHandChips.Lose(bet);
                }

                else if (BlackJack.InitialWin(card1Value, card2Value) == 21)
                
                {
                    Console.WriteLine("You have blackjack, you win! \n\n");
                        newHandChips.Bet(bet);
                }

               

                {
                    Console.WriteLine("Neither dealer nor player has a BlackJack, continue game\n");



                    //// if neither had blackjack above, per else function game continues and goes to prompt for hit or stay function

                    Console.WriteLine("Would you like to hit or stay? Press H for hit or S for stay");
                    char b = Convert.ToChar(Console.ReadLine());

                    //if user "Hits", user gets a new card and their total value will change. 
                    if (b == 'H')

                    {
                        newHand.HitOrStay();
                        int hitCardValue = BlackJack.CardValues(newHand.HitCardValue);
                        newHand.NewTotal += hitCardValue;
                        Console.WriteLine("Your new total is " + newHand.NewTotal + "\n");

                    }

                    //if user does not "Hit", and get a new card 
                    else
                    {
                        Console.WriteLine("You have chosen to stay at " + BlackJack.InitialWin(card1Value, card2Value) + "\n");


                    }

                    //if users total is over 21 after "hit" above, game is over and user loses aka "BUST" in BlackJack. 
                    if
                        (newHand.NewTotal > 21)
                    {
                        Console.WriteLine("Bust! \n You lose (Idiot) \n");
                        newHandChips.Lose(bet);

                    }

                    // If user didn't bust, game continues and dealer flips their card returning their total value. Dealer can also bust in BlackJack as they can also hit their own cards. But in this program that function
                    // (cont) has been ommitted. The basis for dealer busting over 21 is still included in the below. 
                    //  NOTE FOR SELF - main issue with dealer busting is there are soft and hard hit limits. That logic was too difficult to encorporate. 

                    else 
                    {
                        newHand.DealerReveal();

                        int dealerTotal = (dealer1CardValue + dealer2CardValue);
                        if (dealerTotal <= 17)
                        {
                            newHand.DealerHit();
                            int DealerCardHitValue = BlackJack.CardValues(newHand.DealerCardHitValue);
                            dealerTotal += DealerCardHitValue;
                        }


                        
                        {



                            if (dealerTotal > 21)
                            {
                                Console.WriteLine("Dealer has " + dealerTotal + " \n Dealer busts. \n\n You win! \n");
                                newHandChips.Win(bet);
                            }
                            // if users final total is higher than dealer's final total - user wins.
                            else if (dealerTotal < newHand.NewTotal)
                            {
                                Console.WriteLine("You have " + newHand.NewTotal + " and the Dealer has " + dealerTotal + "\n\n You win! \n");
                                newHandChips.Win(bet);
                            }


                            //if dealers final total is higher than users final total - dealer wins. 
                            else 
                            {
                                Console.WriteLine("You have " + newHand.NewTotal + " and the Dealer has " + dealerTotal + "\n\n Dealer wins!");
                                newHandChips.Lose(bet);
                            }
                        }
                    }
                }

            }
        }
    }
}






//this method tells the user how many cards are left in the game based on how many were played. future endevear and not included in this program, spitballing ideas below
/*
                BlackJack.CardCount(newHand.OverallCardCount);
*/
/*
           // next steps, hit or stay //

           Console.WriteLine("Would you like to hit or stay?");
                Console.WriteLine("Press H for hit, S for stay");
                char x = Convert.ToChar(Console.ReadLine());
            if (x == 'H')
            {
                BlackJack.HitOrStay(x);
            }
  */


















