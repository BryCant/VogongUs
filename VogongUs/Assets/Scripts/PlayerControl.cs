using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Animator animator;
    public Transform self;
    public float runSpeed = .1f;
    private float direction = 1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            direction = Input.GetAxisRaw("Horizontal");
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

        /*VECTOR3 THESCALE = SELF.LOCALSCALE;
        THESCALE.X *= SELF.LOCALSCALE.X * DIRECTION;
        SELF.LOCALSCALE = THESCALE;*/

    }
}
