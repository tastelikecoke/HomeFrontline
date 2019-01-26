using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject scoutEnemyPrefab;
    public GameObject mainEnemyPrefab;


    public IEnumerator BeginStageOne()
    {
        Manager.Instance.overlayUI.GetComponent<OverlayUI>().CheckpointStart();
        // First Stage Game!
        StartCoroutine(Manager.Instance.playerMover.Respawn(false));
        // two weak shows
        GameObject anyenemy = Instantiate(enemyPrefab);
        anyenemy.GetComponent<BasicEnemy>().color = 2;
        yield return new WaitForSeconds(4.0f);
        anyenemy = Instantiate(scoutEnemyPrefab);
        anyenemy.GetComponent<ScoutEnemy>().color = 4;
        yield return new WaitForSeconds(4.0f);

        // first double
        anyenemy = Instantiate(scoutEnemyPrefab);
        anyenemy.GetComponent<ScoutEnemy>().initialPosition += new Vector3(-1f, 0, 0);
        anyenemy.GetComponent<ScoutEnemy>().color = 1;
        anyenemy = Instantiate(scoutEnemyPrefab);
        anyenemy.GetComponent<ScoutEnemy>().initialPosition += new Vector3(1f, 0, 0);
        anyenemy.GetComponent<ScoutEnemy>().color = 4;
        yield return new WaitForSeconds(4.0f);

        // heavy double!
        anyenemy = Instantiate(enemyPrefab);
        anyenemy.GetComponent<BasicEnemy>().initialPosition += new Vector3(-1f, 0, 0);
        anyenemy.GetComponent<BasicEnemy>().finalPosition += new Vector3(-1f, 0, 0);
        anyenemy.GetComponent<BasicEnemy>().color = 3;
        anyenemy = Instantiate(enemyPrefab);
        anyenemy.GetComponent<BasicEnemy>().initialPosition += new Vector3(1f, 0, 0);
        anyenemy.GetComponent<BasicEnemy>().finalPosition += new Vector3(1f, 0, 0);
        anyenemy.GetComponent<BasicEnemy>().color = 2;
        yield return new WaitForSeconds(4.0f);

        // another heavy double? 
        anyenemy = Instantiate(enemyPrefab);
        anyenemy.GetComponent<BasicEnemy>().initialPosition += new Vector3(-1.5f, 0, 0);
        anyenemy.GetComponent<BasicEnemy>().finalPosition += new Vector3(-1.5f, 0, 0);
        anyenemy.GetComponent<BasicEnemy>().rolls = 64;
        anyenemy.GetComponent<BasicEnemy>().rolldupes = 2;
        anyenemy.GetComponent<BasicEnemy>().gaps = 32f;
        anyenemy.GetComponent<BasicEnemy>().radiansOffset = 0.2f;
        anyenemy.GetComponent<BasicEnemy>().firetime = 1.28f;
        anyenemy.GetComponent<BasicEnemy>().color = 2;

        anyenemy = Instantiate(enemyPrefab);
        anyenemy.GetComponent<BasicEnemy>().initialPosition += new Vector3(1.5f, 0, 0);
        anyenemy.GetComponent<BasicEnemy>().finalPosition += new Vector3(1.5f, 0, 0);
        anyenemy.GetComponent<BasicEnemy>().rolls = 64;
        anyenemy.GetComponent<BasicEnemy>().rolldupes = 2;
        anyenemy.GetComponent<BasicEnemy>().gaps = 32f;
        anyenemy.GetComponent<BasicEnemy>().radiansOffset = 0.2f;
        anyenemy.GetComponent<BasicEnemy>().sign = -1f;
        anyenemy.GetComponent<BasicEnemy>().firetime = 1.28f;
        anyenemy.GetComponent<BasicEnemy>().color = 3;

        // heavy single!!
        yield return new WaitForSeconds(3.0f);
        anyenemy = Instantiate(enemyPrefab);
        anyenemy.GetComponent<BasicEnemy>().rolls = 128;
        anyenemy.GetComponent<BasicEnemy>().rolldupes = 4;
        anyenemy.GetComponent<BasicEnemy>().firetime = 2.56f;
        anyenemy.GetComponent<BasicEnemy>().gaps = 64f;
        anyenemy.GetComponent<BasicEnemy>().radiansOffset = 0.1f;
        anyenemy.GetComponent<BasicEnemy>().color = 5;
        yield return null;

        // disruptive double on heavy single...
        yield return new WaitForSeconds(3.5f);
        anyenemy = Instantiate(enemyPrefab);
        anyenemy.GetComponent<BasicEnemy>().initialPosition += new Vector3(-2.0f, 0, 0);
        anyenemy.GetComponent<BasicEnemy>().finalPosition += new Vector3(-2.0f, 0, 0);
        anyenemy.GetComponent<BasicEnemy>().rolls = 64;
        anyenemy.GetComponent<BasicEnemy>().firetime = 2.56f;
        anyenemy.GetComponent<BasicEnemy>().rolldupes = 2;
        anyenemy.GetComponent<BasicEnemy>().gaps = 32f;
        anyenemy.GetComponent<BasicEnemy>().radiansOffset = 1.2f;
        anyenemy.GetComponent<BasicEnemy>().color = 2;
        anyenemy = Instantiate(enemyPrefab);
        anyenemy.GetComponent<BasicEnemy>().initialPosition += new Vector3(2.0f, 0, 0);
        anyenemy.GetComponent<BasicEnemy>().finalPosition += new Vector3(2.0f, 0, 0);
        anyenemy.GetComponent<BasicEnemy>().rolls = 64;
        anyenemy.GetComponent<BasicEnemy>().rolldupes = 2;
        anyenemy.GetComponent<BasicEnemy>().firetime = 2.56f;
        anyenemy.GetComponent<BasicEnemy>().gaps = 32f;
        anyenemy.GetComponent<BasicEnemy>().radiansOffset = 0.2f;
        anyenemy.GetComponent<BasicEnemy>().sign = -1f;
        anyenemy.GetComponent<BasicEnemy>().color = 4;

        // heavy single
        yield return new WaitForSeconds(4.0f);
        anyenemy = Instantiate(enemyPrefab);
        anyenemy.GetComponent<BasicEnemy>().rolls = 128;
        anyenemy.GetComponent<BasicEnemy>().firetime = 2.56f;
        anyenemy.GetComponent<BasicEnemy>().rolldupes = 4;
        anyenemy.GetComponent<BasicEnemy>().gaps = 64f;
        anyenemy.GetComponent<BasicEnemy>().radiansOffset = 0.5f;
        anyenemy.GetComponent<BasicEnemy>().color = 1;

        // continuous odd circles
        yield return new WaitForSeconds(4.0f);
        anyenemy = Instantiate(enemyPrefab);
        anyenemy.GetComponent<BasicEnemy>().initialPosition += new Vector3(2.0f, 0, 0);
        anyenemy.GetComponent<BasicEnemy>().finalPosition += new Vector3(2.0f, 0, 0);
        anyenemy.GetComponent<BasicEnemy>().rolls = 52;
        anyenemy.GetComponent<BasicEnemy>().rolldupes = 3;
        anyenemy.GetComponent<BasicEnemy>().gaps = 52f;
        anyenemy.GetComponent<BasicEnemy>().firetime = 1.56f;
        anyenemy.GetComponent<BasicEnemy>().sign = -1f;
        anyenemy.GetComponent<BasicEnemy>().color = 0;
        yield return new WaitForSeconds(2.0f);
        anyenemy = Instantiate(enemyPrefab);
        anyenemy.GetComponent<BasicEnemy>().initialPosition += new Vector3(-2.0f, 0, 0);
        anyenemy.GetComponent<BasicEnemy>().finalPosition += new Vector3(-2.0f, 0, 0);
        anyenemy.GetComponent<BasicEnemy>().rolls = 52;
        anyenemy.GetComponent<BasicEnemy>().rolldupes = 3;
        anyenemy.GetComponent<BasicEnemy>().gaps = 52f;
        anyenemy.GetComponent<BasicEnemy>().firetime = 1.56f;
        anyenemy.GetComponent<BasicEnemy>().color = 1;
        yield return new WaitForSeconds(2.0f);
        anyenemy = Instantiate(enemyPrefab);
        anyenemy.GetComponent<BasicEnemy>().initialPosition += new Vector3(2.0f, 0, 0);
        anyenemy.GetComponent<BasicEnemy>().finalPosition += new Vector3(1.0f, 0, 0);
        anyenemy.GetComponent<BasicEnemy>().rolls = 52;
        anyenemy.GetComponent<BasicEnemy>().rolldupes = 3;
        anyenemy.GetComponent<BasicEnemy>().gaps = 52f;
        anyenemy.GetComponent<BasicEnemy>().sign = -1f;
        anyenemy.GetComponent<BasicEnemy>().firetime = 1.56f;
        anyenemy.GetComponent<BasicEnemy>().color = 0;
        yield return new WaitForSeconds(2.0f);
        GameObject enemy16 = Instantiate(enemyPrefab);
        enemy16.GetComponent<BasicEnemy>().initialPosition += new Vector3(-2.0f, 0, 0);
        enemy16.GetComponent<BasicEnemy>().finalPosition += new Vector3(-1.0f, 0, 0);
        enemy16.GetComponent<BasicEnemy>().rolls = 52;
        enemy16.GetComponent<BasicEnemy>().rolldupes = 3;
        enemy16.GetComponent<BasicEnemy>().gaps = 52f;
        enemy16.GetComponent<BasicEnemy>().firetime = 1.56f;
        enemy16.GetComponent<BasicEnemy>().color = 1;
        // odd circles with scouts.
        yield return new WaitForSeconds(1.0f);
        GameObject scout17 = Instantiate(scoutEnemyPrefab);
        scout17.GetComponent<ScoutEnemy>().initialPosition += new Vector3(-2.0f, 0, 0);
        scout17.GetComponent<ScoutEnemy>().scoutEnd = 0.7f;
        scout17.GetComponent<ScoutEnemy>().color = 5;
        yield return new WaitForSeconds(2.0f);
        GameObject enemy17 = Instantiate(enemyPrefab);
        enemy17.GetComponent<BasicEnemy>().initialPosition += new Vector3(2.0f, 0, 0);
        enemy17.GetComponent<BasicEnemy>().finalPosition += new Vector3(2.0f, 0, 0);
        enemy17.GetComponent<BasicEnemy>().rolls = 52;
        enemy17.GetComponent<BasicEnemy>().rolldupes = 3;
        enemy17.GetComponent<BasicEnemy>().gaps = 52f;
        enemy17.GetComponent<BasicEnemy>().sign = -1f;
        enemy17.GetComponent<BasicEnemy>().firetime = 1.56f;
        enemy17.GetComponent<BasicEnemy>().color = 0;
        yield return new WaitForSeconds(1.0f);
        GameObject scout18 = Instantiate(scoutEnemyPrefab);
        scout18.GetComponent<ScoutEnemy>().initialPosition += new Vector3(2.0f, 0, 0);
        scout18.GetComponent<ScoutEnemy>().scoutEnd = 0.7f;
        scout18.GetComponent<ScoutEnemy>().color = 5;
        yield return new WaitForSeconds(2.0f);
        GameObject enemy18 = Instantiate(enemyPrefab);
        enemy18.GetComponent<BasicEnemy>().initialPosition += new Vector3(-2.0f, 0, 0);
        enemy18.GetComponent<BasicEnemy>().finalPosition += new Vector3(-2.0f, 0, 0);
        enemy18.GetComponent<BasicEnemy>().rolls = 52;
        enemy18.GetComponent<BasicEnemy>().rolldupes = 3;
        enemy18.GetComponent<BasicEnemy>().gaps = 52f;
        enemy18.GetComponent<BasicEnemy>().firetime = 1.56f;
        enemy18.GetComponent<BasicEnemy>().color = 1;
        yield return new WaitForSeconds(1.0f);
        GameObject scout19 = Instantiate(scoutEnemyPrefab);
        scout19.GetComponent<ScoutEnemy>().initialPosition += new Vector3(-2.0f, 0, 0);
        scout19.GetComponent<ScoutEnemy>().scoutEnd = 0.7f;
        scout19.GetComponent<ScoutEnemy>().color = 5;
        
        // pressure scouters!!!
        yield return new WaitForSeconds(6.0f);
        GameObject scout20 = Instantiate(scoutEnemyPrefab);
        scout20.GetComponent<ScoutEnemy>().initialPosition += new Vector3(-3.5f, 0, 0);
        scout20.GetComponent<ScoutEnemy>().scoutEnd = 0.8f;
        scout20.GetComponent<ScoutEnemy>().color = 4;
        yield return new WaitForSeconds(1.0f);
        GameObject scout21 = Instantiate(scoutEnemyPrefab);
        scout21.GetComponent<ScoutEnemy>().initialPosition += new Vector3(2f, 0, 0);
        scout21.GetComponent<ScoutEnemy>().scoutEnd = 0.8f;
        yield return new WaitForSeconds(1.0f);
        GameObject scout22 = Instantiate(scoutEnemyPrefab);
        scout22.GetComponent<ScoutEnemy>().initialPosition += new Vector3(-1.0f, 0, 0);
        scout22.GetComponent<ScoutEnemy>().scoutEnd = 0.8f;
        scout22.GetComponent<ScoutEnemy>().color = 4;
        yield return new WaitForSeconds(1.0f);
        GameObject scout23 = Instantiate(scoutEnemyPrefab);
        scout23.GetComponent<ScoutEnemy>().initialPosition += new Vector3(3.0f, 0, 0);
        scout23.GetComponent<ScoutEnemy>().scoutEnd = 0.7f;
        yield return new WaitForSeconds(1.0f);
        GameObject scout24 = Instantiate(scoutEnemyPrefab);
        scout24.GetComponent<ScoutEnemy>().initialPosition += new Vector3(-3.5f, 0, 0);
        scout24.GetComponent<ScoutEnemy>().scoutEnd = 0.7f;
        scout24.GetComponent<ScoutEnemy>().color = 4;
        yield return new WaitForSeconds(1.0f);
        GameObject scout25 = Instantiate(scoutEnemyPrefab);
        scout25.GetComponent<ScoutEnemy>().initialPosition += new Vector3(1.5f, 0, 0);
        scout25.GetComponent<ScoutEnemy>().scoutEnd = 0.6f;
        yield return new WaitForSeconds(1.0f);
        GameObject scout26 = Instantiate(scoutEnemyPrefab);
        scout26.GetComponent<ScoutEnemy>().initialPosition += new Vector3(-3.0f, 0, 0);
        scout26.GetComponent<ScoutEnemy>().scoutEnd = 0.6f;
        scout26.GetComponent<ScoutEnemy>().color = 4;
        yield return new WaitForSeconds(1.0f);
        GameObject scout27 = Instantiate(scoutEnemyPrefab);
        scout27.GetComponent<ScoutEnemy>().initialPosition += new Vector3(2.0f, 0, 0);
        scout27.GetComponent<ScoutEnemy>().scoutEnd = 0.3f;
        scout27.GetComponent<ScoutEnemy>().color = 5;
        yield return new WaitForSeconds(1.0f);
        GameObject scout28 = Instantiate(scoutEnemyPrefab);
        scout28.GetComponent<ScoutEnemy>().scoutEnd = 0.3f;
        scout28.GetComponent<ScoutEnemy>().color = 5;
        yield return new WaitForSeconds(7.0f);

        Manager.Instance.bulletDeleter.DeleteAllBullets();
        Manager.Instance.overlayUI.GetComponent<OverlayUI>().CheckpointReached("Chapter 1: Beginning");
        yield return new WaitForSeconds(6.0f);
    }
    


    public void MakeShootRow(int color=0)
    {
        
        GameObject anyenemy = null;
        for(float i=-5.0f; i<6.0f; i+=1.0f)
        {
            anyenemy = Instantiate(scoutEnemyPrefab);
            anyenemy.GetComponent<ScoutEnemy>().initialPosition += new Vector3(i, 0, 0);
            anyenemy.GetComponent<ScoutEnemy>().scoutFrequency = 0.1f;
            anyenemy.GetComponent<ScoutEnemy>().scoutEnd = 0.7f;
            anyenemy.GetComponent<ScoutEnemy>().color = color;
        }
    }

    public IEnumerator BeginStageTwo()
    {
        Manager.Instance.overlayUI.GetComponent<OverlayUI>().CheckpointStart();
        GameObject anyenemy = null;
        // Second Stage Game!
        StartCoroutine(Manager.Instance.playerMover.Respawn(false));
        // two weak shows
        MakeShootRow(1);
        yield return new WaitForSeconds(3.0f);
        MakeShootRow(2);
        yield return new WaitForSeconds(3.0f);
        MakeShootRow(3);
        yield return new WaitForSeconds(3.0f);
        anyenemy = Instantiate(mainEnemyPrefab);
        yield return new WaitUntil(() => anyenemy == null);
        yield return new WaitForSeconds(4.0f);

        Manager.Instance.overlayUI.GetComponent<OverlayUI>().CheckpointReached("Chapter 2: Wall");
        Manager.Instance.bulletDeleter.DeleteAllBullets();
    }
}
