using UnityEngine;
using System.Collections;

public class ShowBridge : MonoBehaviour {

	private bool makeCpy;
	public TempBridge nonRecordableObj;
	public ObjHighlighting recordableObj;

	// Use this for initialization
	void Start () {
		makeCpy = false;

		recordableObj = GameObject.Find ("Recordable_Lvl1_mdl").GetComponent<ObjHighlighting> ();
		nonRecordableObj = GameObject.Find ("RecordableA_Lvl1_mdl").GetComponent<TempBridge> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyUp (KeyCode.E) && makeCpy) {
			nonRecordableObj.DestroyBridge();
			recordableObj.InstObject();
			makeCpy = false;
		}
	}

	public void OnTriggerEnter(Collider collider)
	{
		if (collider.name == "Player") {
			makeCpy = true;
			nonRecordableObj.ShowBridge();
		}
	}

	public void OnTriggerExit(Collider collider)
	{
		if (collider.name == "Player") {
			makeCpy = false;
			nonRecordableObj.HideBridge();
		}
	}
}
