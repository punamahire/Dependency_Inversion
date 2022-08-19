using System;

namespace Dependency_Inversion
{
    public class Mummy : Killable, ICombustable
    {
        public void Burn (string attack)
        {
            if (attack == "Fire") {
                Console.WriteLine("You just killed the Mummy");
            }
        }
    }
}