using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(GunController))]
public class Player : MonoBehaviour
{
    float speed = 8;
    PlayerController playerController;
    GunController gunController;
    Camera camera;
    void Start()
    {
        playerController = GetComponent<PlayerController>();
        camera = Camera.main;
        gunController = GetComponent<GunController>();
    }

    
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        Vector3 velocity = movement.normalized  * speed ;

        playerController.Move(velocity);

        
       
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(Vector3.up, Vector3.zero);
        float rayDistance;
        if (plane.Raycast(ray,out rayDistance))
        {
            Vector3 point = ray.GetPoint(rayDistance);
            playerController.LookAt(point);
        }
        if (Input.GetMouseButton(0))
        {
            gunController.Shoot();
        }
    }
  
}
