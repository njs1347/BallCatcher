using UnityEngine;
using System.Collections;

public class increaseScore : MonoBehaviour {


	private ScoreKeeper scoreKeeper;
	// Use this for initialization
	void Start () {
		GameObject scoreKeeperObject = GameObject.FindWithTag ("ScoreKeeper");
		if (scoreKeeperObject != null) {
			scoreKeeper = scoreKeeperObject.GetComponent <ScoreKeeper> ();
		}
	}
	
	// Update is called once per frame
	void OnColllisionrEnter (Collision col){
		if (col.gameObject.tag == "Ball") {
			//scoreKeeper.increaseScore();
			Destroy (gameObject);
		}
	}
}
