using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    public float counter = 0.0f;

    public AnimationCurve enterCurve;

    public Vector3 initialPosition;
    public Vector3 finalPosition;
    public int color = 0;

    public int rolls = 32;
    public int rolldupes = 1;
    public float radiansOffset = 0f;
    public float gaps = 16.0f;
    public float firetime = 0.64f;
    public float sign = 1f;
    public float bulletMag = 1f;

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
        counter -= 2.0f;
        transform.position = finalPosition;
        yield return null;
        Manager.Instance.sounder.OneShotMusic(6);
        for(int i=0; i<rolls; i++)
        {
            float angle = ((float)i * sign)/gaps * 2*Mathf.PI + radiansOffset;
            counter -= (firetime / (float)rolls);
            for(int j=0; j<rolldupes; j++)
            {
                float dupeangle = ((float)j)/((float)rolldupes) * 2*Mathf.PI + radiansOffset;
                Vector3 directionality = new Vector3(Mathf.Cos(angle + dupeangle), Mathf.Sin(angle + dupeangle), 0);
                this.SummonBullet(this.transform.position + (directionality*0.5f), directionality*bulletMag);
            }
            while(counter < (firetime / (float)rolls))
            {
                yield return null;
            }
        }
        this.GetComponent<Rigidbody2D>().velocity = new Vector3(0,-2,0);
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
        Manager.Instance.bulletDeleter.MakeBullet(spawnPoint, velocity, color);
    }

    void FixedUpdate()
    {
        counter += Time.fixedDeltaTime;
    }
}
