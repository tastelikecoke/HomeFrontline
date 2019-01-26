using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NovelUI : MonoBehaviour
{
    public Text charNameText;
    public Text dialogText;

    public int clicks = 0;

    public void Awake()
    {
        clicks = 0;
    }

    public void Next()
    {
        clicks += 1;
    }

    public void StartDialogOne()
    {
        StartCoroutine(BeginDialogOne());
    }
    public IEnumerator BeginDialogOne()
    {
        Exclaim("", "*bell rings*");
        yield return WaitForClick();
        
        Exclaim("Char1", "Yaaay! School's over!!");
        yield return WaitForClick();

        Exclaim("Char1", "Let's go home together!");
        yield return WaitForClick();

        Exclaim("Char2", "Go home club, huh?");
        yield return WaitForClick();

        Exclaim("Char3", "I wanna go home too.");
        yield return WaitForClick();

        Exclaim("Char2", "I'm sure you only want to go home to play video games.");
        yield return WaitForClick();

        Exclaim("Char3", "You don't have to call me out...");
        yield return WaitForClick();

        Exclaim("Char1", "Me, I just want to sleep!");
        yield return WaitForClick();

        Exclaim("Char2", "same.");
        yield return WaitForClick();

        Exclaim("Char3", "So are we going home or not?");
        yield return WaitForClick();
    
        Exclaim("Char1", "Let's goooo! Go home!");
        yield return WaitForClick();

        Exclaim("", "");
        yield return WaitForClick();

        Exclaim("Char1", "...");
        yield return WaitForClick();
        
        Exclaim("Char2", "The path is blocked...");
        yield return WaitForClick();

        Exclaim("Char1", "What's going on here, miss?");
        yield return WaitForClick();

        Exclaim("Miss", "Who are you?");
        yield return WaitForClick();

        Exclaim("Char1", "Ummm, Students of Andromerica High School?");
        yield return WaitForClick();

        Exclaim("Miss", "Students are not allowed here!");
        yield return WaitForClick();

        Exclaim("Miss", "Get out, or I'll shoot you!");
        yield return WaitForClick();

        Exclaim("Char1", "But we're just going home!");
        yield return WaitForClick();

        Exclaim("Miss", "Lies! Lies!  You are all foreigners! All of you!");
        yield return WaitForClick();
        Exclaim("Miss", "Japanese spies, pretending to be students...!! what a sham!");
        yield return WaitForClick();

        Exclaim("Miss", "Prepare to DIE!");
        yield return WaitForClick();

        Exclaim("Char1", "Hueee!!");
        yield return WaitForClick();

        this.gameObject.SetActive(false);
    }

    public IEnumerator BeginDialogTwo()
    {
        Exclaim("Char1", "...");
        yield return WaitForClick();
        Exclaim("Char2", "Why are people attacking us?");
        yield return WaitForClick();
        Exclaim("Char1", "I don't know...");
        yield return WaitForClick();
        Exclaim("Char3", "Maybe it has something to do with that gathering?");
        yield return WaitForClick();
        Exclaim("Char3", "Where?");
        yield return WaitForClick();
        Exclaim("Char3", "Look over there!");
        yield return WaitForClick();
        Exclaim("Mister", "We need to build a WALL!");
        yield return WaitForClick();
        Exclaim("Char1", "Excuse me, a wall?");
        yield return WaitForClick();
        Exclaim("Mister1", "A wall to keep the immigrants out.");
        yield return WaitForClick();
        Exclaim("Mister2", "Yes! We need to clear our home free of immigrants!");
        yield return WaitForClick();
        Exclaim("Mister1", "Yes! We must clean up our home!");
        yield return WaitForClick();
        Exclaim("Mister2", "Yes! You will not replace us!");
        yield return WaitForClick();
        Exclaim("Mister1", "Yes! This is OUR home!");
        yield return WaitForClick();
        Exclaim("Mister2", "OUR home!");
        yield return WaitForClick();
        Exclaim("Mister1", "OUR place!");
        yield return WaitForClick();
        Exclaim("Mister2", "OUR home!");
        yield return WaitForClick();
        Exclaim("Mister1", "OUR rights!");
        yield return WaitForClick();
        Exclaim("Mister2", "OUR home!");
        yield return WaitForClick();
        Exclaim("Mister1", "OUR race!");
        yield return WaitForClick();
        Exclaim("Mister2", "RAAAHHH!");
        yield return WaitForClick();
        Exclaim("Everyone", "RAAAHHH!");
        yield return WaitForClick();
        Exclaim("Char1", "Hiii!!! They've gone crazy!");
        yield return WaitForClick();
        Exclaim("Char2", "They're coming over to fight us!!");
        yield return WaitForClick();
        Exclaim("Char3", "Let's prepare...");
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
        yield return new WaitForSecondsRealtime(0.5f);
        yield return new WaitUntil(() => this.clicks > 0);
        clicks = 0;
    }
}
