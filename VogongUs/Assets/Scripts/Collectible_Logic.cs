using UnityEngine;

public class Collectible_Logic : MonoBehaviour
{

    public SecondsHolder SecondsGUI;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SecondsGUI.IncSeconds();
            Debug.Log(SecondsGUI.GetSeconds());
            Destroy(gameObject);
        }
    }
}
