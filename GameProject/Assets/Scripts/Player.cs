﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Mob properties;
    public Animator animator;
    public PlayerItem sword;
    public PlayerItem selectedArtifact = null;

    public float gold = 0.0f;

    List<PlayerItem> artifacts;
    // List<Potions> potions;

    // Detects if any animation is playing except walking and idle
    public bool AnimatorIsPlaying()
    {
        return animator.GetCurrentAnimatorStateInfo(0).IsTag("pauseInput");
    }

    private void Awake()
    {
        sword = new PlayerSword(this);

        // For presentation use only, remove in production
        // properties.propertiesManager.ToggleEffectState(new SlowedEffect(properties.propertiesManager, 10.5f));
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (properties.health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnDrawGizmosSelected()
    {
        Vector3 attackOffset;
        if (animator.GetFloat("VerticalMagnitude") <= 0.0f)
        {
            attackOffset = new Vector3(animator.GetFloat("HorizontalMagnitude") * 0.1f, animator.GetFloat("VerticalMagnitude") * 0.15f, 0.0f);
        }
        else
        {
            attackOffset = new Vector3(animator.GetFloat("HorizontalMagnitude") * 0.1f, animator.GetFloat("VerticalMagnitude") * 0.15f - 0.05f, 0.0f);
        }
        Gizmos.DrawWireSphere(properties.rigidBody.transform.position + attackOffset, 0.08f);
    }
}
