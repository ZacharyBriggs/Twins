using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Luke;

namespace ZachScripts
{
    public class SpikeBehaviour : MonoBehaviour
    {
        public float damage;
        public float RoD; //rate of damage
        public float timer;
        public bool damageEverything;
        private void Start()
        {
            timer = RoD; ;
        }
        private void Update()
        {
            timer -= Time.deltaTime;
            if(timer <= 0)
            {
                timer = RoD;
                Debug.Log("Spikes Out");
            }
        }

        private void OnTriggerStay(Collider other)
        {
            var character = other.gameObject.GetComponent<CharacterBehaviour>();
            if (character.gameObject.tag == "Player" &&  timer <= 0)
            {
                character.TakeDamage(damage);
                Debug.Log("Damaged Player");
            }
            else if (character.gameObject.tag == "Enemy" && damageEverything && timer <= 0)
            {
                character.TakeDamage(damage);
            }
        }
    }
}