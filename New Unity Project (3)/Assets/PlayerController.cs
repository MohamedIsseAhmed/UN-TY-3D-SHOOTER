using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rigidbody;
    Vector3 velocity;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 _velocity)
    {
         velocity= _velocity ;
    }
    public void LookAt(Vector3 point)
    {
        Vector3 correctedLookPoint = new Vector3(point.x, transform.position.y, point.z);
        transform.LookAt(correctedLookPoint);


    }
    public void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + velocity * Time.fixedDeltaTime);
    }
}
