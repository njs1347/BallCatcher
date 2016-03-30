using UnityEngine;
using System.Collections;

public class ResetObject : MonoBehaviour {
	public GameObject childObject;
	ObjectMover mover;
	float x = 5;

	// Use this for initialization
	void Start () {
		mover = childObject.GetComponent<ObjectMover> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > x) {
			callReset ();
			x += 5;
		}
	}
	void callReset()
	{
		mover.reset ();
		transform.Rotate (0,0,Random.Range(0,360));
		mover.lookAtPlayer ();
	}


	//collision code here
}
