using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritancePractice
{
    internal class Pet
    {
        public string Name { get; set; }
        public string Owner { get; set; }

        public Pet (string name, string owner)
        {
            Name = name;
            Owner = owner;
        }

        public void Feed()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }
}
