﻿using UnityEngine;
using System.Collections;

public class enemyPix : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(-Vector2.right * speed * Time.deltaTime);
    }
}
