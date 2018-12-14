using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Luke;

namespace ZachScripts
{
    public class LavaBehaviour : FloorHazard
    {
        private void OnTriggerStay(Collider other)
        {
            var character = other.gameObject.GetComponent<CharacterBehaviour>();
            if (character.gameObject.tag == "Player")
            {
                character.TakeDamage(damage);
                Debug.Log("Damaged Player");
            }
            else if (character.gameObject.tag == "Enemy" && damageEverything)
            {
                character.TakeDamage(damage);
            }
        }
    }
}