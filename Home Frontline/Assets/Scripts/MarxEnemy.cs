using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarxEnemy : MonoBehaviour
{
    public float counter = 0.0f;

    public AnimationCurve enterCurve;

    public Vector3 initialPosition;
    public Vector3 finalPosition;
    public Vector3 otherPosition;

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
        
        yield return new WaitForSeconds(2f);
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, -3.0f, 0);
        yield return new WaitForSeconds(5f);
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
