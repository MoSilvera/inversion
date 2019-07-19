using System;
namespace inversion{
public class Mummy : Monster, IFireKills
{
  
     public void Burn (string attack)
    {
        if (attack == "Fire") {
            Console.WriteLine("You just killed the Mummy");
        }
    }
}
}