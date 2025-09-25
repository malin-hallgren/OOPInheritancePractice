using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPInheritancePractice
{
    internal class Wizard : Character
    {
        public Wizard(string name, int health = 4) : base(name, health)
        {
            Name = name;
            Health = health;
        }

        public void CastSpell()
        {
            Console.WriteLine($"{Name} casts a mighty fireball!");
        }
    }
}
