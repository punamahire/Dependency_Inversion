using System;

namespace Dependency_Inversion
{
    public class Wight : Killable, IStabbable
    {
        public void Stab (string attack)
        {
            if (attack == "Silver") {
                Console.WriteLine("You just killed the Wight");
            }
        }
    }
}