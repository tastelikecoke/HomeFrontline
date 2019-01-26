using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseUI : MonoBehaviour
{
    public void Choose(int choice)
    {
        Manager.Instance.scoring.SetCharacter(choice);
        this.gameObject.SetActive(false);
    }
}
