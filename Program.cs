using System;

namespace Dependency_Inversion
{
    class Program
    {
        public static void Main(string[] args)
        {
            Hunter VonRimmersmark = new Hunter("Erich", "Von Rimmersmark");

            Mummy tuts = new Mummy();
            VonRimmersmark.Ignite(tuts);

            Ghoul ghoul = new Ghoul();
            VonRimmersmark.SplashWater(ghoul);

            Vampire vamp = new Vampire();
            VonRimmersmark.WieldSilver(vamp);

            Demon demon = new Demon();
            VonRimmersmark.Ignite(demon);

            Ghast ghast = new Ghast();
            VonRimmersmark.SplashWater(ghast);

            Wight wight = new Wight();
            VonRimmersmark.WieldSilver(wight);

            Zombie zombie = new Zombie();
            VonRimmersmark.Ignite(zombie);
        }
    }
}
