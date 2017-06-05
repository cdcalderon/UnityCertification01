using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {

	//private int score = 0; 
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void IncrementScore(int amount) {
		Score += amount;
		var audioSource = GetComponent<AudioSource>();
		audioSource.Play();

	}

	public int Score = 0;
}
