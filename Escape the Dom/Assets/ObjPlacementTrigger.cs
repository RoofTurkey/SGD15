using UnityEngine;
using System.Collections;

public class ObjPlacementTrigger : MonoBehaviour {

	public bool IsActive;
	public GameObject connectedObject;
	public Vector3 rotation;
	public Quaternion test;
	public Recording recording;

	// Use this for initialization
	void Start ()
	{
		test = connectedObject.transform.rotation;
		rotation = new Vector3 (0,90,0);
		recording = GameObject.FindGameObjectWithTag("ScreenShotView").GetComponent<Recording>();
		IsActive = false;
	}

	public void OnTriggerEnter(Collider collider)
	{
		IsActive = true;
	}
	
	public void OnTriggerExit(Collider collider)
	{
		IsActive = false;
	}
	
}
