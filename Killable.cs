using System;

namespace Dependency_Inversion
{
    public class Killable
    {
        public void KillWithUlimateWeapon()
        {
            Console.WriteLine($"The {this.GetType().Name} flattens like a pancake under the power of the Ultimate Weapon.");
        }
    }
}