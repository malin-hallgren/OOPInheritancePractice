using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritancePractice
{
    internal class Parrot : Pet
    {
        public Parrot(string name, string owner) : base(name, owner)
        {
            Name = name;
            Owner = owner;
        }

        public void Talk(string message)
        {
            Console.WriteLine(message);
        }
    }
}
