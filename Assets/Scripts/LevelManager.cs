using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)) {
			LoadNextScene();
		}
	}

	public void LoadNextScene(){
		var currentSceneIndex = 
				SceneManager.GetActiveScene().buildIndex;
				SceneManager.LoadScene(currentSceneIndex + 1);
	}

	public void LoadPreviousScene(){
		var currentSceneIndex = 
				SceneManager.GetActiveScene().buildIndex;
				SceneManager.LoadScene(currentSceneIndex - 1);
	}
}
