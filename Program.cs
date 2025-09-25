namespace OOPInheritancePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var warrior = new Warrior();
            //var wizard = new Wizard("Y'shtola");

            //warrior.Introduce();
            //warrior.Attack();

            //wizard.Introduce();
            //wizard.CastSpell();

            var dog = new Dog("Fido", "Micke");
            dog.Fetch();

            var parrot = new Parrot("Polly", "Albin");
            parrot.Talk($"{parrot.Name} wants a cracker");
        }
    }
}
