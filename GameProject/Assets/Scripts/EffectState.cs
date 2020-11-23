﻿using UnityEngine;

public abstract class EffectState
{
    protected Mob mob;
    public bool complete = false;
    protected float effectInitializedTime;

    public EffectState(Mob mob)
    {
        this.mob = mob;
        effectInitializedTime = Time.time;
    }


    /*
     *  Implement Effect(), this is where most of the logic
     *  involving the PropertyManager should be conducted
     */
    protected abstract void Effect();

    /* 
     *  Implement ApplyEffect() to use Effect()
     *  This is where the EffectState should call Effect()
     *  and determine if it is still active
     *  set complete to true once EffectState is no longer active
     */
    public abstract void ApplyEffect();
}