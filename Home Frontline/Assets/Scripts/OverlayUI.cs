using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverlayUI : MonoBehaviour
{
    public Text healthtext;
    public Text scoringtext;
    public GameObject checkpoint;
    public void Update()
    {
        healthtext.text = "";
        for(int i=0; i<Manager.Instance.scoring.GetHealth(); i++)
        {
            healthtext.text += "❤";
        }
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
