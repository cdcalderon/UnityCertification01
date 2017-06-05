using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	public float TimeTillNextLevel = 0.0f;

  //public float TimeTillNextLevel { get; set; }
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// if(Input.GetKeyDown(KeyCode.Space)) {
		// 	LoadNextScene();
		// }
		if(TimeTillNextLevel > 0) {
			TimeTillNextLevel -= Time.deltaTime;
			if(TimeTillNextLevel < 0) {
				print("Time till next level " + TimeTillNextLevel);
				LoadNextScene();
			}
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
