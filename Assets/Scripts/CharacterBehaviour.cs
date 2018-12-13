using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Luke
{
    public abstract class CharacterBehaviour : MonoBehaviour
    {
        public abstract string Name { get; set; }

        public abstract float Health { get; set; }

        public abstract float MovementSpeed { get; set; }
        public abstract void Move(Vector3 Direction);
        public abstract void Die();
        public abstract void TakeDamage(float amount);
        public abstract void ChangeHealth(float amount);
    }
}
