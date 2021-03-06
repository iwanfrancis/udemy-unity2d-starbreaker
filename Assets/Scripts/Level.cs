﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {

    // Paramaters
    [SerializeField] int breakableBlocks; // Serialized for debug

    // Cached references
    SceneLoader sceneLoader;

    private void Start() {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void CountBlocks() {
        breakableBlocks++;
    }

    public void BlockDestroyed() {
        breakableBlocks--;
        if (breakableBlocks <= 0) {
            sceneLoader.LoadNextScene();
        }
    }
}
