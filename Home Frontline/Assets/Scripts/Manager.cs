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
    public Canvas novelUI;

    public void Start()
    {
        Manager.instance = this;
        StartCoroutine(MasterCR());
    }
    
    public IEnumerator MasterCR()
    {
        yield return null;
        yield return GoStartDialogOne();
        yield return GoSwitchCharacter();
        yield return enemySpawner.BeginStageOne();
        yield return GoStartDialogTwo();
        yield return GoSwitchCharacter();
        yield return enemySpawner.BeginStageOne();
    }

    public IEnumerator GoStartDialogOne()
    {
        Time.timeScale = 0f;
        chooseUI.gameObject.SetActive(false);
        novelUI.gameObject.SetActive(true);
        yield return novelUI.GetComponent<NovelUI>().BeginDialogOne();
        yield return new WaitUntil(() => novelUI.gameObject.activeSelf == false);
        Time.timeScale = 1f;
    }
    public IEnumerator GoStartDialogTwo()
    {
        Time.timeScale = 0f;
        chooseUI.gameObject.SetActive(false);
        novelUI.gameObject.SetActive(true);
        yield return novelUI.GetComponent<NovelUI>().BeginDialogTwo();
        yield return new WaitUntil(() => novelUI.gameObject.activeSelf == false);
        Time.timeScale = 1f;
    }

    public IEnumerator GoSwitchCharacter()
    {
        Time.timeScale = 0f;
        novelUI.gameObject.SetActive(false);
        chooseUI.gameObject.SetActive(true);
        yield return new WaitUntil(() => chooseUI.gameObject.activeSelf == false);
        Time.timeScale = 1f;
    }
}
