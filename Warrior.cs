using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritancePractice
{
    internal class Warrior : Character
    {
        public Warrior(string name = "Ardbert", int health = 10) : base(name, health)  
        {
            Name = name;
            Health = health;
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} uses a heavy attack with the axe!");
        }
    }
}
