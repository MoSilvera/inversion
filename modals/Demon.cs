using System;
namespace inversion{
public class Demon :Monster, IWaterKills, IFireKills, ISilverKills
{
    public void Splash (string attack)
    {
        if (attack == "Holy Water") {
            Console.WriteLine("You just killed the Demon");
        }
    }
     public void Burn (string attack)
    {
        if (attack == "Fire") {
            Console.WriteLine("You just killed the Demon");
        }
    }

    public void Silver (string attack)
    {
        if (attack == "Silver") {
            Console.WriteLine("You just killed the Demon");
        }
    }
}
}