﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

	public GameObject ballPrefab;
	private float ballSpeed = 5.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")) {
			var gObject = Instantiate(ballPrefab);
			gObject.transform.position = transform.position;
			var rb = gObject.GetComponent<Rigidbody>();
			rb.velocity = Vector3.forward * ballSpeed;
		}
	}
}
