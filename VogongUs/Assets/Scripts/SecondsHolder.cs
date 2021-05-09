using UnityEngine;

public class SecondsHolder : MonoBehaviour
{
    static public int seconds = 0;

    public int GetSeconds()
    {
        return seconds;
    }
    public void IncSeconds()
    {
        seconds++;
    }
}
