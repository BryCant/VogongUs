using UnityEngine;
using UnityEngine.UI;

public class GUI_Logic : MonoBehaviour
{
    public bool isPaused = false;
    public GameObject PauseBtn;
    public GameObject PauseMenu;

    private bool isSound = true;
    public Image SoundObject;
    public Sprite SoundOn;
    public Sprite SoundOff;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        PauseBtn.SetActive(true);
        PauseMenu.SetActive(false);
    }

    public void ShowPauseBtn()
    {
        isPaused = false;
        Time.timeScale = 1f;
        PauseBtn.SetActive(true);
        PauseMenu.SetActive(false);
    }

    public void ShowPauseMenu()
    {
        isPaused = true;
        Time.timeScale = .01f;
        PauseMenu.SetActive(true);
        PauseBtn.SetActive(false);
    }

    public void ToggleSound()
    {
        if(isSound)
        {
            isSound = false;
            SoundObject.sprite = SoundOff;

        }
        else
        {
            isSound = true;
            SoundObject.sprite = SoundOn;
        }
    }

}
