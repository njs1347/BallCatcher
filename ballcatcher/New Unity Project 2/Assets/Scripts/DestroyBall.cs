using UnityEngine;
using System.Collections;

public class DestroyBall : MonoBehaviour {

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "Ball")
		{
			Destroy(col.gameObject);
		}
	}
}
