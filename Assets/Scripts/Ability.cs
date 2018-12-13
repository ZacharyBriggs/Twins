using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ZachScripts
{
    public abstract class Ability
    {
        public string name;
        public float cooldown;
        public float charges;
        public virtual void Activate()
        {
            Debug.Log(name + " activated");
        }
    }
}