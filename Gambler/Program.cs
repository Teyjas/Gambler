using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    namespace Gambling
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("welcome to gamblers game");
                PlayGame();
            }

            public static void PlayGame()
            {

                const int Stake = 100;
                const int Bet = 1;

                Gambler gambler1 = new Gambler(Stake);
                int Gamblers_Stake = gambler1.Gamblers_stake;

                Random random = new Random();
                int WinOrLoose = random.Next(0, 2);
                switch (WinOrLoose)
                {
                    case 0:
                        Gamblers_Stake = Gamblers_Stake - Bet;
                        break;
                    case 1:
                        Gamblers_Stake = Gamblers_Stake + Bet;
                        break;
                }

                Console.WriteLine(Gamblers_Stake);
            Console.ReadKey();

            }
        }
    }

