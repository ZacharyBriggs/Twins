using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour {

    void Update()
    {
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");
        Move(new Vector3(x, 0, z));
    }

    public void Move(Vector3 direction)
    {
        if (direction != Vector3.zero)
        {
            //Rotates character in direction moving
            //transform.rotation = Quaternion.LookRotation(direction);
            transform.position += direction * Time.deltaTime;
        }
    }
}