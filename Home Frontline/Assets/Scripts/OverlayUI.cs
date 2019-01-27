using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverlayUI : MonoBehaviour
{
    public Text healthtext;
    public Text nametext;
    public Text scoringtext;
    public GameObject checkpoint;
    public GameObject lighter;
    public Image[] charactericons;
    public void Update()
    {
        healthtext.text = "";
        for(int i=0; i<Manager.Instance.scoring.GetHealth(); i++)
        {
            healthtext.text += "❤";
        }
        for(int i=0; i<4; i++)
        {
            if(charactericons[i] != null)
            if(i == Manager.Instance.scoring.currentCharacterNum)
            {
                charactericons[i].gameObject.SetActive(true);
            }
            else
            {
                charactericons[i].gameObject.SetActive(false);
            }

        }
        switch(Manager.Instance.scoring.currentCharacterNum)
        {
            case 1:
                nametext.text = "Hayabusa";
            break;
            case 2:
                nametext.text = "Kounotori";
            break;
            case 3:
                nametext.text = "Kaguya";
            break;
        }
    }

    public void LightUp()
    {
        StartCoroutine(LightUpCR());
    }
    public IEnumerator LightUpCR()
    {
        float counter = 0f;

        while(counter <= 1f)
        {
            lighter.GetComponent<Image>().color = new Color(256,0,0, 1f - counter);
            counter += Time.deltaTime;
            yield return null;
        }
        yield return null;
    }

    public void CheckpointReached(string stage)
    {
        checkpoint.SetActive(true);
        scoringtext.text = stage;

    }
    public void CheckpointStart()
    {
        checkpoint.SetActive(false);
    }
}
