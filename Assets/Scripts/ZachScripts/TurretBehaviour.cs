using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBehaviour : MonoBehaviour
{
    public float RoF; //Rate of fire
    private float timer;
    public Projectile projectileprefab;
	// Use this for initialization
	void Start ()
    {
        timer = RoF;
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            var proj = Instantiate<Projectile>(projectileprefab);
            proj.transform.position = this.transform.position;
            proj.transform.forward = this.transform.forward;
            timer = RoF;
        }
	}
}
