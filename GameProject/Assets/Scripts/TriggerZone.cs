﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerZone : MonoBehaviour
{
    public GameSceneManager sceneManager;
    public string scene;
    public Vector3 location;

    void OnTriggerEnter2D (Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            sceneManager.LoadSceneMovePlayer(scene, location);
        }
    }

    void PickRandomScene(string[] sceneList)
    {
        System.Random rnd = new System.Random();
        int num = rnd.Next(0, sceneList.Length);
        scene = sceneList[num];
    }

    void PickRandomLocation(Vector3[] locList)
    {
        System.Random rnd = new System.Random();
        int num = rnd.Next(0, locList.Length);
        location = locList[num];
    }


    private void Awake()
    {
        if (scene == "Random")
        {
            PickRandomScene(new string[] { "Forest scene 3", "Forest scene 4", "Forest scene 5" });
        }

        if (SceneManager.GetActiveScene().name == "Forest scene 2")
        {
            if (scene == "Forest scene 3")
            {
                location = new Vector3(1.25f, -2.25f, 0.0f);
            }

            if (scene == "Forest scene 4")
            {
                location = new Vector3(-1.9f, -2.25f, 0.0f);
            }

            if (scene == "Forest scene 5")
            {
                location = new Vector3(1.25f, -2.25f, 0.0f);
            }
        }

        if (SceneManager.GetActiveScene().name == "Forest scene 6")
        {
            if (scene == "Forest scene 3")
            {
                location = new Vector3(-1.3f, 1.04f, 0.0f);
            }

            if (scene == "Forest scene 4")
            {
                location = new Vector3(1.59f, 1.04f, 0.0f);
            }

            if (scene == "Forest scene 5")
            {
                location = new Vector3(-1.0f, 1.07f, 0.0f);
            }
        }

        if (SceneManager.GetActiveScene().name == "Forest scene 3")
        {
            Vector3 left = new Vector3 (-1.58f, 0.85f, 0.0f);
            Vector3 mid = new Vector3(0.0f, 0.85f, 0.0f);
            Vector3 right = new Vector3(1.61f, 0.85f, 0.0f);
            PickRandomLocation(new Vector3[] { left, mid, right }); // seems to usually pick mid?
        }
    }
}
