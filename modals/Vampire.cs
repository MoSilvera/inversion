using System;
namespace inversion{
public class Vampire :Monster, ISilverKills, IFireKills
{
    public void Silver (string attack)
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
}