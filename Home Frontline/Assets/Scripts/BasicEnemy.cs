using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    public GameObject bullet;
    public float timer = 0.0f;

    void FixedUpdate()
    {
        timer -= Time.fixedDeltaTime;
        if(timer < 0.0f)
        {
            GameObject newBullet = Instantiate(bullet);
            Manager.Instance.bulletDeleter.AddBullet(newBullet);
            newBullet.transform.position = this.transform.position;
            newBullet.GetComponent<Rigidbody2D>().velocity = new Vector3(0,1,0);
            timer += 1.0f;
        }
    }
}
