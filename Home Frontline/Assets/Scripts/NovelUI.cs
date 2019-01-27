using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NovelUI : MonoBehaviour
{
    public Text charNameText;
    public Text dialogText;

    public GameObject[] spriteLefts;
    public GameObject[] spriteRights;
    public GameObject[] bgs;

    public int clicks = 0;

    public void Awake()
    {
        clicks = 0;
    }

    public void Next()
    {
        clicks += 1;
    }

    public void ShowBg(int index)
    {
        for(int i=0;i<bgs.Length; i++)
        {
            if(i != index)
                bgs[i].SetActive(false);
            else
                bgs[i].SetActive(true);
        }
    }
    public void ShowSprite(bool isLeft, int index)
    {
        if(isLeft)
        {
            for(int i=0;i<spriteLefts.Length; i++)
            {
                if(i != index)
                    spriteLefts[i].SetActive(false);
                else
                    spriteLefts[i].SetActive(true);
            }
            
        }
        else
        {
            for(int i=0;i<spriteRights.Length; i++)
            {
                if(i != index)
                    spriteRights[i].SetActive(false);
                else
                    spriteRights[i].SetActive(true);
            }
            
        }
    }

    public void StartDialogOne()
    {
        StartCoroutine(BeginDialogOne());
    }
    public IEnumerator BeginDialogOne()
    {
        ShowSprite(true, -1);
        ShowBg(0);
        ShowSprite(false, -1);
        Exclaim("", "*bell rings*");
        yield return WaitForClick();
        
        ShowSprite(true, 0);
        Exclaim("Hayabusa", "Yaaay! School's over!!");
        yield return WaitForClick();

        Exclaim("Hayabusa", "Let's go home together!");
        yield return WaitForClick();

        ShowSprite(false, 1);
        Exclaim("Kounotori", "Go home club, huh?");
        yield return WaitForClick();

        ShowSprite(true, 2);
        Exclaim("Kaguya", "I wanna go home too.");
        yield return WaitForClick();

        Exclaim("Kounotori", "I'm sure you only want to go home to play video games.");
        yield return WaitForClick();

        Exclaim("Kaguya", "You don't have to call me out...");
        yield return WaitForClick();

        ShowSprite(true, 0);
        ShowSprite(false, -1);
        Exclaim("Hayabusa", "Me, I just want to sleep!");
        yield return WaitForClick();

        ShowSprite(false, 1);
        Exclaim("Kounotori", "same.");
        yield return WaitForClick();

        ShowSprite(false, 2);
        Exclaim("Kaguya", "So are we going home or not?");
        yield return WaitForClick();
    
        Exclaim("Hayabusa", "Let's goooo! Go home!");
        yield return WaitForClick();

        ShowBg(1);
        ShowSprite(true, -1);
        ShowSprite(false, -1);
        Exclaim("", "");
        yield return WaitForClick();

        ShowSprite(true, 0);
        Exclaim("Hayabusa", "...");
        yield return WaitForClick();
        
        ShowSprite(false, 1);
        Exclaim("Kounotori", "The path is blocked...");
        yield return WaitForClick();

        ShowSprite(false, -1);
        Exclaim("Hayabusa", "What's going on here, miss?");
        yield return WaitForClick();

        Exclaim("Miss", "Who are you?");
        yield return WaitForClick();

        Exclaim("Hayabusa", "Ummm, Students of Japan Aerospace Exploration High School?");
        yield return WaitForClick();

        Exclaim("Miss", "Students are not allowed here!");
        yield return WaitForClick();

        Exclaim("Miss", "Get out, or I'll shoot you!");
        yield return WaitForClick();

        Exclaim("Hayabusa", "But we're just going home!");
        yield return WaitForClick();

        Exclaim("Miss", "Lies! Lies!  You are all foreigners! All of you!");
        yield return WaitForClick();
        Exclaim("Miss", "Japanese immigrants, pretending to be students...!! what a sham!");
        yield return WaitForClick();

        Exclaim("Miss", "Prepare to DIE!");
        yield return WaitForClick();

        Exclaim("Hayabusa", "Hueee!!");
        yield return WaitForClick();

        ShowSprite(true, -1);
        ShowSprite(false, -1);
        Exclaim("", "It's time to fight...");
        yield return WaitForClick();

        this.gameObject.SetActive(false);
    }

    public IEnumerator BeginDialogTwo()
    {
        ShowSprite(true, 0);
        Exclaim("Hayabusa", "...");
        yield return WaitForClick();
        ShowSprite(false, 1);
        Exclaim("Kounotori", "Why are people attacking us?");
        yield return WaitForClick();
        Exclaim("Hayabusa", "I don't know...");
        ShowSprite(false, 2);
        yield return WaitForClick();
        Exclaim("Kaguya", "Maybe it has something to do with that gathering?");
        yield return WaitForClick();
        Exclaim("Hayabusa", "Where?");
        yield return WaitForClick();
        Exclaim("Kaguya", "Look over there!");
        ShowSprite(false, -1);
        ShowBg(3);
        yield return WaitForClick();
        Exclaim("Hayabusa", "That's a lot of people...");
        yield return WaitForClick();
        Exclaim("Man", "*shouts* We need to build a WALL!");
        yield return WaitForClick();
        Exclaim("Hayabusa", "Excuse me, a wall?");
        yield return WaitForClick();
        ShowSprite(true, -1);
        Exclaim("Man", "A wall to keep the immigrants out.");
        yield return WaitForClick();
        Exclaim("Bystander", "Yes! We need to clear our home free of immigrants!");
        yield return WaitForClick();
        Exclaim("Man", "Yes! We must clean up our home from dirt!");
        yield return WaitForClick();
        Exclaim("Bystander", "Yes! Since this is OUR home!");
        yield return WaitForClick();
        Exclaim("Everyone", "OUR home!");
        yield return WaitForClick();
        Exclaim("Man", "OUR place!");
        yield return WaitForClick();
        Exclaim("Everyone", "OUR home!");
        yield return WaitForClick();
        Exclaim("Man", "OUR wall!");
        yield return WaitForClick();
        Exclaim("Everyone", "OUR HOME!");
        yield return WaitForClick();
        Exclaim("Man", "OUR WALL!");
        yield return WaitForClick();
        Exclaim("Everyone", "RAAAHHH!");
        yield return WaitForClick();
        Exclaim("Man", "RAAAHHH!");
        yield return WaitForClick();
        ShowSprite(true, 0);
        Exclaim("Hayabusa", "Huee!!! They've gone crazy!");
        yield return WaitForClick();
        ShowSprite(false, 1);
        Exclaim("Kounotori", "They're coming over to fight us!!");
        yield return WaitForClick();
        ShowSprite(true, 2);
        Exclaim("Kaguya", "Let's prepare...");
        yield return WaitForClick();
        this.gameObject.SetActive(false);
    }

    
    public IEnumerator BeginDialogDie()
    {
        ShowBg(4);
        ShowSprite(true, 0);
        Exclaim("Hayabusa", "I can no longer go on...");
        yield return WaitForClick();
        ShowSprite(false, 1);
        Exclaim("Kounotori", "What is home anyway?...");
        yield return WaitForClick();
        ShowSprite(false, -1);
        ShowSprite(true, 2);
        Exclaim("Hayabusa", "Why are we here... just to suffer?");
        yield return WaitForClick();
        ShowSprite(true, -1);
        Exclaim("", "You have failed to go home...");
        yield return WaitForClick();
        Exclaim("", "Press to retry.");
        yield return WaitForClick();
        this.gameObject.SetActive(false);
    }

    public void Exclaim(string charName, string text)
    {
        charNameText.text = charName;
        dialogText.text = text;
    }

    public IEnumerator WaitForClick()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        yield return new WaitUntil(() => this.clicks > 0);
        clicks = 0;
    }
}
