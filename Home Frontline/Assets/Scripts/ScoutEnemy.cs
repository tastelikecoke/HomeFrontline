using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoutEnemy : MonoBehaviour
{
    public float counter = 0.0f;

    public Vector3 initialPosition;
    public float scoutEnd = 0.4f;
    public float scoutFrequency = 0.2f;

    public void Start()
    {
        StartCoroutine(BeginStage());
    }

    public IEnumerator BeginStage()
    {
        transform.position = initialPosition;
        this.GetComponent<Rigidbody2D>().velocity = new Vector3(0,-1.3f,0);
        counter = 0f;
        bool isFiring = true;
        while(true)
        {
            if(isFiring && counter > scoutFrequency)
            {
                Vector3 directionality = Manager.Instance.playerMover.transform.position - this.transform.position;
                SummonBullet(this.transform.position + directionality.normalized * 0.2f, directionality.normalized * 3f);
                counter -= scoutFrequency;
            }
            Vector3 enemyviewport = Manager.Instance.gameCam.WorldToViewportPoint(this.transform.position);
            if(enemyviewport.y < scoutEnd)
            {
                isFiring = false;
            }
            if(0 < enemyviewport.x && enemyviewport.x < 1 && enemyviewport.y > 0)
            {
                yield return null;
            }
            else
            {
                break;
            }
        }
        Destroy(this.gameObject);
    }

    public void SummonBullet(Vector3 spawnPoint, Vector3 velocity)
    {
        Manager.Instance.bulletDeleter.MakeBullet(spawnPoint, velocity);
    }

    void FixedUpdate()
    {
        counter += Time.fixedDeltaTime;
    }
}
