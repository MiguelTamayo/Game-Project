﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubRoom1 : MonoBehaviour
{
    public BlockedWalls left;
    public BlockedWalls right;
    public int index;
    
    void Update()
    {

        if (Player.Instance.hasUpgrades[index])
        {
            left.hasUpgrade = true;
            right.hasUpgrade = true;
        }

        if (AllEnemyDead() || Player.Instance.clearedRooms[index])
        {
            Player.Instance.clearedRooms[index] = true;

            if (left.entranceLeft)
                right.trigger = true;
            else if (right.entranceRight)
                left.trigger = true;
        }
    }

    bool AllEnemyDead()
    {
        bool allDead = true;

        foreach (Enemy enemy in FindObjectsOfType(typeof(Enemy)))
        {
            if (enemy.health > 0)
            {
                return false;
            }
        }

        return allDead;
    }
}
