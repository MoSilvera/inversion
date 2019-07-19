using System;
namespace inversion{
public class Zombie :Monster, IFireKills
{
    public void Burn (string attack)
    {
        if (attack == "Fire") {
            Console.WriteLine("You just killed the Zombie");
        }
    }
}
}