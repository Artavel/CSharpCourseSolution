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

    public class Character
    {
        private readonly int speed = 10;
        public int Health { get; set; } = 100;

        public Race Race { get; private set; }
        public int Armor { get; private set; }
        public string Name { get; private set; }

        public Character(Race race)
        {
            Race = race;
        }

        public Character(string name, int armor)
        {
            if (name == null)
                throw new ArgumentNullException("name arg can't be null");

            if (armor < 0 || armor > 100)
                throw new ArgumentNullException("armor can't be less than 0 or greater than 100");

            Name = name;
            Armor = armor;
        }

        public Character(Race race, int armor)
        {
            Race = race;
            Armor = (int)race;
        }

        //public Caracter(string race, int armor, int speed)
        //{
        //    Race = race;
        //    Armor = armor;
        //    this.speed = speed;
        //}

        public void Hit(int damage)
        {
            if (Health == 0)
                throw new InvalidOperationException("Can't hit a dead character!");

            if (damage > Health)
                throw new ArgumentException("damage can't be greater than current Health!");

            if (damage > Health)
                damage = Health;

            Health -= damage;
        }
    }
}
