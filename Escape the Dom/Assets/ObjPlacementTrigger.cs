using UnityEngine;
using System.Collections;

public class ObjPlacementTrigger : MonoBehaviour {

	public GameObject connectedObject;
	public Recording recording;
	public bool isActive;

	// Use this for initialization
	void Start ()
	{
		isActive = false;
		recording = GameObject.FindGameObjectWithTag("ScreenShotView").GetComponent<Recording>();
	}

	public void OnTriggerEnter(Collider collider)
	{
		isActive = true;
		connectedObject.GetComponent<TempBridge>().isActive = true;
		connectedObject.GetComponent<TempBridge> ().ShowBridge ();
	}
	
	public void OnTriggerExit(Collider collider)
	{
		isActive = false;
		connectedObject.GetComponent<TempBridge>().isActive = false;
		connectedObject.GetComponent<TempBridge> ().HideBridge ();
	}
	
}
