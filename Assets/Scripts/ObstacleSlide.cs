using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSlide : MonoBehaviour
{
    public Rigidbody rb;

    public float startSpeed = 50f;

    void Start()
    {
        rb.AddForce(-startSpeed, 0, 0, ForceMode.VelocityChange);
    }
}
