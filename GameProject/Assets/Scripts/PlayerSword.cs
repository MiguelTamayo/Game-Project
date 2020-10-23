﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSword : PlayerItem
{
    public PlayerSword(Player player) : base(player)
    {
    }

    public override void Action()
    {
        Debug.Log("Player Swung Sword");
        player.animator.SetTrigger("SwingSword");
    }

    protected override void EarthAction()
    {
        throw new System.NotImplementedException();
    }

    protected override void FireAction()
    {
        throw new System.NotImplementedException();
    }

    protected override void WaterAction()
    {
        throw new System.NotImplementedException();
    }

    protected override void WindAction()
    {
        throw new System.NotImplementedException();
    }
}