using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Rigidbody2D heroRb;

    void FixedUpdate()
    {
        if (!heroRb) return;

        transform.position = new Vector3(heroRb.position.x, heroRb.position.y, -100f);
    }
}
