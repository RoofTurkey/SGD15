using UnityEngine;
using System.Collections;

public class ObjHighlighting : MonoBehaviour {

	// Provides a highlight color to object thats being interacted with.
	private Color startColor;
	// Use this for initialization
	void Start () {
		startColor = GetComponent<Renderer> ().material.GetColor ("_Color");
	}

	public void HighlightObject(bool glow)
	{
		if (glow) 
		{
			GetComponent<Renderer>().material.SetColor("_Color", Color.red);
		} 
		else 
		{
			GetComponent<Renderer>().material.SetColor("_Color", startColor);
		}
	}
}
