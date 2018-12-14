using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZachScripts
{
    public class FloorHazard : MonoBehaviour
    {
        public float damage;
        public float RoD; //rate of damage
        protected float timer;
        private float delay = 0.5f;
        public bool damageEverything;
        protected BoxCollider collider;

        public bool CheckTimer()
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                timer = RoD;
                return true;
            }
            return false;
        }
    }
}