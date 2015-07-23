using UnityEngine;
using System.Collections;

public class ObjHighlighting : MonoBehaviour {

	// Provides a highlight color to object thats being interacted with.
	public GameObject[] parts;
	private Color[] _defaultColors;
	public TempBridge bridge;
	// Use this for initialization
	void Start () {
		_defaultColors = new Color [parts.Length];
		print (_defaultColors.Length);
		print (parts.Length);

		if (parts.Length > 0) 
		{
			for (int i = 0; i < _defaultColors.Length; i++) 
			{
				_defaultColors[i] = parts[i].GetComponent<Renderer>().sharedMaterial.GetColor("_Color");
			}
		}
		bridge = GameObject.Find ("RecordableA_Lvl1_mdl").GetComponent<TempBridge> ();
	}

	// Update is called once per frame
	void Update () {
	
	}

	public void HighlightObject(bool glow)
	{
		if (glow) 
		{
			if (parts.Length > 0) 
			{
				for (int i = 0; i < _defaultColors.Length; i++) 
				{
					parts[i].GetComponent<Renderer>().sharedMaterial.SetColor("_Color", Color.yellow);
					print(parts[i].GetComponent<Renderer>().sharedMaterial.GetColor("_Color"));
					print ("Yes");
				}
			}
		} 
		else 
		{
			if (parts.Length > 0) 
			{
				for (int i = 0; i < _defaultColors.Length; i++) 
				{
					parts[i].GetComponent<Renderer>().sharedMaterial.SetColor("_Color", _defaultColors[i]);
					print(parts[i].GetComponent<Renderer>().sharedMaterial.GetColor("_Color"));
					print ("No");
				}
			}
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
