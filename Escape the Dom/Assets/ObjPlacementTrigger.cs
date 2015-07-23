using UnityEngine;
using System.Collections;

public class ObjPlacementTrigger : MonoBehaviour {

	public bool canPlace;
	public string oldObjName, TriggerBoxName;

	Interaction callVar;

	// Use this for initialization
	void Start () {

		callVar = GameObject.Find("HandHeldCam").GetComponent<Interaction> ();
		//canPlace = false;

			}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter(Collider collider)
	{
		if (gameObject.name == "ObjTrigger") {
			TriggerBoxName = "Recordable_Lvl1_mdl";
			print (TriggerBoxName);
		}

		if (collider.name == "Player") {
			//canPlace = true;
			oldObjName = callVar.currentObjectName;
			//TriggerBoxName = gameObject.transform.name;
			//print (TriggerBoxName + " This is When you walk in");
		}
	}
	
	public void OnTriggerExit(Collider collider)
	{
		if (collider.name == "Player") {
			callVar.currentObjectName = oldObjName;
			TriggerBoxName = "HasNoName";
			//canPlace = false;
		}
	}
	
}
