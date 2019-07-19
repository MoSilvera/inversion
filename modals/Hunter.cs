using System;
using System.Collections.Generic;

namespace inversion{

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

    public void Douse (IWaterKills waterKillableCreature) {
        waterKillableCreature.Splash("Holy Water");  // Kills with holy water
    }

    public void SillyPutty (Monster monsterToKill){
        monsterToKill.killMonster("Silly Putty");
    }
    public void Burn (IFireKills fireKillableCreature) {
        fireKillableCreature.Burn("Fire");  // Kills with fire
    }

    public void WieldSilver (ISilverKills silverKillableCreature) {
        silverKillableCreature.Silver("Silver");   // Stabs with silver knife
    }

    public override string ToString () {
        return $"{FirstName} {LastName} kills monsters with the following weapons: {String.Join(", ", Weapons)}";
    }

}
}