using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items
{
    public class WeaponBehaviour : MonoBehaviour
    {
        public Weapon weaponRef;
        public LineRenderer Projectile;
        public float DelayTimer = 0;

        void Awake()
        {
            Projectile.enabled = false;
        }

        void Update()
        {

            DelayTimer += Time.deltaTime;
            if (Input.GetKey(KeyCode.Space) && DelayTimer > weaponRef.RateOfFire)
            {
                if(weaponRef.Activate())
                    Activate(transform.forward);
            }
            else
            {
                var col = Projectile.material.color;
                Projectile.enabled = false;
            }
        }

        void Activate(Vector3 Direction)
        {
            DelayTimer = 0;
            var endRange = (transform.position + Direction) * weaponRef.Range;
            Projectile.SetPosition(0, transform.position);
            Projectile.SetPosition(1, endRange);
            Projectile.enabled = true;
        }

        public void ReloadWeapon()
        {
            StartCoroutine(weaponRef.Reload());
        }
    }
}
