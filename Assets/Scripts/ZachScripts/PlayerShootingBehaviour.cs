using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZachScripts
{
    public class PlayerShootingBehaviour : MonoBehaviour
    {
        public void FirePrimary(Vector3 direction)
        {
            transform.forward = direction;
            //call the weapons fire and fire in the direction of the stick
        }
    }
}