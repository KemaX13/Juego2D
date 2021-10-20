using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Missile : MonoBehaviour
{
    public void SetTarget(Transform target)
    {
        //Vector2 direction = (Vector2)target.position - rb.position;

        //direction.Normalize();

        //float rotateAmount = Vector3.Cross(direction, transform.up).z;

        //rb.angularVelocity = -rotateAmount * rotateSpeed;

        //rb.velocity = transform.up * speed;
    }
}