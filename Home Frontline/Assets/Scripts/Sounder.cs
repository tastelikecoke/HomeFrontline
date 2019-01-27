using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounder : MonoBehaviour
{
    public AudioSource[] loopList;

    public void LoopSong(int index)
    {
        for(int i=0; i<loopList.Length; i++)
        {
            if(i == index)
            {
                loopList[i].Play();
            }
            else
                loopList[i].Stop();
        }
    }
}
