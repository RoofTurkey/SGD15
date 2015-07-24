using UnityEngine;
using System.Collections;

public class ObjectManager : MonoBehaviour {

	GameObject[] objPlacementTriggers;
	public Recording recording;

	// Use this for initialization
	void Start () 
	{
		objPlacementTriggers = GameObject.FindGameObjectsWithTag ("ObjectTrigger");
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyUp (KeyCode.E)) {
			ObjectChecker();

		}
	}

	public void ObjectChecker(){

		foreach (GameObject item in objPlacementTriggers)
		{
			ObjPlacementTrigger trigger = item.GetComponent<ObjPlacementTrigger>();
			if(trigger.isActive)
			{
				trigger.connectedObject.gameObject.GetComponent<TempItem>().hasBeenDrawn = true;
				trigger.connectedObject.gameObject.GetComponent<TempItem>().ShowBridge();
				trigger.connectedObject.gameObject.GetComponent<Collider>().enabled = true;
				trigger.connectedObject.transform.GetComponent<Renderer>().material.SetColor("_Color", Color.white);
				trigger.connectedObject.transform.GetComponent<Renderer>().material.mainTexture = trigger.recording.currentObj.GetComponent<Renderer>().material.mainTexture;
			}
		}
	}
}
