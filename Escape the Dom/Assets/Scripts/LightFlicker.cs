using UnityEngine;
using System.Collections;

public class LightFlicker : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
			Light light = this.GetComponent<Light> ();
		if (Random.Range (0, 200) < 50) {
			light.intensity = Random.Range (0.0f, 2.0f);
		}
	}
}
