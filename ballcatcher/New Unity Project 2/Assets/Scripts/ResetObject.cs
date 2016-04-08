using UnityEngine;
using System.Collections;

public class ResetObject : MonoBehaviour {
	public GameObject childObject;
	public GameObject parentObject;
	public GameObject particleSystem;
	ObjectMover mover;
	float x = 5;

	// Use this for initialization
	void Start () {
		mover = childObject.GetComponent<ObjectMover> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void callReset()
	{
		mover.reset ();
		particleSystem.transform.position = new Vector3 (2.5f,0,0);
		parentObject.transform.Rotate (0,0,Random.Range(0,360));
		mover.lookAtPlayer ();
	}
	//collision code here
}
