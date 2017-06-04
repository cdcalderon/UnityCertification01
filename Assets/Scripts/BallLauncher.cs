using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {
public GameObject ballPrefab;
public float ballSpeed = 5.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")) {
			var gObject = Instantiate(ballPrefab);
			gObject.transform.position = transform.position;
			var rb = gObject.GetComponent<Rigidbody>();
			var camera = GetComponentInChildren<Camera>();
			rb.velocity = camera.transform.rotation * Vector3.forward * ballSpeed;
		}
	}
}
