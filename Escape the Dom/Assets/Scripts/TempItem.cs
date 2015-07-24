using UnityEngine;
using System.Collections;

public class TempItem : MonoBehaviour {

	public bool isActive;
	public bool hasBeenDrawn;

	// Use this for initialization
	void Start ()
	{
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
