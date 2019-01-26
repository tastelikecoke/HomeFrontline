using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainEnemy : MonoBehaviour
{
    public float counter = 0.0f;

    public AnimationCurve enterCurve;

    public Vector3 initialPosition;
    public Vector3 finalPosition;

    public int rolls = 32;
    public int rolldupes = 1;
    public float radiansOffset = 0f;
    public float gaps = 16.0f;
    public float firetime = 0.64f;
    public float sign = 1f;

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
        
        // make a wALLL
        
        for(float i=-5.5f; i <= 5.5f; i+=.2f)
        {
            if(2.2f < i && i < 3.7f) continue;

            this.SummonBullet(new Vector3(i, transform.position.y, 0f), new Vector3(0, -3.0f, 0));
        }

        yield return new WaitForSeconds(3f);
        for(float i=-5.5f; i <= 5.5f; i+=.2f)
        {
            if(-3.2f < i && i < -2.2f) continue;
            this.SummonBullet(new Vector3(i, transform.position.y, 0f), new Vector3(0, -3.0f, 0));
        }
        yield return new WaitForSeconds(2.5f);
        for(float i=-5.5f; i <= 5.5f; i+=.2f)
        {
            if(2.9f < i && i < 3.7f) continue;
            this.SummonBullet(new Vector3(i, transform.position.y, 0f), new Vector3(0, -3.0f, 0));
        }
        yield return new WaitForSeconds(1.75f);
        for(float i=-5.5f; i <= 5.5f; i+=.2f)
        {
            if(-2.2f < i && i < -1.0f) continue;
            this.SummonBullet(new Vector3(i, transform.position.y, 0f), new Vector3(0, -3.0f, 0));
        }
        yield return new WaitForSeconds(1.5f);
        for(float i=-5.5f; i <= 5.5f; i+=.2f)
        {
            if(2.0f < i && i < 3f) continue;
            this.SummonBullet(new Vector3(i, transform.position.y, 0f), new Vector3(0, -3.0f, 0));
        }
        yield return new WaitForSeconds(1.5f);
        for(float i=-5.5f; i <= 5.5f; i+=.2f)
        {
            if(-1.5f < i && i < -0f) continue;
            this.SummonBullet(new Vector3(i, transform.position.y, 0f), new Vector3(0, -3.0f, 0));
        }
        yield return new WaitForSeconds(3f);


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
