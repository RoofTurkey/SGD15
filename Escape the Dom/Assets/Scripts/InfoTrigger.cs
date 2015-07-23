using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InfoTrigger : MonoBehaviour {

	public AudioClip infoAudio;
	public float volume = 1f;
	AudioSource audioPlayer;
	bool activatable = false;
	GameObject score;
	bool scoreAdded = false;
	Text helpText;

	void Start () {
		audioPlayer = GameObject.Find("MainCam").GetComponent<AudioSource>();
		score = GameObject.Find("Score");
		helpText = GameObject.Find("HelpText").GetComponent<Text>();
	}

	void Update () {
		if (activatable) {
			if (Input.GetKeyDown(KeyCode.E)) {
				audioPlayer.PlayOneShot(infoAudio,volume);
				if (!scoreAdded) {
					score.GetComponent<ScoreCounter>().AddScore();
					scoreAdded = true;
				}
			}
		}
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			activatable = true;
			helpText.text = "Druk op 'E' om de info uit te spreken";
			GameObject.Find("MainCam").GetComponent<Intro>().subtitles.text = "Press 'E' to pronounce information";
		}
	}

	void OnTriggerExit (Collider other) {
		if (other.tag == "Player") {
			helpText.text = "";
			GameObject.Find("MainCam").GetComponent<Intro>().subtitles.text = "";
			activatable = false;
		}
	}
}