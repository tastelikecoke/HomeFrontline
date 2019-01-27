using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Starter : MonoBehaviour
{
    Scene scenenext;
    public void Clicky()
    {
        SceneManager.LoadScene(1);
    }
}
