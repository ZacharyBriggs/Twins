using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Luke
{
    public class EnemyBehaviour : CharacterBehaviour
    {
        [SerializeField]
        private string _name;
        [SerializeField]
        private float current_health;
        private float _movementSpeed;
        public GameEvent onDeath;
        private NavMeshAgent navMesh;
        public Player target;

        private void Awake()
        {
            target = FindObjectOfType<Player>();
            navMesh = GetComponent<NavMeshAgent>();
            _name = "Enemy";
            current_health = 3;
        }
        private void Update()
        {
            var playerDistance = Vector3.Distance(target.transform.position, transform.position);

            if(playerDistance < 100f)
            {
                navMesh.destination = target.transform.position;
            }

            if(current_health <= 0)
            {
                Die();
            }
        }

        public override string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public override float Health
        {
            get
            {
                return current_health;
            }
            set
            {
                current_health = value;
            }
        }

        public override float MovementSpeed
        {
            get
            {
                return _movementSpeed;
            }

            set
            {
                _movementSpeed = value;
            }
        }

        public override void Die()
        {
            onDeath.Raise();
            Destroy(gameObject);
        }

        public override void Move(Vector3 Direction)
        {
        }

        public override void TakeDamage(float amount)
        {
            if(current_health > 0)
            {
                ChangeHealth(-amount);
            }
        }

        public override void ChangeHealth(float amount)
        {
            current_health += amount;
        }
    }
}
