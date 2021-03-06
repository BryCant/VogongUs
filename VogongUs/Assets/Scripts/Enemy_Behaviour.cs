using UnityEngine;
using Pathfinding;
using UnityEngine.SceneManagement;

public class Enemy_Behaviour : MonoBehaviour
{

    public AIPath aiPath;
    public GameObject VogonGFX;

    public SecondsHolder SH;

    public Transform target;
    public float minDistance = 1f;
    private float mindDistanceInc = 5f;
    private Vector3 startPosition;


    private void Start()
    {
        startPosition = transform.position;
        mindDistanceInc = minDistance * 5;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) < minDistance)
        {
            aiPath.canMove = true;
            if (aiPath.desiredVelocity.x >= 0.01f)
            {
                VogonGFX.transform.localScale = new Vector3(1f, 1f, 1f);
            }
            else if (aiPath.desiredVelocity.x <= 0.01f)
            {
                VogonGFX.transform.localScale = new Vector3(-1f, 1f, 1f);
            }
        }
        else
        {
            aiPath.canMove = false;
            if(Vector2.Distance(transform.position, startPosition) < (minDistance * 1.5))
            {
                transform.position = Vector2.MoveTowards(transform.position, startPosition, 1 * Time.deltaTime);
            }
        }
        

        if (SH.GetSeconds() > 15)
        {
            minDistance = mindDistanceInc;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Poem");
        }
    }

}
