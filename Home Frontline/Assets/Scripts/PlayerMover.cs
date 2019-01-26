using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float speed = 3f;
    public Vector3 originalPosition;
    public bool isRespawning = false;
    public bool isInvulnerable = false;

    public Sprite[] characterSprites;


    public void FixedUpdate()
    {
        
        ChangeSprite(Manager.Instance.scoring.currentCharacterNum);
        if(isRespawning) return;

        Vector3 directionality = Vector3.zero;
        directionality += new Vector3(1,0,0) * Input.GetAxis("Horizontal");
        directionality += new Vector3(0,1,0) * Input.GetAxis("Vertical");
        directionality = directionality.normalized * speed; 
        this.GetComponent<Rigidbody2D>().velocity = directionality;
    }
    public void OnTriggerEnter2D(Collider2D collider2D)
    {
        if(!collider2D.isTrigger)
            return;

        if(isInvulnerable) return;
        // kill
        StartCoroutine(Respawn(true));
    }

    public void ChangeSprite(int characterNum)
    {
        this.GetComponent<SpriteRenderer>().sprite = characterSprites[characterNum];
    }

    public IEnumerator Respawn(bool hasDied)
    {
        isRespawning = true;
        isInvulnerable = true;
        this.GetComponent<Collider2D>().isTrigger = true;
        yield return null;
        
        if(hasDied)
            Manager.Instance.scoring.Die();

        this.transform.position = originalPosition;
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, 2.0f, 0);
        yield return new WaitForSeconds(1.0f);
        isRespawning = false;
        this.GetComponent<Collider2D>().isTrigger = false;
        yield return new WaitForSeconds(1.0f);
        isInvulnerable = false;
    }
}
