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
                    const int win = 1;
                  const int loose = 0;
                     int noOfbets = 0;

            Gambler gambler1 = new Gambler(Stake);
                int Gamblers_Stake = gambler1.Gamblers_stake;
            while (Gamblers_Stake > 50 && Gamblers_Stake < 150)
            {
                Random random = new Random();
                int WinOrLoose = random.Next(0, 2);
                switch (WinOrLoose)
                {
                    case 0:
                        Gamblers_Stake = Gamblers_Stake - Bet;
                        Console.WriteLine("Loose");
                        break;
                    case 1:
                        Gamblers_Stake = Gamblers_Stake + Bet;
                        Console.WriteLine("Win");
                        break;
                }
                noOfbets++;
            }

                Console.WriteLine(Gamblers_Stake);
            Console.ReadKey();

        }
        }
    }

