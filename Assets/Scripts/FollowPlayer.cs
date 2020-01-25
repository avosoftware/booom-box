using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    Vector3 offset = new Vector3(-8f, 3.5f, 0);

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
