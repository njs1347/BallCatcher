using UnityEngine;
using System.Collections;

public class decreaseScore : MonoBehaviour {

	private ScoreKeeper scoreKeeper;

	// Use this for initialization
	void Start () {
		GameObject scoreKeeperObject = GameObject.FindWithTag ("ScoreKeeper");
		if (scoreKeeperObject != null) {
			scoreKeeper = scoreKeeperObject.GetComponent <ScoreKeeper> ();
		}
	}
	void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Ball") {
	//		scoreKeeper.decreaseScore ();
			Destroy (col.gameObject);
		}
	}
}
