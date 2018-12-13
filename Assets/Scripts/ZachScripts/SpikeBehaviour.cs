using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Luke;

namespace ZachScripts
{
    public class FloorHazardBehaviour : MonoBehaviour
    {
        public float damage;
        public float RoD; //rate of damage
        private float timer;
        public bool damageEverything;
        private void Start()
        {
            RoD = timer;
        }
        private void Update()
        {
            timer -= Time.deltaTime;
            if(timer == 0)
            {
                timer = RoD;
            }
        }

        private void OnCollisionStay(Collision collision)
        {
            var character = collision.gameObject.GetComponent<CharacterBehaviour>();
            if (character.gameObject.tag == "Player" && timer == 0)
            {
                character.TakeDamage(damage);
            }
            else if(character.gameObject.tag == "Enemy" && damageEverything && timer == 0)
            {
                character.TakeDamage(damage);
            }
        }
    }
}