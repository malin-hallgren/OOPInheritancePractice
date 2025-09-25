using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritancePractice
{
    internal class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Character(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void Introduce()
        {
            Console.WriteLine($"Please welcome {Name}");
        }
    }
}
