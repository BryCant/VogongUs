using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Poem_Logic : MonoBehaviour
{
    public GameObject[] DeathAnims;
    public SecondsHolder SH;
    int seconds;

    public Image MainDialogue;
    public Image Choice1;
    public Image Choice2;
    public Image Continue;
    public Sprite[] textBoxes;
    int level = 0;

    // Start is called before the first frame update
    void Start()
    {
        seconds = SH.GetSeconds();
        Debug.Log("Total Seconds: " + seconds);

        MainDialogue.sprite = textBoxes[0];
        MainDialogue.SetNativeSize();
        Choice1.enabled = false;
        Choice2.enabled = false;
        Debug.Log("Level " + level);
    }

    public void Next()
    {
        level++;
        Debug.Log("Level " + level);
        if (level > 0 && level <= 3)
        {
            MainDialogue.sprite = textBoxes[level];
            MainDialogue.SetNativeSize();
        }
        else if(level == 4)
        {
            MainDialogue.sprite = textBoxes[level];
            MainDialogue.SetNativeSize();

            Continue.enabled = false;

            Choice1.enabled = true;
            Choice2.enabled = true;

            Choice1.sprite = textBoxes[5];
            Choice2.sprite = textBoxes[6];

            Choice1.SetNativeSize();
            Choice2.SetNativeSize();
        }
        else if (level == 7)
        {
            Death();
        }
        else if (level == 8)
        {
            Continue.enabled = true;

            Choice1.enabled = false;
            Choice2.enabled = false;

            MainDialogue.sprite = textBoxes[9];
            MainDialogue.SetNativeSize();
        }
        else if (level == 9)
        {
            Continue.enabled = false;

            Choice1.enabled = true;
            Choice2.enabled = true;

            Choice1.sprite = textBoxes[11];
            Choice2.sprite = textBoxes[12];
            Choice1.rectTransform.sizeDelta = new Vector2(Choice1.sprite.rect.width / 1.3f, Choice1.sprite.rect.height / 1.3f);
            Choice2.rectTransform.sizeDelta = new Vector2(Choice2.sprite.rect.width / 2f, Choice2.sprite.rect.height / 2f);

            //Choice1.SetNativeSize();
            //Choice2.SetNativeSize();

            MainDialogue.sprite = textBoxes[10];
            MainDialogue.SetNativeSize();
        }
        else if (level == 10)
        {
            MainDialogue.sprite = textBoxes[13];
            MainDialogue.SetNativeSize();

            Continue.enabled = false;

            Choice1.enabled = true;
            Choice2.enabled = true;

            Choice1.sprite = textBoxes[14];
            Choice2.sprite = textBoxes[16];

            Choice1.SetNativeSize();
            Choice2.SetNativeSize();
        }
        else if (level == 11)
        {
            MainDialogue.sprite = textBoxes[15];
            MainDialogue.SetNativeSize();

            Continue.enabled = true;

            Choice1.enabled = false;
            Choice2.enabled = false;

            level = 6;
        }
        else if (level == 13)
        {
            MainDialogue.sprite = textBoxes[17];
            MainDialogue.SetNativeSize();

            Continue.enabled = true;

            Choice1.enabled = false;
            Choice2.enabled = false;

            level = 6;
        }
    }

    public void Choice1_Next()
    {
        if (level == 4)
        {
            level = 7;
        }
        if (level == 9)
        {
            level = 6;
        }
        if (level == 10)
        {
            level = 10;
        }
        Next();
    }

    public void Choice2_Next()
    {
        if (level == 4)
        {
            level = 6;
        }
        if (level == 9)
        {
            level = 9;
        }
        if (level == 10)
        {
            level = 12;
        }
        Next();
    }

    void Death()
    {
        Debug.Log("You Die");
        Continue.enabled = false;
        MainDialogue.enabled = false;
        Choice1.enabled = false;
        Choice2.enabled = false;
        level = 100;
        if (seconds >= 29)
        {
            DeathAnims[0].SetActive(true);
        }
        else
        {
            DeathAnims[1].SetActive(true);
        }
    }

}
