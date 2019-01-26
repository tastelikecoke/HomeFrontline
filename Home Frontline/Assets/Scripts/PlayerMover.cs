using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{

    public Vector3 originalPosition;
    public bool isRespawning = false;
    public bool isInvulnerable = false;

    public void Start()
    {
        StartCoroutine(Respawn());
    }

    public void FixedUpdate()
    {
        if(isRespawning) return;

        Vector3 directionality = Vector3.zero;
        directionality += new Vector3(1,0,0) * Input.GetAxis("Horizontal");
        directionality += new Vector3(0,1,0) * Input.GetAxis("Vertical");
        directionality = directionality.normalized * 2f; 
        this.GetComponent<Rigidbody2D>().velocity = directionality;
    }
    public void OnTriggerEnter2D(Collider2D collider2D)
    {
        if(!collider2D.isTrigger)
            return;
        // kill
        if(isInvulnerable) return;
        StartCoroutine(Respawn());
    }

    public IEnumerator Respawn()
    {
        isRespawning = true;
        isInvulnerable = true;
        this.transform.position = originalPosition;
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, 2.0f, 0);
        yield return new WaitForSeconds(1.0f);
        isRespawning = false;
        yield return new WaitForSeconds(1.0f);
        isInvulnerable = false;
    }
}
