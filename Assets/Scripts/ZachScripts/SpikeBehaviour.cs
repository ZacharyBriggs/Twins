﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Luke;

namespace ZachScripts
{
    public class SpikeBehaviour : FloorHazard
    {
        private void Start()
        {
            collider = GetComponent<BoxCollider>();
            collider.enabled = false;
            timer = RoD;
        }
        private void Update()
        {
            if(CheckTimer())
            {

            }
        }

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