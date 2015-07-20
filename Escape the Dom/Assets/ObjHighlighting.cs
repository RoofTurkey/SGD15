using UnityEngine;
using System.Collections;

public class ObjHighlighting : MonoBehaviour {

	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Provides a highlight color to object thats being interacted with.
	private Color startcolor;

	void highlightObject(bool doestHit)
	{
		if (doestHit) {
			startcolor = GetComponent<Renderer> ().material.color;
			GetComponent<Renderer> ().material.color = Color.yellow;
		} else {
			GetComponent<Renderer>().material.color = startcolor;
		}
	}

	void OnMouseExit()
	{

	}
}
