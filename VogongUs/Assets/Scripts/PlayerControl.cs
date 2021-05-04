using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Animator animator;
    public Transform self;
    public float runSpeed = .1f;
    private Vector3 RIGHT_DIRECTION;
    private Vector3 LEFT_DIRECTION;

    private void Start()
    {
        RIGHT_DIRECTION = self.localScale;
        LEFT_DIRECTION = self.localScale;
        LEFT_DIRECTION.x = self.localScale.x * -1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                self.localScale = RIGHT_DIRECTION;
            }
            else
            {
                self.localScale = LEFT_DIRECTION;

            }
            animator.SetBool("isWalking", true);
            self.position = new Vector2(self.position.x + (Input.GetAxisRaw("Horizontal")* runSpeed), self.position.y);
        }
        else if (Input.GetAxisRaw("Vertical") != 0)
        {
            animator.SetBool("isWalking", true);
            self.position = new Vector2(self.position.x, self.position.y + (Input.GetAxisRaw("Vertical") * runSpeed));
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

    }
}
