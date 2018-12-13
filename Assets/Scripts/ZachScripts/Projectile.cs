using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Luke;

public abstract class Projectile : MonoBehaviour
{
    public float damage;
    public float speed;
    public float lifetime;
    public abstract void Expire();
    public virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            var player = collision.gameObject.GetComponent<CharacterBehaviour>();
            player.TakeDamage(damage);
            Debug.Log("hit player");
            Destroy(this.gameObject);
        }
        else if(collision.gameObject.tag != "Enemy")
        {
            Debug.Log("hit a wall");
            Destroy(this.gameObject);
        }
    }
}
