using UnityEngine;
using System.Collections;

public class ObjectMover : MonoBehaviour {

	float speed = 5f;

	public GameObject player;
	// Use this for initialization
	void Start () {
		gameObject.transform.LookAt (player.transform);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * Time.deltaTime * speed);
	
	}
}
