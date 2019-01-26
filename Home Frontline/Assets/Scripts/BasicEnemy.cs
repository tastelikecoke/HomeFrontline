using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    public GameObject bullet;
    public float counter = 0.0f;

    public AnimationCurve enterCurve;

    public Vector3 initialPosition;
    public Vector3 finalPosition;

    public void Start()
    {
        StartCoroutine(BeginStage());
    }

    public IEnumerator BeginStage()
    {
        transform.position = initialPosition;
        counter = 0f;
        while(counter < 2.0f)
        {
            float curveValue = enterCurve.Evaluate(counter);
            transform.position = Vector3.Lerp(initialPosition, finalPosition, curveValue);
            yield return null;
        }
        transform.position = finalPosition;
        yield return null;
        this.GetComponent<Rigidbody2D>().velocity = new Vector3(0,-2,0);
        for(int i=0; i<16; i++)
        {
            float angle = ((float)i)/16.0f * 2*Mathf.PI;
            counter = 0f;
            Vector3 directionality = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0);
            this.SummonBullet(this.transform.position + (directionality*0.5f), directionality*0.5f);
            while(counter < 0.03f)
            {
                yield return null;
            }
        }
        while(true)
        {
            Vector3 enemyviewport = Manager.Instance.gameCam.WorldToViewportPoint(this.transform.position);
            if(0 < enemyviewport.x && enemyviewport.x < 1 && 0 < enemyviewport.y && enemyviewport.y < 1)
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
        GameObject newBullet = Instantiate(bullet);
        Manager.Instance.bulletDeleter.AddBullet(newBullet);
        newBullet.transform.position = spawnPoint;
        newBullet.GetComponent<Rigidbody2D>().velocity = velocity;
    }

    void FixedUpdate()
    {
        counter += Time.fixedDeltaTime;
    }
}
