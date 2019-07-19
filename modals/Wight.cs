using System;
namespace inversion{
public class Wight : Monster, ISilverKills
{
    public void Silver (string attack)
    {
        if (attack == "Silver") {
            Console.WriteLine("You just killed the Wight");
        }
    }
}
}