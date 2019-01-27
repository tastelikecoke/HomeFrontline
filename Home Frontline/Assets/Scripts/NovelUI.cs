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
        Exclaim("Miss", "Mexi-Martian immigrants, pretending to be students...!! what a sham!");
        yield return WaitForClick();

        Exclaim("Miss", "Martians. Prepare to DIE!");
        yield return WaitForClick();

        Exclaim("Hayabusa", "Hueee!!");
        yield return WaitForClick();

        ShowSprite(true, -1);
        ShowSprite(false, -1);
        Exclaim("", "Enemies are coming, get ready!");
        yield return WaitForClick();
        Exclaim("", "Use the arrow keys to move!");
        yield return WaitForClick();
        Exclaim("", "Survive to the next stage!");
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
        Exclaim("Bystander", "Yes! We need to clear our home free of mexi-martian immigrants!");
        yield return WaitForClick();
        Exclaim("Man", "Yes! We must clean up our home from martian dirt!");
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


    public IEnumerator BeginDialogThree()
    {
        ShowBg(2);
        ShowSprite(true, 2);
        Exclaim("Kaguya", "uughhh.  We're lost!");
        yield return WaitForClick();
        ShowSprite(false, 1);
        Exclaim("Kounotori", "I'm lost as well...");
        yield return WaitForClick();
        Exclaim("Kaguya", "Is this even the right way home?!");
        yield return WaitForClick();
        ShowSprite(false, 0);
        Exclaim("Hayabusa", "Don't lose hope, guys!  We'll make it!");
        yield return WaitForClick();
        ShowSprite(true, 1);
        Exclaim("Kounotori", "Are you sure?");
        yield return WaitForClick();
        Exclaim("Hayabusa", "No!");
        yield return WaitForClick();
        Exclaim("Kounotori", "Hueeeeee??!");
        yield return WaitForClick();
        ShowSprite(true, 2);
        Exclaim("Kaguya", "Hey guys, let's ask this bearded man for directions.");
        yield return WaitForClick();
        Exclaim("Hayabusa", "That sounds like a good idea!");
        yield return WaitForClick();
        ShowSprite(false, -1);
        Exclaim("Kaguya", "Hello mister. Do you know where is our home?");
        yield return WaitForClick();
        ShowSprite(false, 3);
        Exclaim("Bearded man", "Home? But what is the name of your home?");
        yield return WaitForClick();
        Exclaim("Kaguya", "our home is Earth.");
        yield return WaitForClick();
        Exclaim("Bearded man", "EARTH?! Our home?!");
        yield return WaitForClick();
        Exclaim("Kaguya", "Hueee??");
        yield return WaitForClick();
        Exclaim("Bearded man", "You dare call earth your, and only your home?");
        yield return WaitForClick();
        Exclaim("Bearded man", "You dare call earth your private property?!");
        yield return WaitForClick();
        Exclaim("Kaguya", "I didn't mean to--");
        yield return WaitForClick();
        Exclaim("Bearded man", "Earth should be shared to all of us.");
        yield return WaitForClick();
        Exclaim("Bearded man", "Earth is not your private property!");
        yield return WaitForClick();
        Exclaim("Bearded man", "Stop exploiting the blue marble called Earth!");
        yield return WaitForClick();
        Exclaim("Kaguya", "Hueee??");
        yield return WaitForClick();
        Exclaim("Bearded man", "Expropriate your home! Distribute your wealth!");
        yield return WaitForClick();
        Exclaim("Bearded man", "The revolution shall begun!");
        yield return WaitForClick();
        Exclaim("Bearded man", "And you bourgeoisie students shall die for it!");
        yield return WaitForClick();
        ShowSprite(true, 1);
        Exclaim("Kounotori", "Look at what you did!!");
        yield return WaitForClick();
        ShowSprite(true, 2);
        Exclaim("Kaguya", "Hueee!! I didn't do nothing!");
        yield return WaitForClick();
        Exclaim("Bearded man", "RAAAAHH!");
        yield return WaitForClick();
        Exclaim("Kaguya", "Hueeeeee!!");
        yield return WaitForClick();
        Exclaim("Bearded man", "RAAAAHH!");
        yield return WaitForClick();
        Exclaim("Kaguya", "EEEEEEEE!!");
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

    public IEnumerator BeginDialogEnd()
    {
        ShowBg(5);
        ShowSprite(true, 0);
        ShowSprite(false, -1);
        Exclaim("Hayabusa", "Finally we're home...");
        yield return WaitForClick();
        ShowSprite(true, 1);
        Exclaim("Kounotori", "I'm burning up...");
        yield return WaitForClick();
        ShowSprite(true, 2);
        Exclaim("Kaguya", "Me too...");
        yield return WaitForClick();
        ShowSprite(true, 0);
        Exclaim("Hayabusa", "That's the warmth of our home, guys!");
        yield return WaitForClick();
        ShowSprite(true, -1);
        ShowBg(6);
        Exclaim("Hayabusa", "The hot abrasive gases of the thermosphere...");
        yield return WaitForClick();
        Exclaim("Hayabusa", "The intense cold of the mesosphere...");
        yield return WaitForClick();
        Exclaim("Hayabusa", "The tremendous air pressure of the stratosphere...");
        yield return WaitForClick();
        Exclaim("Hayabusa", "And finally...");
        ShowBg(7);
        yield return WaitForClick();
        Manager.Instance.sounder.OneShotMusic(4);
        Exclaim("", "BLAAAAAMMM!!");
        yield return new WaitForSecondsRealtime(4.0f);
        Exclaim("", "");
        ShowBg(8);
        yield return new WaitForSecondsRealtime(2.0f);
        Exclaim("Homeland Frontline", "by Team Is a Lung");
        yield return new WaitForSecondsRealtime(2.0f);
        Exclaim("Homeland Frontline", "A Global Game Jam Project");
        yield return new WaitForSecondsRealtime(2.0f);
        Exclaim("Programmer", "Jeru Mercado");
        yield return new WaitForSecondsRealtime(2.0f);
        Exclaim("Artist", "Jeru Mercado");
        yield return new WaitForSecondsRealtime(2.0f);
        Exclaim("Audio", "Freesound.org");
        yield return new WaitForSecondsRealtime(2.0f);
        ShowSprite(true, 0);
        yield return WaitForClick();
        Exclaim("Hayabusa", "Thank you for playing!");
        yield return WaitForClick();
        Exclaim("", "Press to restart");
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
