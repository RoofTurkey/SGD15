using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public bool isQuit= false;
	
	
	void OnMouseEnter(){
		GetComponent<Renderer>().material.color = Color.red;
	}
	
	void OnMouseExit(){
		GetComponent<Renderer>().material.color = Color.white;
	}
	
	void OnMouseUp(){
		if (isQuit == true) {
			Application.Quit ();
		} else {
			//go to main camera
		}
	}
}
