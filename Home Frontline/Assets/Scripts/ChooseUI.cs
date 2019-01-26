using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseUI : MonoBehaviour
{
    public Image[] characterImages;
    public Button[] characterButtons;

    public void Update()
    {
        for(int i=1; i<4; i++)
        {
            Scoring.Character c = Manager.Instance.scoring.characters[i];
            if(c.Health <= -1)
            {
                characterImages[i].color = new Color(128, 128, 128, 0.5f);
                characterButtons[i].gameObject.SetActive(false);
            }
            else
            {
                characterImages[i].color = new Color(256, 256, 256, 1);
                characterButtons[i].gameObject.SetActive(true);

            }
        }
    }

    public void Choose(int choice)
    {
        Manager.Instance.scoring.SetCharacter(choice);
        this.gameObject.SetActive(false);
    }
}
