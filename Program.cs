using System;

namespace inversion
{
    class Program
    {
        public static void Main()
        {
            Hunter VonRimmersmark = new Hunter("Erich", "Von Rimmersmark");

            Mummy tuts = new Mummy();
            Demon demonDude = new Demon();
            Ghast ghastMan = new Ghast();
            Ghoul ghouleyGirl = new Ghoul();
            Vampire vampyVamp = new Vampire();
            Wight wightGuy = new Wight();
            Zombie dead = new Zombie(); 
            VonRimmersmark.ToString();
            VonRimmersmark.Burn(tuts);
            VonRimmersmark.Douse(demonDude);
            VonRimmersmark.WieldSilver(ghouleyGirl);
            VonRimmersmark.Douse(ghastMan);
            VonRimmersmark.SillyPutty(dead);
        }
    }
}
