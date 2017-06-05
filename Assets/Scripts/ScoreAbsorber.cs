using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAbsorber : MonoBehaviour {
	
	public int Score;
	// Use this for initialization
	void Start () {
		var oldScoreKeeper = FindObjectOfType<ScoreKeeper>();
		
		if(oldScoreKeeper){
			Score = oldScoreKeeper.Score;
			Destroy(oldScoreKeeper.gameObject);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
