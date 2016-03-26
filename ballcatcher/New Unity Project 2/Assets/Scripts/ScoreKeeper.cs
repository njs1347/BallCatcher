using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	public float score = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void increaseScore (){
		score++;
	}
	void decreaseScore (){
		score--;

		if (score < 0) {
			score = 0;
		}
	}

}
