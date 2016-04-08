using UnityEngine;
using System.Collections;

public class ResetObject : MonoBehaviour {
	public GameObject childObject;
	public GameObject parentObject;
	public GameObject particleSystem;
	Quaternion origin;
	ObjectMover mover;
	float x = 5;

	// Use this for initialization
	void Start () {
		mover = childObject.GetComponent<ObjectMover> ();
		origin = particleSystem.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void callReset()
	{
		float rotation = Random.Range (0, 360);
		mover.reset ();
		particleSystem.transform.position =  new Vector3(2.5f,0f,0f);
		parentObject.transform.Rotate (0,0,rotation);
		mover.lookAtPlayer ();
	}
	//collision code here
}
