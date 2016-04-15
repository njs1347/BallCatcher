using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class CalculateVelocity : MonoBehaviour, IEndDragHandler // required interface when using the OnEndDrag method.
{
	public GameObject player;
	public UnityEngine.UI.ScrollRect scrollRect;
	// Use this for initialization
	void Start () {
		scrollRect = gameObject.GetComponent<UnityEngine.UI.ScrollRect> ();
	}
	
	// Update is called once per frame
	void Update () {
		//print (gameObject.GetComponent<UnityEngine.UI.ScrollRect> ().velocity);
		//player.GetComponent <RotatePlayer> ().velocity = gameObject.GetComponent<UnityEngine.UI.ScrollRect> ().velocity;
		//scrollRect.OnEndDrag;
		player.GetComponent <RotatePlayer> ().velocity = scrollRect.velocity;
	}

	//Do this when the user stops dragging this UI Element.
	public void OnEndDrag (PointerEventData data) 
	{
		Debug.Log("Stopped dragging " + this.name + "!");
	} 


}
