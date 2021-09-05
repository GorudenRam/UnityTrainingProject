using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    public float movespeed = 5f;

    Vector2 movement;


    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        this.GetComponent<MeshRenderer>().material.SetTextureOffset("_MainTex", this.GetComponent<MeshRenderer>().material.GetTextureOffset("_MainTex") + movement * movespeed * Time.fixedDeltaTime);
    }
}
