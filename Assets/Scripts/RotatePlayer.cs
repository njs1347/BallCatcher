using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RotatePlayer : MonoBehaviour {

	float speed = 200f;

	Rigidbody2D myRigidBody;

	public Vector2 velocity;

	public GameObject scoreKeeper;
	public ScoreKeeper scoreKeeperScript;

	// Use this for initialization
	void Start () {

		scoreKeeperScript = scoreKeeper.GetComponent <ScoreKeeper> ();
		myRigidBody = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		float moveAmount = speed * Time.deltaTime;
		print (velocity);
		//myRigidBody.AddTorque (0,0,velocity.x);
		//if (velocity.x != 0) {
			myRigidBody.AddTorque (velocity.x / 50);
			//velocity.x = 0f;
		//}



		if (scoreKeeperScript.score < 10) speed = 200f;
		if (scoreKeeperScript.score <= 19 && scoreKeeperScript.score >= 10)	speed = 180f;
		if (scoreKeeperScript.score <= 29 && scoreKeeperScript.score >= 20)	speed = 160f;
		if (scoreKeeperScript.score <= 39 && scoreKeeperScript.score >= 30)	speed = 140f;
		if (scoreKeeperScript.score <= 49 && scoreKeeperScript.score >= 40)	speed = 120f;
		if (scoreKeeperScript.score <= 59 && scoreKeeperScript.score >= 50)	speed = 100f;
		if (scoreKeeperScript.score <= 69 && scoreKeeperScript.score >= 60)	speed = 80f;
		if (scoreKeeperScript.score <= 79 && scoreKeeperScript.score >= 70)	speed = 60f;
		if (scoreKeeperScript.score <= 89 && scoreKeeperScript.score >= 80)	speed = 40f;
		if (scoreKeeperScript.score <= 99 && scoreKeeperScript.score >= 90)	speed = 20f;
		if (scoreKeeperScript.score >= 100)	speed = 20f;

		

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate(0,moveAmount,0);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate(0,-moveAmount,0);
		}
		
	}


}
