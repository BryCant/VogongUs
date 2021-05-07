using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible_Logic : MonoBehaviour
{

    public SecondsHolder SecondsGUI;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SecondsGUI.seconds++;
            Debug.Log(SecondsGUI.seconds);
            Destroy(gameObject);
        }
    }
}
