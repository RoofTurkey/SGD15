using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FPSDisplay : MonoBehaviour {

	public Text displayerOfTheFPS;
	float actualFPS;
	string fps;
	bool on = false;

	void Start () {
		displayerOfTheFPS.text = "";
	}
	
	void Update () {
		if (on) {
			actualFPS = 1 / Time.deltaTime;
			fps = actualFPS.ToString("00");
			displayerOfTheFPS.text = "FPS: " + fps;
		}

		if (Input.GetKeyDown(KeyCode.U)) {
			on = !on;
			if (!on) {
				displayerOfTheFPS.text = "";
			}
		}
	}
}