﻿using UnityEngine;
using System.Collections;

public class stageManager : MonoBehaviour {
    public float game_rotate = 0.0f;
    private int rotate_time = 0;

    public float add_speed = 0.2f;
    public float fuwa_add_speed = 2.0f;
    public float fuwa_add = 2.0f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        game_rotate = (90 - game_rotate) / 30;
	}
}