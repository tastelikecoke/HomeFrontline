using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = new Manager();
            }
            return instance;
        }
    }
    private static Manager instance;
    public Camera gameCam;
    public BulletDeleter bulletDeleter;
    public EnemySpawner enemySpawner;
    public PlayerMover playerMover;
    public Scoring scoring;
    public Canvas chooseUI;
    public Canvas overlayUI;

    public void Start()
    {
        Manager.instance = this;
        enemySpawner.StartStageOne();
        StartCoroutine(GoSwitchCharacter());
    }

    public IEnumerator GoSwitchCharacter()
    {
        Time.timeScale = 0f;
        chooseUI.gameObject.SetActive(true);
        yield return new WaitUntil(() => chooseUI.gameObject.activeSelf == false);
        Time.timeScale = 1f;
    }

    public void GoStageOne()
    {
        Time.timeScale = 1f;
        chooseUI.gameObject.SetActive(false);
    }
}
