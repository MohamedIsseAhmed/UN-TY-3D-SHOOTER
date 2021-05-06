using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform projectilePosition;
    public Projectile projectile;
    public float projectileVelocity=35;
    public float msecondsBetweenFires=100;
    float nextFireTime;
    
    public void Shoot()
    {
        if (Time.time > nextFireTime)
        {
            nextFireTime = Time.time + msecondsBetweenFires / 1000;
            Projectile projectileToFire = Instantiate(projectile, projectilePosition.position,projectilePosition.rotation) as Projectile;
            projectileToFire.SetSpeed(projectileVelocity);
        }
       
    }
    
}
