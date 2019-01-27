using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public Sounder sounder;

    public void Start()
    {
        Manager.instance = this;
        StartCoroutine(MasterCR());
    }
    
    public IEnumerator MasterCR()
    {
        
        sounder.LoopSong(0);
        yield return GoStartDialogOne();
        yield return GoSwitchCharacter();
        sounder.LoopSong(3);
        yield return enemySpawner.BeginStageOne();

        sounder.LoopSong(0);
        yield return GoStartDialogTwo();
        yield return GoSwitchCharacter();
        sounder.LoopSong(2);
        yield return enemySpawner.BeginStageTwo();

        sounder.LoopSong(0);
        yield return GoStartDialogThree();
        yield return GoSwitchCharacter();
        sounder.LoopSong(7);
        yield return enemySpawner.BeginStageThree();

        sounder.LoopSong(1);
        yield return GoStartDialogEnd();

        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
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
    public IEnumerator GoStartDialogThree()
    {
        Time.timeScale = 0f;
        chooseUI.gameObject.SetActive(false);
        novelUI.gameObject.SetActive(true);
        yield return novelUI.GetComponent<NovelUI>().BeginDialogThree();
        yield return new WaitUntil(() => novelUI.gameObject.activeSelf == false);
        Time.timeScale = 1f;
    }
    public IEnumerator GoStartDialogEnd()
    {
        Time.timeScale = 0f;
        chooseUI.gameObject.SetActive(false);
        novelUI.gameObject.SetActive(true);
        yield return novelUI.GetComponent<NovelUI>().BeginDialogEnd();
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

    
    public IEnumerator GoDie()
    {
        Time.timeScale = 0f;
        sounder.LoopSong(1);
        chooseUI.gameObject.SetActive(false);
        novelUI.gameObject.SetActive(true);
        yield return novelUI.GetComponent<NovelUI>().BeginDialogDie();
        yield return new WaitUntil(() => novelUI.gameObject.activeSelf == false);
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
