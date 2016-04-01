using UnityEngine;
using System.Collections;

public class DestroyBall : MonoBehaviour {

	private ResetObject resetObject;

	void Start ()
	{
		GameObject reset = GameObject.FindWithTag ("Ball");
		if (reset != null) {
			resetObject = reset.GetComponent <ResetObject> ();
		}
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "Ball")
		{
			resetObject.callReset();
		}
	}
}
