using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public int health;
    public int currentCharacterNum;
    public int currentScoring;

    [System.Serializable]
    public class Character
    {
        public int maxhealth;
        public float speed;

        private int health;
        public void ResetCharacter()
        {
            health = maxhealth;
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }
    }

    public Character[] characters;

    public void Start()
    {
        for(int i=0;i<characters.Length;i++)
        {
            characters[i].ResetCharacter();
        }
    }

    public void SetCharacter(int characterNum)
    {
        currentCharacterNum = characterNum;
        Manager.Instance.playerMover.speed = characters[currentCharacterNum].speed;
    }

    public void Die()
    {
        characters[currentCharacterNum].Health -= 1;
        Manager.Instance.overlayUI.GetComponent<OverlayUI>().LightUp();
        Manager.Instance.sounder.OneShotMusic(4);
        if(characters[currentCharacterNum].Health <= -1)
        {
            if(characters[1].Health <= -1 && characters[2].Health <= -1 && characters[3].Health <= -1)
            {
                StartCoroutine(Manager.Instance.GoDie());

            }
            else
                StartCoroutine(Manager.Instance.GoSwitchCharacter());
        }
    }

    public int GetHealth()
    {
        return characters[currentCharacterNum].Health;
    }
}
