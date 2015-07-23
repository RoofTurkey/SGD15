using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text timeDisplay;
	public float timer;
	bool started = false;
	bool stopped = false;
		
	void Awake () {
		DontDestroyOnLoad(transform.gameObject);
	}

	void Start () {
		timeDisplay.text = "";
	}

	void Update () {
		string minutes = Mathf.Floor(timer / 60).ToString("00");
		string seconds = Mathf.Floor(timer % 60).ToString("00");

		if (!started) {
			if (Input.anyKeyDown) {
				started = true;
			}
		} else if (!stopped) {
			timer += Time.deltaTime;
			timeDisplay.text = minutes + ":" + seconds;
		}
	}

	public void Finish () {
		stopped = true;
	}
}