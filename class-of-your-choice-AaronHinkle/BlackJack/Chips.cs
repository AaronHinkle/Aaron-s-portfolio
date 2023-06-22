namespace BlackJack
{
    internal class Chips

    {
        private int chipCount;
       

        public int BetChips { get; set; }
        public int ChipCount
        {
            get { return chipCount; }

            set
            {
                if (value >= 0)
                {
                    chipCount = value;
                }

                else
                {
                    Console.WriteLine("Chip balance cannot be zero");
                }
            }
        }

        public Chips(int x)
        {
            ChipCount = x;
        }



        public void Bet(int betsomechips)
        {
            if (ChipCount < betsomechips)
            { Console.WriteLine("Not enough chips to bet, try again"); }

            else 
            {
                Console.WriteLine($"You have bet {betsomechips} chips. Good luck! \n");
            }



        }

        public void Win(int x)
        { ChipCount += x;
            
        }

        public void Lose(int x)
        { ChipCount -= x; }
    }
}










