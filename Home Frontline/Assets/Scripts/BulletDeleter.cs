using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDeleter : MonoBehaviour
{
    public List<GameObject> bulletList;
    public void AddBullet(GameObject bullet)
    {
        bulletList.Add(bullet);
    }

    public void Update()
    {
        for(int i=0; i<bulletList.Count; i++)
        {
            Vector3 bulletposition = bulletList[i].transform.position;
            Vector3 bulletviewport = Manager.Instance.gameCam.WorldToViewportPoint(bulletposition);
            if(0 < bulletviewport.x && bulletviewport.x < 1 && 0 < bulletviewport.y && bulletviewport.y < 1)
            {
                // inside
            }
            else
            {
                Destroy(bulletList[i]);
                bulletList.RemoveAt(i);
                i--;
            }
        }
    }
}
