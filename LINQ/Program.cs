using F_Delegations.Sticks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Timers;

namespace F_Delegations
{

    class Program
    {
        static void Main(string[] args)
        {
            LinqDemo("Top100ChessPlayers.csv");

            Console.ReadLine();
        }

        static void LinqDemo(string file)
        {
            //var lines = File.ReadAllLines(file);
            IEnumerable<ChessPlayer> list = File.ReadAllLines(file)
                                         .Skip(1)
                                         .Select(ChessPlayer.ParseFideCsv)
                                         .Where(player => player.BirthYear > 1988)
                                         .OrderByDescending(player => player.Rating)
                                         .ThenBy(player => player.Country)
                                         .Take(10);
            //.ToList();

            Console.WriteLine($"The lowest rating in TOP 10: {list.Min(x => x.Rating)}");
            Console.WriteLine($"The highest rating in TOP 10: {list.Max(x => x.Rating)}");
            Console.WriteLine($"The average rating in TOP 10: {list.Average(x => x.Rating)}");

            Console.WriteLine(list.First());
            Console.WriteLine(list.Last());

            Console.WriteLine(list.First(player => player.Country == "USA"));
            Console.WriteLine(list.Last(player => player.Country == "USA"));

            ChessPlayer firstFromBra = list.FirstOrDefault(player => player.Country == "BRA");
            if (firstFromBra != null)
            {
                Console.WriteLine(firstFromBra.LastName);
            }
            var lastFromBra = list.LastOrDefault(player => player.Country == "BRA");

            Console.WriteLine(list.Single(player => player.Country == "FRA"));
            Console.WriteLine(list.SingleOrDefault(player => player.Country == "BRA"));

            Console.WriteLine(list.SingleOrDefault(player => player.Country == "USA"));
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
