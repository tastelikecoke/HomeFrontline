using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject scoutEnemyPrefab;
    public void Start()
    {
        StartCoroutine(BeginStage());
    }

    public IEnumerator BeginStage()
    {
        // First Stage Geimu!!

        // two weak shows
        GameObject enemy1 = Instantiate(enemyPrefab);
        yield return new WaitForSeconds(4.0f);
        GameObject enemy2 = Instantiate(scoutEnemyPrefab);
        yield return new WaitForSeconds(4.0f);

        // first double
        GameObject enemy3 = Instantiate(scoutEnemyPrefab);
        enemy3.GetComponent<ScoutEnemy>().initialPosition += new Vector3(-1f, 0, 0);
        GameObject enemy4 = Instantiate(scoutEnemyPrefab);
        enemy4.GetComponent<ScoutEnemy>().initialPosition += new Vector3(1f, 0, 0);
        yield return new WaitForSeconds(4.0f);

        // heavy double!
        GameObject enemy5 = Instantiate(enemyPrefab);
        enemy5.GetComponent<BasicEnemy>().initialPosition += new Vector3(-1f, 0, 0);
        enemy5.GetComponent<BasicEnemy>().finalPosition += new Vector3(-1f, 0, 0);
        GameObject enemy6 = Instantiate(enemyPrefab);
        enemy6.GetComponent<BasicEnemy>().initialPosition += new Vector3(1f, 0, 0);
        enemy6.GetComponent<BasicEnemy>().finalPosition += new Vector3(1f, 0, 0);
        yield return new WaitForSeconds(4.0f);

        // another heavy double? 
        GameObject enemy7 = Instantiate(enemyPrefab);
        enemy7.GetComponent<BasicEnemy>().initialPosition += new Vector3(-1.5f, 0, 0);
        enemy7.GetComponent<BasicEnemy>().finalPosition += new Vector3(-1.5f, 0, 0);
        enemy7.GetComponent<BasicEnemy>().rolls = 64;
        enemy7.GetComponent<BasicEnemy>().rolldupes = 2;
        enemy7.GetComponent<BasicEnemy>().gaps = 32f;
        enemy7.GetComponent<BasicEnemy>().radiansOffset = 0.2f;
        enemy7.GetComponent<BasicEnemy>().firetime = 1.28f;
        GameObject enemy8 = Instantiate(enemyPrefab);
        enemy8.GetComponent<BasicEnemy>().initialPosition += new Vector3(1.5f, 0, 0);
        enemy8.GetComponent<BasicEnemy>().finalPosition += new Vector3(1.5f, 0, 0);
        enemy8.GetComponent<BasicEnemy>().rolls = 64;
        enemy8.GetComponent<BasicEnemy>().rolldupes = 2;
        enemy8.GetComponent<BasicEnemy>().gaps = 32f;
        enemy8.GetComponent<BasicEnemy>().radiansOffset = 0.2f;
        enemy8.GetComponent<BasicEnemy>().sign = -1f;
        enemy8.GetComponent<BasicEnemy>().firetime = 1.28f;

        // heavy single!!
        yield return new WaitForSeconds(3.0f);
        GameObject enemy9 = Instantiate(enemyPrefab);
        enemy9.GetComponent<BasicEnemy>().rolls = 128;
        enemy9.GetComponent<BasicEnemy>().rolldupes = 4;
        enemy9.GetComponent<BasicEnemy>().firetime = 2.56f;
        enemy9.GetComponent<BasicEnemy>().gaps = 64f;
        enemy9.GetComponent<BasicEnemy>().radiansOffset = 0.1f;
        yield return null;

        // disruptive double on heavy single...
        yield return new WaitForSeconds(3.5f);
        GameObject enemy10 = Instantiate(enemyPrefab);
        enemy10.GetComponent<BasicEnemy>().initialPosition += new Vector3(-2.0f, 0, 0);
        enemy10.GetComponent<BasicEnemy>().finalPosition += new Vector3(-2.0f, 0, 0);
        enemy10.GetComponent<BasicEnemy>().rolls = 64;
        enemy10.GetComponent<BasicEnemy>().firetime = 2.56f;
        enemy10.GetComponent<BasicEnemy>().rolldupes = 2;
        enemy10.GetComponent<BasicEnemy>().gaps = 32f;
        enemy10.GetComponent<BasicEnemy>().radiansOffset = 1.2f;
        GameObject enemy11 = Instantiate(enemyPrefab);
        enemy11.GetComponent<BasicEnemy>().initialPosition += new Vector3(2.0f, 0, 0);
        enemy11.GetComponent<BasicEnemy>().finalPosition += new Vector3(2.0f, 0, 0);
        enemy11.GetComponent<BasicEnemy>().rolls = 64;
        enemy11.GetComponent<BasicEnemy>().rolldupes = 2;
        enemy11.GetComponent<BasicEnemy>().firetime = 2.56f;
        enemy11.GetComponent<BasicEnemy>().gaps = 32f;
        enemy11.GetComponent<BasicEnemy>().radiansOffset = 0.2f;
        enemy11.GetComponent<BasicEnemy>().sign = -1f;

        // heavy single
        yield return new WaitForSeconds(4.0f);
        GameObject enemy12 = Instantiate(enemyPrefab);
        enemy12.GetComponent<BasicEnemy>().rolls = 128;
        enemy12.GetComponent<BasicEnemy>().firetime = 2.56f;
        enemy12.GetComponent<BasicEnemy>().rolldupes = 4;
        enemy12.GetComponent<BasicEnemy>().gaps = 64f;
        enemy12.GetComponent<BasicEnemy>().radiansOffset = 0.5f;

        // continuous odd circles
        yield return new WaitForSeconds(4.0f);
        GameObject enemy13 = Instantiate(enemyPrefab);
        enemy13.GetComponent<BasicEnemy>().initialPosition += new Vector3(2.0f, 0, 0);
        enemy13.GetComponent<BasicEnemy>().finalPosition += new Vector3(2.0f, 0, 0);
        enemy13.GetComponent<BasicEnemy>().rolls = 52;
        enemy13.GetComponent<BasicEnemy>().rolldupes = 3;
        enemy13.GetComponent<BasicEnemy>().gaps = 52f;
        enemy13.GetComponent<BasicEnemy>().firetime = 1.56f;
        enemy13.GetComponent<BasicEnemy>().sign = -1f;
        yield return new WaitForSeconds(2.0f);
        GameObject enemy14 = Instantiate(enemyPrefab);
        enemy14.GetComponent<BasicEnemy>().initialPosition += new Vector3(-2.0f, 0, 0);
        enemy14.GetComponent<BasicEnemy>().finalPosition += new Vector3(-2.0f, 0, 0);
        enemy14.GetComponent<BasicEnemy>().rolls = 52;
        enemy14.GetComponent<BasicEnemy>().rolldupes = 3;
        enemy14.GetComponent<BasicEnemy>().gaps = 52f;
        enemy14.GetComponent<BasicEnemy>().firetime = 1.56f;
        yield return new WaitForSeconds(2.0f);
        GameObject enemy15 = Instantiate(enemyPrefab);
        enemy15.GetComponent<BasicEnemy>().initialPosition += new Vector3(2.0f, 0, 0);
        enemy15.GetComponent<BasicEnemy>().finalPosition += new Vector3(1.0f, 0, 0);
        enemy15.GetComponent<BasicEnemy>().rolls = 52;
        enemy15.GetComponent<BasicEnemy>().rolldupes = 3;
        enemy15.GetComponent<BasicEnemy>().gaps = 52f;
        enemy15.GetComponent<BasicEnemy>().sign = -1f;
        enemy15.GetComponent<BasicEnemy>().firetime = 1.56f;
        yield return new WaitForSeconds(2.0f);
        GameObject enemy16 = Instantiate(enemyPrefab);
        enemy16.GetComponent<BasicEnemy>().initialPosition += new Vector3(-2.0f, 0, 0);
        enemy16.GetComponent<BasicEnemy>().finalPosition += new Vector3(-1.0f, 0, 0);
        enemy16.GetComponent<BasicEnemy>().rolls = 52;
        enemy16.GetComponent<BasicEnemy>().rolldupes = 3;
        enemy16.GetComponent<BasicEnemy>().gaps = 52f;
        enemy16.GetComponent<BasicEnemy>().firetime = 1.56f;
        // odd circles with scouts.
        yield return new WaitForSeconds(1.0f);
        GameObject scout17 = Instantiate(scoutEnemyPrefab);
        scout17.GetComponent<ScoutEnemy>().initialPosition += new Vector3(-2.0f, 0, 0);
        scout17.GetComponent<ScoutEnemy>().scoutEnd = 0.7f;
        yield return new WaitForSeconds(2.0f);
        GameObject enemy17 = Instantiate(enemyPrefab);
        enemy17.GetComponent<BasicEnemy>().initialPosition += new Vector3(2.0f, 0, 0);
        enemy17.GetComponent<BasicEnemy>().finalPosition += new Vector3(2.0f, 0, 0);
        enemy17.GetComponent<BasicEnemy>().rolls = 52;
        enemy17.GetComponent<BasicEnemy>().rolldupes = 3;
        enemy17.GetComponent<BasicEnemy>().gaps = 52f;
        enemy17.GetComponent<BasicEnemy>().sign = -1f;
        enemy17.GetComponent<BasicEnemy>().firetime = 1.56f;
        yield return new WaitForSeconds(1.0f);
        GameObject scout18 = Instantiate(scoutEnemyPrefab);
        scout18.GetComponent<ScoutEnemy>().initialPosition += new Vector3(2.0f, 0, 0);
        scout18.GetComponent<ScoutEnemy>().scoutEnd = 0.7f;
        yield return new WaitForSeconds(2.0f);
        GameObject enemy18 = Instantiate(enemyPrefab);
        enemy18.GetComponent<BasicEnemy>().initialPosition += new Vector3(-2.0f, 0, 0);
        enemy18.GetComponent<BasicEnemy>().finalPosition += new Vector3(-2.0f, 0, 0);
        enemy18.GetComponent<BasicEnemy>().rolls = 52;
        enemy18.GetComponent<BasicEnemy>().rolldupes = 3;
        enemy18.GetComponent<BasicEnemy>().gaps = 52f;
        enemy18.GetComponent<BasicEnemy>().firetime = 1.56f;
        yield return new WaitForSeconds(1.0f);
        GameObject scout19 = Instantiate(scoutEnemyPrefab);
        scout19.GetComponent<ScoutEnemy>().initialPosition += new Vector3(-2.0f, 0, 0);
        scout19.GetComponent<ScoutEnemy>().scoutEnd = 0.7f;
        
        // pressure scouters!!!
        yield return new WaitForSeconds(6.0f);
        GameObject scout20 = Instantiate(scoutEnemyPrefab);
        scout20.GetComponent<ScoutEnemy>().initialPosition += new Vector3(-2.5f, 0, 0);
        scout20.GetComponent<ScoutEnemy>().scoutEnd = 0.8f;
        yield return new WaitForSeconds(1.0f);
        GameObject scout21 = Instantiate(scoutEnemyPrefab);
        scout21.GetComponent<ScoutEnemy>().initialPosition += new Vector3(1.5f, 0, 0);
        scout21.GetComponent<ScoutEnemy>().scoutEnd = 0.8f;
        yield return new WaitForSeconds(1.0f);
        GameObject scout22 = Instantiate(scoutEnemyPrefab);
        scout22.GetComponent<ScoutEnemy>().initialPosition += new Vector3(-1.0f, 0, 0);
        scout22.GetComponent<ScoutEnemy>().scoutEnd = 0.8f;
        yield return new WaitForSeconds(1.0f);
        GameObject scout23 = Instantiate(scoutEnemyPrefab);
        scout23.GetComponent<ScoutEnemy>().initialPosition += new Vector3(2.0f, 0, 0);
        scout23.GetComponent<ScoutEnemy>().scoutEnd = 0.7f;
        yield return new WaitForSeconds(1.0f);
        GameObject scout24 = Instantiate(scoutEnemyPrefab);
        scout24.GetComponent<ScoutEnemy>().initialPosition += new Vector3(-2.5f, 0, 0);
        scout24.GetComponent<ScoutEnemy>().scoutEnd = 0.7f;
        yield return new WaitForSeconds(1.0f);
        GameObject scout25 = Instantiate(scoutEnemyPrefab);
        scout25.GetComponent<ScoutEnemy>().initialPosition += new Vector3(1.5f, 0, 0);
        scout25.GetComponent<ScoutEnemy>().scoutEnd = 0.6f;
        yield return new WaitForSeconds(1.0f);
        GameObject scout26 = Instantiate(scoutEnemyPrefab);
        scout26.GetComponent<ScoutEnemy>().initialPosition += new Vector3(-1.0f, 0, 0);
        scout26.GetComponent<ScoutEnemy>().scoutEnd = 0.6f;
        yield return new WaitForSeconds(1.0f);
        GameObject scout27 = Instantiate(scoutEnemyPrefab);
        scout27.GetComponent<ScoutEnemy>().initialPosition += new Vector3(2.0f, 0, 0);
        scout27.GetComponent<ScoutEnemy>().scoutEnd = 0.3f;
        yield return new WaitForSeconds(1.0f);
        GameObject scout28 = Instantiate(scoutEnemyPrefab);
        scout28.GetComponent<ScoutEnemy>().scoutEnd = 0.3f;
        yield return null;
    }
}
