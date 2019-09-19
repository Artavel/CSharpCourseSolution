﻿using F_Delegations.Sticks;
using System;
using System.Timers;

namespace F_Delegations
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new SticksGame(10, Player.Human);
            game.MachinePlayed += Game_MachinePlayed;
            game.HumanTurnToMakeMove += Game_HumanTurnToMakeMove;
            game.EndOfGame += Game_EndOfGame;

            game.Start();
        }

        private static void Game_MachinePlayed(int sticksTaken)
        {
            Console.WriteLine($"Computer took: {sticksTaken}");
        }

        private static void Game_EndOfGame(Player player)
        {
            Console.WriteLine($"Winner: {player}");
        }

        private static void Game_HumanTurnToMakeMove(object sender, int remainingSticks)
        {
            Console.WriteLine($"Remaining sticks: {remainingSticks}");
            Console.WriteLine("Take some sticks");

            bool takenCorrectly = false;
            while (!takenCorrectly)
            {
                if (int.TryParse(Console.ReadLine(), out int takenSticks))
                {
                    var game = (SticksGame)sender;

                    try
                    {
                        game.HumanTakes(takenSticks);
                        takenCorrectly = true;
                    }
                    catch(ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        public class CarArgs : EventArgs
        {
            public CarArgs(int currentSpeed)
            {
                CurrentSpeed = currentSpeed;
            }

            public int CurrentSpeed { get; }
        }

        public class Car
        {
            int speed = 0;
            //public delegate void TooFast(int currentSpeed);

            public event EventHandler<CarArgs> TooFastDriving;

            //private TooFast tooFast;

            public void Start()
            {
                speed = 10;
            }

            public void Accelerate()
            {
                speed += 10;

                if (speed > 80)
                {
                    if (TooFastDriving != null)
                        TooFastDriving(this, new CarArgs(speed));
                }
            }

            public void Stop()
            {
                speed = 0;
            }

            //public void RegisterOnTooFast(TooFast tooFast)
            //{
            //    this.tooFast += tooFast;
            //}

            //public void UnregisterOnTooFast(TooFast tooFast)
            //{
            //    this.tooFast -= tooFast;
            //}
        }

        public static void EventsDemo()
        {
            Timer timer = new Timer();
            timer.Elapsed += Timer_Elapsed;

            timer.Interval = 5000;
            timer.Start();

            Console.ReadLine();

            Car car = new Car();
            car.TooFastDriving += HandleOnTooFast;
            car.TooFastDriving += HandleOnTooFast;

            car.TooFastDriving -= HandleOnTooFast;

            car.Start();

            for (int i = 0; i < 10; i++)
            {
                car.Accelerate();
            }
            Console.ReadLine();
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //var timer = (Timer)sender;
            Console.WriteLine("Handling Timer Elapsed Event");
        }

        private static void HandleOnTooFast(object obj, CarArgs speed)
        {
            Console.WriteLine($"Oh, I got it, calling stop! Current Speed = {speed}");
            var car = (Car)obj;
            car.Stop();
        }
    }
}
