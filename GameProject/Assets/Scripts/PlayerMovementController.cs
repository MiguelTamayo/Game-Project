﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public Player player;
    public Animator animator;

    public bool moveUp, moveDown, moveLeft, moveRight = false;

    private void Move()
    {
        float verticalVelocity = player.speed * ((moveUp ? 1 : 0) + (moveDown ? -1 : 0));
        float horizontalVelocity = player.speed * ((moveRight ? 1 : 0) + (moveLeft ? -1 : 0));

        Vector2 newVelocity = new Vector2(horizontalVelocity, verticalVelocity);
        player.rigidBody.velocity = newVelocity;

        bool playerIsMoving = newVelocity != Vector2.zero;

        animator.SetBool("Moving", playerIsMoving);
        if (playerIsMoving)
        {
            animator.SetFloat("HorizontalMagnitude", horizontalVelocity);
            animator.SetFloat("VerticalMagnitude", verticalVelocity);
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

}
