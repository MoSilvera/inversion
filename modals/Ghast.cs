using System;
namespace inversion{
public class Ghast :Monster, IWaterKills, IFireKills
{
    public void Splash (string attack)
    {
        if (attack == "Holy Water") {
            Console.WriteLine("You just killed the Ghast");
        }
    }
     public void Burn (string attack)
    {
        if (attack == "Fire") {
            Console.WriteLine("You just killed the Ghast");
        }
    }
}
}