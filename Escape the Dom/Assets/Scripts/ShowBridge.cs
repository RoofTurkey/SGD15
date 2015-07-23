using UnityEngine;
using System.Collections;

public class ShowBridge : MonoBehaviour {

	private bool makeCopy;
	public bool hasCopy;
	public TempBridge nonRecordableObj;
	public ObjHighlighting recordableObj;

	// Use this for initialization
	void Start () {
		makeCopy = false;
		hasCopy = false;
		recordableObj = GameObject.Find ("Recordable_Lvl1_mdl").GetComponent<ObjHighlighting> ();
		nonRecordableObj = GameObject.Find ("RecordableA_Lvl1_mdl").GetComponent<TempBridge> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyUp (KeyCode.E) && hasCopy) {
			nonRecordableObj.DestroyBridge();
			recordableObj.InstObject();
			makeCopy = false;
			hasCopy = false;
		}
	}

	public void OnTriggerEnter(Collider collider)
	{
		if (collider.name == "Player") {
			makeCopy = true;
			nonRecordableObj.ShowBridge();
		}
	}

	public void OnTriggerExit(Collider collider)
	{
		if (collider.name == "Player") {
			makeCopy = false;
			nonRecordableObj.HideBridge();
		}
	}
}
