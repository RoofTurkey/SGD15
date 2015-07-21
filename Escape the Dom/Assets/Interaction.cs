using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Interaction : MonoBehaviour 
{
	private const string _cameraRecording = "Recording";
	private float _distance;
	public bool canRecord;
	public float maxDistance;

	// Use this for initialization
	public void Start () 
	{ 
		maxDistance = 6.0f;
		canRecord = false;
	}

	// Update is called once per frame
	public void Update () 
	{
		Vector3	fwd = transform.TransformDirection(Vector3.forward);
		RaycastHit hit;
		//Player now will know if an object is interactable if the raycast hits.
		if (Physics.Raycast (transform.position, fwd, out hit, maxDistance) && hit.transform.tag == "InterActive") 
		{
		    hit.transform.SendMessage("highlightObject", true);
			canRecord = true;
		} 
		else 
		{
			foreach (GameObject interActive in GameObject.FindGameObjectsWithTag("InterActive" ))
			{
				ObjHighlighting obj = interActive.GetComponent<ObjHighlighting>();
				obj.highlightObject(false);
			}
			canRecord = false;
		}
	}
}
