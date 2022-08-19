using System;

namespace Dependency_Inversion
{
    public class Vampire : Killable, IStabbable, ICombustable
    {
        public void Stab (string attack)
        {
            if (attack == "Silver") {
                Console.WriteLine("You just killed the Vampire");
            }
        }

        public void Burn (string attack)
        {
            if (attack == "Fire") {
                Console.WriteLine("You just killed the Vampire");
            }
        }
    }
}