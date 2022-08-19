using System;

namespace Dependency_Inversion
{
    public class Zombie : Killable, ICombustable
    {
        public void Burn (string attack)
        {
            if (attack == "Fire") {
                Console.WriteLine("You just killed the Zombie");
            }
        }
    }
}