using UnityEngine;
using System.Collections;

public class CollisionScript : MonoBehaviour {

	public GameObject parentCube;
	public ResetObject resetScript;
	public GameObject scoreKeeper;
	public ScoreKeeper scoreKeeperScript;
	// Use this for initialization
	void Start () {
		parentCube = GameObject.FindWithTag ("Box");
		scoreKeeperScript = scoreKeeper.GetComponent <ScoreKeeper> ();
		resetScript = parentCube.GetComponent <ResetObject> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	public void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "Sides")
		{
			resetScript.callReset ();
			print("decrease");
			//scoreKeeperScript.decreaseScore();
		}
		
		if(col.gameObject.tag == "Box")
		{
			resetScript.callReset ();
			print("increase");
			//scoreKeeperScript.increaseScore();
		}
	}

}
