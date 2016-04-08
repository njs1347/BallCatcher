using UnityEngine;
using System.Collections;

public class RotatePlayer : MonoBehaviour {

	float speed = 200f;
	public GameObject scrollRect;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float moveAmount = speed * Time.deltaTime;
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate(0,moveAmount,0);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate(0,-moveAmount,0);
		}
		scrollRect.GetComponent ();
		
	}


}
