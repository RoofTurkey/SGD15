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
		connectedObject.GetComponent<TempItem>().isActive = true;
		connectedObject.GetComponent<TempItem> ().ShowBridge ();
	}
	
	public void OnTriggerExit(Collider collider)
	{
		isActive = false;
		connectedObject.GetComponent<TempItem>().isActive = false;
		connectedObject.GetComponent<TempItem> ().HideBridge ();
	}
	
}
