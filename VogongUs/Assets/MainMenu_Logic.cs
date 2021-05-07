using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_Logic : MonoBehaviour
{

    public GameObject Charachters;
    public GameObject Instructions;
    public GameObject ChoosePlayer;
    public GameObject HowToPlay;

    // Start is called before the first frame update
    void Start()
    {
        Charachters.SetActive(false);
        Instructions.SetActive(false);
    }

    public void Choose()
    {
        Charachters.SetActive(true);
    }

    public void How()
    {
        Instructions.SetActive(true);
    }

    public void Arthur()
    {
        SceneManager.LoadScene("A_VogonShip");
    }

    public void Ford()
    {
        SceneManager.LoadScene("F_VogonShip");
    }
}
