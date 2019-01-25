using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{

    public void FixedUpdate()
    {
        Vector3 directionality = Vector3.zero;
        directionality += new Vector3(1,0,0) * Input.GetAxis("Horizontal");
        directionality += new Vector3(0,1,0) * Input.GetAxis("Vertical");
        directionality = directionality.normalized * 0.05f; 
        this.transform.position += directionality;
    }
    public void OnTriggerEnter2D(Collider2D collider2D)
    {
        Debug.Log("Collided!");
    }
}
