
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Hero {

    public Hero() {
    }

    public HashSet<Protection> Protections;

    public Arsenal HeroArsenal;

    public int Health;

    public Weapon ActiveWeapon;

    public void SelectProtection() {
        // TODO implement here
    }

    /// <summary>
    /// @param RoomMonster
    /// </summary>
    public void AutoSelectCorrectProtection(Monster RoomMonster) {
        // TODO implement here
    }

}