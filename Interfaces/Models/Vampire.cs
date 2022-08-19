using System;

public class Vampire : IStabbable, ICombustable
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