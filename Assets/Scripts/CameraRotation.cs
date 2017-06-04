using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float rotationSpeed = 5.0f;
		var camera = GetComponentInChildren<Camera>();

		var mouseX = Input.GetAxis("Mouse X");
		var mouseY = Input.GetAxis("Mouse Y");
		
		transform.localRotation = Quaternion.Euler(0, mouseX, 0) * 
		transform.localRotation ;

		camera.transform.localRotation = Quaternion.Euler(-mouseY * rotationSpeed, 0, 0) * 
		camera.transform.localRotation;
	}
}
