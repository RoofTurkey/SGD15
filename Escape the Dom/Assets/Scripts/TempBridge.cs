using UnityEngine;
using System.Collections;

public class TempBridge : MonoBehaviour {

	public GameObject recordingTarget;
	public Vector3 positionObj;

	// Use this for initialization
	void Start ()
	{
		recordingTarget = new GameObject ();
		positionObj = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void ShowBridge()
	{
		gameObject.GetComponent<Renderer> ().enabled = true;
	}

	public void HideBridge()
	{
		gameObject.GetComponent<Renderer> ().enabled = false;
	}

	public void DestroyBridge()
	{
		gameObject.GetComponent<Renderer> ().enabled = false;
	}
}
