using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainEnemy : MonoBehaviour
{
    public float counter = 0.0f;

    public AnimationCurve enterCurve;

    public Vector3 initialPosition;
    public Vector3 finalPosition;
    public Vector3 otherPosition;

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
        /* 
        for(float i=-5.5f; i <= 5.5f; i+=.2f)
        {
            if(2.2f < i && i < 3.7f) continue;

            this.SummonBullet(new Vector3(i, transform.position.y, 0f), new Vector3(0, -3.0f, 0), 6);
        }

        yield return new WaitForSeconds(3f);
        for(float i=-5.5f; i <= 5.5f; i+=.2f)
        {
            if(-3.2f < i && i < -2.2f) continue;
            this.SummonBullet(new Vector3(i, transform.position.y, 0f), new Vector3(0, -3.0f, 0), 7);
        }
        yield return new WaitForSeconds(2.5f);
        for(float i=-5.5f; i <= 5.5f; i+=.2f)
        {
            if(2.9f < i && i < 3.7f) continue;
            this.SummonBullet(new Vector3(i, transform.position.y, 0f), new Vector3(0, -3.0f, 0), 6);
        }
        yield return new WaitForSeconds(1.75f);
        for(float i=-5.5f; i <= 5.5f; i+=.2f)
        {
            if(-2.2f < i && i < -1.0f) continue;
            this.SummonBullet(new Vector3(i, transform.position.y, 0f), new Vector3(0, -3.0f, 0), 7);
        }
        yield return new WaitForSeconds(1.5f);
        for(float i=-5.5f; i <= 5.5f; i+=.2f)
        {
            if(2.0f < i && i < 3f) continue;
            this.SummonBullet(new Vector3(i, transform.position.y, 0f), new Vector3(0, -3.0f, 0), 6);
        }
        yield return new WaitForSeconds(1.5f);
        for(float i=-5.5f; i <= 5.5f; i+=.2f)
        {
            if(-1.5f < i && i < -0f) continue;
            this.SummonBullet(new Vector3(i, transform.position.y, 0f), new Vector3(0, -3.0f, 0), 7);
        }

        for(int j=0; j<5; j++)
        {

            yield return new WaitForSeconds(1f);
            for(float i=-5.5f; i <= 5.5f; i+=.2f)
            {
                if(0.75f < i && i < 2f) continue;
                this.SummonBullet(new Vector3(i, transform.position.y, 0f), new Vector3(0, -3.0f, 0), 6);
            }
            yield return new WaitForSeconds(1f);
            for(float i=-5.5f; i <= 5.5f; i+=.2f)
            {
                if(-2f < i && i < -0.75f) continue;
                this.SummonBullet(new Vector3(i, transform.position.y, 0f), new Vector3(0, -3.0f, 0), 7);
            }
        }
        
        transform.position = finalPosition;
        counter = 0f;
        while(counter < 2.0f)
        {
            float curveValue = enterCurve.Evaluate(counter);
            transform.position = Vector3.Lerp(finalPosition, otherPosition, curveValue);
            yield return null;
        }
        transform.position = otherPosition;

        yield return new WaitForSeconds(1f);
        for(float i=-5.5f; i <= 5.5f; i+=1f)
        {
            this.SummonBullet(new Vector3(-5.2f, i, 0f), new Vector3(2f, 0f, 0), 6);
        }
        yield return new WaitForSeconds(2f);
        for(float i=-5.0f; i <= 5.5f; i+=1f)
        {
            this.SummonBullet(new Vector3(5.2f, i, 0f), new Vector3(-2f, 0f, 0), 7);
        }
        yield return new WaitForSeconds(1.5f);
        for(float i=-5.5f; i <= 5.5f; i+=1f)
        {
            this.SummonBullet(new Vector3(-5.2f, i, 0f), new Vector3(2f, 0f, 0), 6);
        }
        yield return new WaitForSeconds(1f);
        for(float i=-5.5f; i <= 5.5f; i+=1f)
        {
            this.SummonBullet(new Vector3(i, 5.2f, 0f), new Vector3(0f, -2f, 0), 7);
        }
        yield return new WaitForSeconds(1f);
        for(float i=-5.5f; i <= 5.5f; i+=1f)
        {
            this.SummonBullet(new Vector3(-5.2f, i, 0f), new Vector3(2f, 0f, 0), 6);
        }
        for(float i=-5.0f; i <= 5.5f; i+=1f)
        {
            this.SummonBullet(new Vector3(5.2f, i, 0f), new Vector3(-2f, 0f, 0), 7);
        }
        yield return new WaitForSeconds(2f);
        for(float i=-5.5f; i <= 5.5f; i+=1f)
        {
            this.SummonBullet(new Vector3(i, 5.2f, 0f), new Vector3(0f, -2f, 0), 7);
        }
        yield return new WaitForSeconds(1.5f);
        for(float i=-5.0f; i <= 5.5f; i+=1f)
        {
            this.SummonBullet(new Vector3(i, 5.2f, 0f), new Vector3(0f, -2f, 0), 6);
        }
        for(float i=-5.5f; i <= 5.5f; i+=1f)
        {
            this.SummonBullet(new Vector3(-5.2f, i, 0f), new Vector3(2f, 0f, 0), 6);
        }
        for(float i=-5.0f; i <= 5.5f; i+=1f)
        {
            this.SummonBullet(new Vector3(5.2f, i, 0f), new Vector3(-2f, 0f, 0), 7);
        }
        yield return new WaitForSeconds(1f);
        for(float i=-5.5f; i <= 5.5f; i+=1f)
        {
            this.SummonBullet(new Vector3(i, 5.2f, 0f), new Vector3(0f, -2f, 0), 7);
        }

        transform.position = otherPosition;
        counter = 0f;
        while(counter < 2.0f)
        {
            float curveValue = enterCurve.Evaluate(counter);
            transform.position = Vector3.Lerp(otherPosition, finalPosition, curveValue);
            yield return null;
        }
        transform.position = finalPosition;
        yield return new WaitForSeconds(1f);

        for(int j=0; j<5; j++)
        {
            yield return new WaitForSeconds(.8f);
            for(float i=-5.5f; i <= 5.5f; i+=1f)
            {
                this.SummonBullet(new Vector3(i, 5.2f, 0f), new Vector3(0f, -3f, 0), 7);
            }
            yield return new WaitForSeconds(.8f);
            for(float i=-5.5f; i <= 5.5f; i+=.2f)
            {
                if(1.0f < i && i < 2f) continue;
                this.SummonBullet(new Vector3(i, 5.2f, 0f), new Vector3(0, -3.0f, 0), 6);
            }
            yield return new WaitForSeconds(.8f);
            for(float i=-5.0f; i <= 5.5f; i+=1f)
            {
                this.SummonBullet(new Vector3(i, 5.2f, 0f), new Vector3(0f, -3f, 0), 7);
            }
            yield return new WaitForSeconds(.8f);
            for(float i=-5.5f; i <= 5.5f; i+=.2f)
            {
                if(-2f < i && i < -1f) continue;
                this.SummonBullet(new Vector3(i, 5.2f, 0f), new Vector3(0, -3.0f, 0), 6);
            }
        }
        yield return new WaitForSeconds(2f);
        */
        for(int j=0; j<5; j++)
        {
            yield return new WaitForSeconds(1f);
            for(float i=-5.5f; i <= 5.5f; i+=1f)
            {
                this.SummonBullet(new Vector3(i, 5.2f, 0f), new Vector3(0f, -3f, 0), 6);
            }
            yield return new WaitForSeconds(1f);
            for(float i=-5.5f; i <= 5.5f; i+=.2f)
            {
                if(1.0f < i && i < 2f) continue;
                this.SummonBullet(new Vector3(i, 5.2f, 0f), new Vector3(0, -2.0f, 0), 7);
            }
            yield return new WaitForSeconds(1f);
            for(float i=-5.0f; i <= 5.5f; i+=1f)
            {
                this.SummonBullet(new Vector3(i, 5.2f, 0f), new Vector3(0f, -2f, 0), 6);
            }
            yield return new WaitForSeconds(1f);
            for(float i=-5.5f; i <= 5.5f; i+=.2f)
            {
                if(-2f < i && i < -1f) continue;
                this.SummonBullet(new Vector3(i, 5.2f, 0f), new Vector3(0, -3.0f, 0), 7);
            }
        }
        
        transform.position = finalPosition;
        counter = 0f;
        while(counter < 2.0f)
        {
            float curveValue = enterCurve.Evaluate(counter);
            transform.position = Vector3.Lerp(finalPosition, otherPosition, curveValue);
            yield return null;
        }
        transform.position = otherPosition;

        yield return new WaitForSeconds(2f);
        for(int j=0; j<5; j++)
        {
            yield return new WaitForSeconds(1f);
            for(float i=-5.5f; i <= 5.5f; i+=.2f)
            {
                if(1.0f < i && i < 2f) continue;
                this.SummonBullet(new Vector3(i, 5.2f, 0f), new Vector3(0, -2.0f, 0), 7);
            }
            for(float i=-5.5f; i <= 5.5f; i+=1f)
            {
                this.SummonBullet(new Vector3(-5.2f, i, 0f), new Vector3(2f, 0f, 0), 6);
            }
            yield return new WaitForSeconds(1f);
            for(float i=-5.5f; i <= 5.5f; i+=.2f)
            {
                if(-2f < i && i < -1f) continue;
                this.SummonBullet(new Vector3(i, 5.2f, 0f), new Vector3(0, -2.0f, 0), 7);
            }
            for(float i=-5.5f; i <= 5.5f; i+=1f)
            {
                this.SummonBullet(new Vector3(-5.2f, i, 0f), new Vector3(2f, 0f, 0), 6);
            }
        }
        Destroy(this.gameObject);
    }

    public void SummonBullet(Vector3 spawnPoint, Vector3 velocity, int color)
    {
        Manager.Instance.bulletDeleter.MakeBullet(spawnPoint, velocity, color);
    }

    void FixedUpdate()
    {
        counter += Time.fixedDeltaTime;
    }
}
