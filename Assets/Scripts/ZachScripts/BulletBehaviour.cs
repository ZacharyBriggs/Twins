using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : Projectile
{
    void Start ()
    {
		
	}
	
	void Update ()
    {
        this.transform.position += this.transform.forward * speed;
        lifetime -= Time.deltaTime;
        if(lifetime <= 0)
        {
            Expire();
        }
	}
    public override void Expire()
    {
        Destroy(this.gameObject);
    }
}
