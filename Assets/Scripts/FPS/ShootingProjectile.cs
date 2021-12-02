using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingProjectile : MonoBehaviour
{

    public Rigidbody projectile;
    public GameObject canyon;

    [Range(1,20)]
    public int force = 3;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody clone;
            clone = Instantiate(projectile, canyon.transform.position, transform.rotation);
            clone.velocity = transform.TransformDirection(Vector3.forward * force);
        }
    }
}