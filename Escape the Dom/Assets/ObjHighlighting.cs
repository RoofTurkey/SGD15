using UnityEngine;
using System.Collections;

public class ObjHighlighting : MonoBehaviour {

	// Provides a highlight color to object thats being interacted with.
	private Color startcolor;
	// Use this for initialization
	void Start () {
		startcolor = GetComponent<Renderer> ().material.color;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void CreateTextMessage(string recording)
	{
		print(recording);
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

	void OnMouseExit()
	{

	}
}
