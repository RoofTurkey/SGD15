using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Interaction : MonoBehaviour 
{
	private const string _cameraRecording = "Recording";
	private float _distance;
	public float maxDistance;
	public Recording recording;
	public ShowBridge bridge;
	public string currentObjectName;

	// Use this for initialization
	public void Start () 
	{ 
		maxDistance = 7.5f;
		recording = GameObject.FindGameObjectWithTag("ScreenShotView").GetComponent<Recording>();
		bridge = GameObject.Find ("BridgeTrigger").GetComponent<ShowBridge> ();
	}

	// Update is called once per frame
	public void Update () 
	{
		Vector3	fwd = transform.TransformDirection(Vector3.right);
		RaycastHit hit;
		//Player now will know if an object is interactable if the raycast hits.
		if (Physics.Raycast (transform.position, fwd, out hit, maxDistance) && hit.transform.tag == "InterActive") 
		{
			hit.transform.SendMessage("HighlightObject", true);
			//inventory add hit.transform
			recording.canRecord = true;
			bridge.hasCopy = true;
		} 
		else 
		{
			foreach (GameObject interActive in GameObject.FindGameObjectsWithTag("InterActive" ))
			{
				ObjHighlighting obj = interActive.GetComponent<ObjHighlighting>();
				obj.HighlightObject(false);
			}
			recording.canRecord = false;
		}
	}

	//takes the name of the object for further checking
	public void CheckObjectName(){
		RaycastHit hitTwo;
		Vector3	fwdTwo = transform.TransformDirection(Vector3.right);

		if (Physics.Raycast (transform.position, fwdTwo, out hitTwo, maxDistance) && hitTwo.transform.tag == "InterActive") 
		{
			currentObjectName = hitTwo.transform.name;
			print(currentObjectName);
		}
	}
}
