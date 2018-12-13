using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Items
{    
    public abstract class Weapon : Item
    {
        public float RateOfFire;
        public float Range;
        public float Damage;

        public abstract bool Activate();

        //All weapons will have some for of reload weather it be a cooldown
        //or ammo depletion.
        public abstract IEnumerator Reload();

        //Implement Damage
    }
}
