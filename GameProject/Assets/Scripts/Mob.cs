﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    public PropertiesManager propertiesManager;
    public Rigidbody2D rigidBody;

    [Header("Stats")]
    public float MAX_HEALTH = 1000;
    public float MAX_MANA = 1000;
    public float MAX_SPEED = 1.0f;

    public float health = 1000;
    public float mana = 1000;
    public float speed = 1.0f;

    public float attackMultiplier = 1f;
    public float physicalAttackMultiplier = 1f;
    public float elementalAttackMultiplier = 1f;
    
    public float damageTakenMultiplier = 1f;
    public float physicalDamageTakenMultiplier = 1f;
    public float elementalDamageTakenMultiplier = 1f;

    public List<EffectState> effectStates = new List<EffectState>();

    private void Awake()
    {
        // Can test effect states like this
        //propertiesManager.ToggleEffectState(new BurningEffect(propertiesManager, 5.0f, 10.5f, 20.0f));
        //propertiesManager.ToggleEffectState(new SlowedEffect(propertiesManager, 10.5f, 0.3f));
        //propertiesManager.ToggleEffectState(new VulnerableEffect(propertiesManager, 10.5f));
        //propertiesManager.ToggleEffectState(new FrozenEffect(propertiesManager, 5.0f, 5.0f));
    }
}
