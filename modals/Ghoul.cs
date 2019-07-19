using System;
namespace inversion{
public class Ghoul :Monster, ISilverKills, IWaterKills
{
    public void Silver (string attack)
    {
        if (attack == "Silver") {
            Console.WriteLine("You just killed the Ghoul");
        }
    }
     public void Splash (string attack)
    {
        if (attack == "Holy Water") {
            Console.WriteLine("You just killed the Ghoul");
        }
    }
}
}