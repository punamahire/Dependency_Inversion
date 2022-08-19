using System;
using System.Collections.Generic;

namespace Dependency_Inversion
{
    public class Hunter
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<string> Weapons { get; } = new List<string>() {
            "Silver", "Fire", "Holy Water"
        };

        public Hunter (string first, string last) {
            FirstName = first;
            LastName = last;
        }

        public void SplashWater (ISprinkleable monster) {
            monster.Douse("Holy Water");  // Kills with holy water
        }

        public void Ignite (ICombustable monster) {
            monster.Burn("Fire");  // Kills with fire
        }

        public void WieldSilver (IStabbable monster) {
            monster.Stab("Silver");   // Stabs with silver knife
        }

        public void DefiniteKill (Killable monster)
        {
            monster.KillWithUlimateWeapon();
        }

        public override string ToString () {
            return $"{FirstName} {LastName} kills monsters with the following weapons: {String.Join(", ", Weapons)}";
        }
    }
}