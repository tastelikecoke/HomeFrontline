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
    public Vector3 otherPosition2;

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
        
        counter = 0f;
        for(int i=0; i<64; i++)
        {
            float angle = ((float)i)/32 * 2*Mathf.PI;
            counter -= (1.28f / 64f);
            for(int j=0; j<2; j++)
            {
                float dupeangle = ((float)j)/((float)2) * 2*Mathf.PI;
                Vector3 directionality = new Vector3(Mathf.Cos(angle + dupeangle), Mathf.Sin(angle + dupeangle), 0);
                this.SummonBullet(this.transform.position + (directionality*0.5f), directionality*0.75f, 0);
            }
            while(counter < (1.28f / 64f))
            {
                yield return null;
            }
        }
        yield return new WaitForSeconds(1f);
        
        counter = 0f;
        for(int i=0; i<128; i++)
        {
            float angle = ((float)i)/32 * 2*Mathf.PI + 0.45f;
            counter -= (1.28f / 64f);
            for(int j=0; j<3; j++)
            {
                float dupeangle = ((float)j)/((float)3) * 2*Mathf.PI;
                Vector3 directionality = new Vector3(Mathf.Cos(angle + dupeangle), Mathf.Sin(angle + dupeangle), 0);
                this.SummonBullet(this.transform.position + (directionality*0.5f), directionality*0.75f, 1);
            }
            while(counter < (1.28f / 64f))
            {
                yield return null;
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

        counter = 0f;
        for(int i=0; i<64; i++)
        {
            float angle = ((float)i)/32 * 2*Mathf.PI + 0.45f;
            counter -= (1.28f / 64f);
            for(int j=0; j<3; j++)
            {
                float dupeangle = ((float)j)/((float)3) * 2*Mathf.PI;
                Vector3 directionality = new Vector3(Mathf.Cos(angle + dupeangle), Mathf.Sin(angle + dupeangle), 0);
                this.SummonBullet(this.transform.position + (directionality*0.5f), directionality*0.75f, 0);
            }
            while(counter < (1.28f / 64f))
            {
                yield return null;
            }
        }

        transform.position = otherPosition;
        counter = 0f;
        while(counter < 2.0f)
        {
            float curveValue = enterCurve.Evaluate(counter);
            transform.position = Vector3.Lerp(otherPosition, otherPosition2, curveValue);
            yield return null;
        }
        transform.position = otherPosition2;
        
        counter = 0f;
        for(int i=0; i<64; i++)
        {
            float angle = ((float)i)/32 * 2*Mathf.PI + 0.45f;
            counter -= (1.28f / 64f);
            for(int j=0; j<3; j++)
            {
                float dupeangle = ((float)j)/((float)3) * 2*Mathf.PI;
                Vector3 directionality = new Vector3(Mathf.Cos(angle + dupeangle), Mathf.Sin(angle + dupeangle), 0);
                this.SummonBullet(this.transform.position + (directionality*0.5f), directionality*0.75f, 4);
            }
            while(counter < (1.28f / 64f))
            {
                yield return null;
            }
        }

        transform.position = otherPosition2;
        counter = 0f;
        while(counter < 1.0f)
        {
            float curveValue = enterCurve.Evaluate(counter*2f);
            transform.position = Vector3.Lerp(otherPosition2, otherPosition, curveValue);
            yield return null;
        }
        transform.position = otherPosition;
        counter = 0f;
        for(int i=0; i<64; i++)
        {
            float angle = ((float)i)/32 * 2*Mathf.PI + 0.45f;
            counter -= (1.28f / 64f);
            for(int j=0; j<3; j++)
            {
                float dupeangle = ((float)j)/((float)3) * 2*Mathf.PI;
                Vector3 directionality = new Vector3(Mathf.Cos(angle + dupeangle), Mathf.Sin(angle + dupeangle), 0);
                this.SummonBullet(this.transform.position + (directionality*0.5f), directionality*0.75f, 0);
            }
            while(counter < (1.28f / 64f))
            {
                yield return null;
            }
        }
        transform.position = otherPosition;
        counter = 0f;
        while(counter < 1.0f)
        {
            float curveValue = enterCurve.Evaluate(counter*2f);
            transform.position = Vector3.Lerp(otherPosition, otherPosition2, curveValue);
            yield return null;
        }
        transform.position = otherPosition2;
        counter = 0f;
        for(int i=0; i<128; i++)
        {
            float angle = ((float)i)/32 * 2*Mathf.PI + 0.45f;
            counter -= (1.28f / 64f);
            for(int j=0; j<3; j++)
            {
                float dupeangle = ((float)j)/((float)3) * 2*Mathf.PI;
                Vector3 directionality = new Vector3(Mathf.Cos(angle + dupeangle), Mathf.Sin(angle + dupeangle), 0);
                this.SummonBullet(this.transform.position + (directionality*0.5f), directionality*0.75f, 4);
            }
            while(counter < (1.28f / 64f))
            {
                yield return null;
            }
        }

        transform.position = otherPosition2;
        counter = 0f;
        while(counter < 1.0f)
        {
            float curveValue = enterCurve.Evaluate(counter*2f);
            transform.position = Vector3.Lerp(otherPosition2, otherPosition, curveValue);
            yield return null;
        }
        transform.position = otherPosition;

        for(int i=0; i<128; i++)
        {
            float angle = ((float)i)/32 * 2*Mathf.PI + 0.45f;
            counter -= (1.28f / 64f);
            for(int j=0; j<3; j++)
            {
                float dupeangle = ((float)j)/((float)3) * 2*Mathf.PI;
                Vector3 directionality = new Vector3(Mathf.Cos(angle + dupeangle), Mathf.Sin(angle + dupeangle), 0);
                this.SummonBullet(this.transform.position + (directionality*0.5f), directionality*0.75f, 0);
            }
            while(counter < (1.28f / 64f))
            {
                yield return null;
            }
        }
        transform.position = otherPosition;
        counter = 0f;
        while(counter < 0.5f)
        {
            float curveValue = enterCurve.Evaluate(counter*4f);
            transform.position = Vector3.Lerp(otherPosition, otherPosition2, curveValue);
            yield return null;
        }
        transform.position = otherPosition2;
        for(int i=0; i<64; i++)
        {
            float angle = ((float)i)/32 * 2*Mathf.PI + 0.45f;
            counter -= (1.28f / 64f);
            for(int j=0; j<3; j++)
            {
                float dupeangle = ((float)j)/((float)3) * 2*Mathf.PI;
                Vector3 directionality = new Vector3(Mathf.Cos(angle + dupeangle), Mathf.Sin(angle + dupeangle), 0);
                this.SummonBullet(this.transform.position + (directionality*0.5f), directionality*0.75f, 4);
            }
            while(counter < (1.28f / 64f))
            {
                yield return null;
            }
        }
        transform.position = otherPosition2;
        counter = 0f;
        while(counter < 0.5f)
        {
            float curveValue = enterCurve.Evaluate(counter*4f);
            transform.position = Vector3.Lerp(otherPosition2, otherPosition, curveValue);
            yield return null;
        }
        transform.position = otherPosition;
        for(int i=0; i<64; i++)
        {
            float angle = ((float)i)/32 * 2*Mathf.PI + 0.45f;
            counter -= (1.28f / 64f);
            for(int j=0; j<3; j++)
            {
                float dupeangle = ((float)j)/((float)3) * 2*Mathf.PI;
                Vector3 directionality = new Vector3(Mathf.Cos(angle + dupeangle), Mathf.Sin(angle + dupeangle), 0);
                this.SummonBullet(this.transform.position + (directionality*0.5f), directionality*0.75f, 0);
            }
            while(counter < (1.28f / 64f))
            {
                yield return null;
            }
        }
        transform.position = otherPosition;
        counter = 0f;
        while(counter < 1.0f)
        {
            float curveValue = enterCurve.Evaluate(counter*2f);
            transform.position = Vector3.Lerp(otherPosition, finalPosition, curveValue);
            yield return null;
        }
        transform.position = finalPosition;

        for(int i=0; i<128*2; i++)
        {
            float angle = ((float)i)/32 * 2*Mathf.PI + 0.45f;
            counter -= (4.60f / (128f*2f));
            for(int j=0; j<3; j++)
            {
                float dupeangle = ((float)j)/((float)3) * 2*Mathf.PI;
                Vector3 directionality = new Vector3(Mathf.Cos(angle + dupeangle), Mathf.Sin(angle + dupeangle), 0);
                this.SummonBullet(this.transform.position + (directionality*0.5f), directionality*0.65f, 0);
            }
            while(counter < (4.60f / (128f*2f)))
            {
                yield return null;
            }
        }

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
