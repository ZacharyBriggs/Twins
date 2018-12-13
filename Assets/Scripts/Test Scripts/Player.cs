using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Luke
{
    public class Player : CharacterBehaviour
    {
        private string _name;
        [SerializeField]
        private float current_health = 3;
        public float _movementSpeed;
        public GameEvent onDeath;
        public override string Name
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
                throw new System.NotImplementedException();
            }
        }

        public override float Health
        {
            get { throw new System.NotImplementedException(); }
            set
            {
                throw new System.NotImplementedException();
            }
        }
        public override float MovementSpeed
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
                throw new System.NotImplementedException();
            }
        }

        public override void ChangeHealth(float amount)
        {
            current_health += amount;
        }

        public override void Die()
        {
            onDeath.Raise();
            Destroy(gameObject);
        }

        public override void Move(Vector3 Direction)
        {
            throw new System.NotImplementedException();
        }

        public override void TakeDamage(float amount)
        {
            if (current_health > 0)
            {
                ChangeHealth(-amount);
                Debug.Log("Player is Taking Damage");
            }
        }
    }
}
