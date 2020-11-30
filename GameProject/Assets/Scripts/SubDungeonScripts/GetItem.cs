﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{
    public int index;
    public GameObject canvas;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            Player.Instance.hasItems[index] = true;

            switch (index)
            {
                case 0:
                    Player.Instance.artifacts.Add(Player.Instance.playerMagicStaff);
                    break;
                case 1:
                    Player.Instance.artifacts.Add(Player.Instance.playerEtherealPendant);
                    break;
                case 2:
                    Player.Instance.artifacts.Add(Player.Instance.playerDashBoots);
                    break;
                case 3:
                    Player.Instance.artifacts.Add(Player.Instance.playerShield);
                    break;
            }
            canvas.SetActive(true);
            Player.Instance.inputController.detectInput = false;
            Player.Instance.movementController.StopMoving();
            gameObject.SetActive(false);
        }
    }
    
    void Update()
    {
        if (Player.Instance.hasItems[index])
        {
            gameObject.SetActive(false);
        }
    }

    public void Continue()
    {
        canvas.SetActive(false);
        Player.Instance.inputController.detectInput = true;
    }
}
