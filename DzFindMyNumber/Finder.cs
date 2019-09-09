using System;
using System.Collections.Generic;
using System.Text;

namespace DzFindMyNumber
{
    public enum FinderPlayer
    {
        Human,
        Machine
    }

    public class Finder
    {
        private readonly int maxTries;
        private readonly FinderPlayer finderPlayer;
        private readonly int max;

        public Finder(int max = 100, int maxTries = 5, FinderPlayer finderPlayer = FinderPlayer.Human)
        {
            this.max = max;
            this.maxTries = maxTries;
            this.finderPlayer = finderPlayer;
        }

        public void Start()
        {
            if(finderPlayer == FinderPlayer.Human)
            {
                HumanFinder();
            }
            else
            {
                MachineFinder();
            }
        }
        private void HumanFinder()
        {
            Random rand = new Random();
            int findNumber = rand.Next(0, max);

            int lastFind = -1;
            int tries = 0;
            while(lastFind != findNumber && tries < maxTries)
            {
                Console.WriteLine("Find the number");
                lastFind = int.Parse(Console.ReadLine());

                if(lastFind == findNumber)
                {
                    Console.WriteLine("Congrats! You find the number!");
                }
                else if(lastFind < findNumber)
                {
                    Console.WriteLine("My number is greater!");
                }
                else
                {
                    Console.WriteLine("My number is less!");
                }

                tries++;
                if(tries == maxTries)
                {
                    Console.WriteLine("You lost!");
                }
            }
        }

        private void MachineFinder()
        {
            Console.WriteLine("Enter a number that's going to be finded by a computer.");

            int findNumber = -1;
            while (findNumber == -1)
            {
                int parsedNumber = int.Parse(Console.ReadLine());
                if (parsedNumber >= 0 && parsedNumber <= this.max)
                {
                    findNumber = parsedNumber;
                }
            }

            int lastFind = -1;
            int min = 0;
            int max = this.max;
            int tries = 0;

            while (lastFind != findNumber && tries < maxTries)
            {
                lastFind = (max + min) / 2;
                Console.WriteLine($"Did you mind this number - {lastFind}?");
                Console.WriteLine("If yes, enter 'y', if your number is greater - enter 'g', if less - 'l'");

                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.WriteLine("Super! I find it!");
                    break;
                }
                else if (answer == "g")
                {
                    min = lastFind;
                }
                else
                {
                    max = lastFind;
                }

                if(lastFind == findNumber)
                {
                    Console.WriteLine("Don't cheat, man!");
                }

                tries++;
                if (tries == maxTries)
                {
                    Console.WriteLine("No tries anymore! I lost :(");
                }
            }
        }
    }
}
