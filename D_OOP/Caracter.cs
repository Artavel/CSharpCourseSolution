using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    //internal
    //private
    //public
    public class Point2D
    {
        private int x;
        private int y;

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Caracter
    {
        private readonly int speed = 10;
        public int Health { get; set; } = 100;

        public string Race { get; private set; }
        public int Armor { get; private set; }

        public Caracter(string race)
        {
            Race = race;
        }

        public Caracter(string race, int armor)
        {
            Race = race;
            Armor = armor;
        }

        //public Caracter(string race, int armor, int speed)
        //{
        //    Race = race;
        //    Armor = armor;
        //    this.speed = speed;
        //}

        public void Hit(int damage)
        {
            if (damage > Health)
                damage = Health;

            Health -= damage;
        }
    }
}
