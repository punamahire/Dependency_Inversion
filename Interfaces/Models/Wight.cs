using System;

public class Wight : IStabbable
{
    public void Stab (string attack)
    {
        if (attack == "Silver") {
            Console.WriteLine("You just killed the Wight");
        }
    }
}