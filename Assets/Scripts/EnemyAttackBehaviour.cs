using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Luke
{
    public class EnemyAttackBehaviour : MonoBehaviour
    {
        public EnemyBehaviour enemy;
        public Player target;

        // Use this for initialization
        void Awake()
        {
            target = FindObjectOfType<Player>();
            enemy = FindObjectOfType<EnemyBehaviour>();
        }

        public void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("Enemy is Attacking");
                target.TakeDamage(1);
                enemy.Die();
            }
        }
    }
}
