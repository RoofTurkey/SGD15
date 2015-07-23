using UnityEngine;
using System.Collections;

public class ObjectManager : MonoBehaviour {

	public string triggerBoxName;

	Interaction callVar;
	ObjPlacementTrigger callTrName;
	public Vector3 positionObj;
	GameObject toBePlacedObj;
	GameObject toBeDestroyed;

	//Arraylist

	// Use this for initialization
	void Start () {

		//interactiveOBJ = "noObjectNameFound";
		triggerBoxName = "noObjectNameFound";

		callVar = GameObject.Find("HandHeldCam").GetComponent<Interaction> ();
		callTrName = GameObject.Find("ObjTrigger").GetComponent<ObjPlacementTrigger> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyUp (KeyCode.E)) {
			//print (triggerBoxName);
			print (callVar.currentObjectName);
			ObjectChecker();

		}
	}

	//oproepen waneer je Place knopje drukt
	public void ObjectChecker(){
		print (callVar.currentObjectName);
		print (callTrName.TriggerBoxName);

		if ((callTrName.TriggerBoxName == callVar.currentObjectName) && (callVar.currentObjectName == "Recordable_Lvl1_mdl") ) {
			//instantie obj
			positionObj = GameObject.Find("RecordableA_Lvl1_mdl").transform.position;
			toBePlacedObj = GameObject.Find("Recordable_Lvl1_mdl");
			toBeDestroyed = GameObject.Find("RecordableA_Lvl1_mdl");

			ObjectPlacer(toBePlacedObj, positionObj, toBeDestroyed);
			//destroy transparent obj;
			print ("Ik zit in de eerste if");
			//dont make it possible to place obj again
		} else if ((callTrName.TriggerBoxName == callVar.currentObjectName) && (callVar.currentObjectName == "Bell_mdl") ) {
			print ("Ik zit in de tweede if");

		} else if ((callTrName.TriggerBoxName == callVar.currentObjectName) && (callVar.currentObjectName == "Recordable_Lvl1_mdl")) {

			print ("Ik zit in de derde if");
			positionObj = GameObject.Find("RecordableA2_Lvl1_mdl").transform.position;
			toBePlacedObj = GameObject.Find("Recordable_Lvl1_mdl");
			toBeDestroyed = GameObject.Find("RecordableA2_Lvl1_mdl");
			
			ObjectPlacer(toBePlacedObj, positionObj, toBeDestroyed);

		} else {
			print ("Ik zit in de laatste else");
		}
	}

	public void ObjectPlacer(GameObject tempObj, Vector3 pos, GameObject tempDest ){
		Instantiate (tempObj, pos, Quaternion.identity);
		Destroy (tempDest);
	}




}
