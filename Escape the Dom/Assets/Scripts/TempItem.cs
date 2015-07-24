using UnityEngine;
using System.Collections;

public class TempItem : MonoBehaviour {

	public bool isActive;
	public bool hasBeenDrawn;
	public string nameID;
	// Use this for initialization
	void Start ()
	{
		name = nameID;
		hasBeenDrawn = false;
		HideBridge ();
	}

	void Update()
	{
		if (hasBeenDrawn) {
			ShowBridge();
		}
	}

	public void ShowBridge()
	{
		gameObject.GetComponent<Renderer> ().enabled = true;
	}

	public void HideBridge()
	{
		gameObject.GetComponent<Renderer> ().enabled = false;

	}
}
