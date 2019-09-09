using System;

namespace DzFindMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Finder game = new Finder(finderPlayer: FinderPlayer.Machine);
            game.Start();

            Console.ReadLine();
        }
    }
}
