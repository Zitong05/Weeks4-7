using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Animator animator;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        

        // wraping the set float in the if statement locks the last input as the directions on idle!!!
        if (movement.x != 0 || movement.y != 0)
             {
               animator.SetFloat("Horizontal", movement.x);
               
             }

        animator.SetFloat("Speed", movement.sqrMagnitude);

    }

}
