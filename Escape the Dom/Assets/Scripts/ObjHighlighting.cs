using UnityEngine;
using System.Collections;

public class ObjHighlighting : MonoBehaviour {

	// Provides a highlight color to object thats being interacted with.
	private Color startcolor;
	public TempBridge bridge;
	// Use this for initialization
	void Start () {
		startcolor = GetComponent<Renderer> ().material.color;
		bridge = GameObject.Find ("RecordableA_Lvl1_mdl").GetComponent<TempBridge> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void HighlightObject(bool isHit)
	{
		if (isHit) 
		{
			GetComponent<Renderer>().material.color = Color.yellow;
		} else 
		{
			GetComponent<Renderer>().material.color = startcolor;
		}
	}

	public void ShowPossibleLocation(bool showObj)
	{
		if (showObj) {
			gameObject.SetActive (true);
		} else {
			gameObject.SetActive(false);
		}
	}

	public void InstObject()
	{
		Instantiate (gameObject, bridge.positionObj, Quaternion.identity);
	}
}
