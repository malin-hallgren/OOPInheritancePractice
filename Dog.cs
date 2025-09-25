using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritancePractice
{
    internal class Dog : Pet
    {
        private int fetchValue {  get; set; }

        public Dog(string name, string owner) : base(name, owner)
        {
            Name = name;
            Owner = owner;
        }
        

        public void Fetch()
        {
            Random random = new Random();
            int catchNumber = random.Next(1, 3);

            fetchValue = catchNumber;
            if (fetchValue == 2)
            {
                Console.WriteLine($"{Name} catches the ball");
            }
            else
            {
                Console.WriteLine($"{Name} tries to catch the ball, but fails");
            }
        }
    }
}
