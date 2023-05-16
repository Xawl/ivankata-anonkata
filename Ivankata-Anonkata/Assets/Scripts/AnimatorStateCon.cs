using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorStateCon : MonoBehaviour
{
    Animator animator;
    int isJumpingHash;
    

    void Start()
    {

        animator = GetComponent<Animator>();
        isJumpingHash = Animator.StringToHash("isJumping");
    }

    // Update is called once per frame
    void Update()
    {
        
        bool isJumping = animator.GetBool(isJumpingHash);
        bool JumpingMovement = Input.GetKeyDown("space");





        if (!isJumping && JumpingMovement )
        {
            animator.SetBool(isJumpingHash, true);
        }

        if (isJumping && !JumpingMovement)
        {
            animator.SetBool(isJumpingHash, false);
        }






    }
}
