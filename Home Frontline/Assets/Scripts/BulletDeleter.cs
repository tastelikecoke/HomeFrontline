using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDeleter : MonoBehaviour
{
    public GameObject bullet;
    public List<GameObject> bulletList;
    public List<GameObject> deadBulletList;

    public void MakeBullet(Vector3 spawnPoint, Vector3 velocity)
    {
        GameObject newBullet = null;
        if(deadBulletList.Count == 0)
        {
            newBullet = Instantiate(bullet);
        }
        else
        {
            newBullet = deadBulletList[0];
            deadBulletList.RemoveAt(0);
            newBullet.gameObject.SetActive(true);
        }
        newBullet.transform.position = spawnPoint;
        bulletList.Add(newBullet);
        newBullet.GetComponent<Rigidbody2D>().velocity = velocity;
    }

    public void Update()
    {
        for(int i=0; i<bulletList.Count; i++)
        {
            Vector3 bulletposition = bulletList[i].transform.position;

            if(-5.5f < bulletposition.x && bulletposition.x < 5.5f && -5.5f < bulletposition.y && bulletposition.y < 5.5f)
            {

                // inside
            }
            else
            {
                bulletList[i].gameObject.SetActive(false);
                deadBulletList.Add(bulletList[i]);
                bulletList.RemoveAt(i);
                i--;
            }
        }
    }
}
