using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public PlayerMover playerMover;

    public void Start()
    {
        Manager.instance = this;
    }
}
