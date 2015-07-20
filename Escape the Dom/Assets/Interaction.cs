using UnityEngine;
using System.Collections;

public class Interaction : MonoBehaviour {

	public float hitDistance = 3.0f;

	// Use this for initialization
	void Start () {
	
	}

	Vector3 fwd = transform.TransformDirection(Vector3.forward);

	// Update is called once per frame
	void Update () {
	
		//Nirish : Player now will know if an object is interactable if the raycast hits.
		if (Physics.Raycast (transform.position, fwd, hitDistance)) {
			print ("There is something in front of the object!");
		} else {
			print ("There is no interactable object infront of me!");
		}

	}



}
