using System;

public class Ghoul : ISprinkleable, IStabbable
{
    public void Douse (string attack)
    {
        if (attack == "Holy Water") {
            Console.WriteLine("You just killed the Ghoul");
        }
    }

    public void Stab (string attack)
    {
        if (attack == "Silver") {
            Console.WriteLine("You just killed the Ghoul");
        }
    }
}