using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	public GUIText scoreText;
	public int score;
	// Use this for initialization
	void Start () {
		UpdateScore ();
	}
	
	// Update is called once per frame
	void UpdateScore () {
		scoreText.text = "Score: " + score;
	}

	public void increaseScore (){
		score++;
		UpdateScore ();
	}

	public void decreaseScore (){
		score--;

		if (score < 0) {
			score = 0;
		}
		UpdateScore ();
	}

}
