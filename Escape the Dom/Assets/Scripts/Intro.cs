using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Intro : MonoBehaviour {

	int currentState = 1;
	private int totalStates = 11;
	float timer;
	bool fadeIn = false;
	float fadeSpeed = 1f;
	public GameObject black;
	public Text helpText;
	public string cameraHelpText = "Bestuur de recorder met de juiste toetsencombinatie";
	public Text subtitles;
	public AudioClip audio1;
	public AudioClip audio2;
	public AudioClip audio3;
	public AudioClip audio4;
	public AudioClip audio5;
	public AudioClip audio6;

	void Start () {
		NextState();
		helpText.text = "";
	}

	void Update () {
		if (currentState <= totalStates) {
			timer -= Time.deltaTime;

			if (timer <= 0f) {
				currentState += 1;
				NextState();
			}
		}

		if (fadeIn) {
			black.GetComponent<Image>().color = Color.Lerp(black.GetComponent<Image>().color, Color.clear, fadeSpeed * Time.deltaTime);
			if (black.GetComponent<Image>().color.a <= 0f) {
				fadeIn = false;
			}
		}
	}

	void NextState () {
		switch (currentState) {
		case 1:
			subtitles.text = "Hello and welcome everybody! My name is Evert and I'm here today in the always pretty city of Utrecht for the Dutch Film Festival.";
			GetComponent<AudioSource>().PlayOneShot(audio1,1f);
			timer = 8f;
			break;
		case 2:
			subtitles.text = "*Earthquake*";
			GetComponent<AudioSource>().PlayOneShot(audio2,1f);
			timer = 1f;
			break;
		case 3:
			subtitles.text = "*Screaming*";
			GetComponent<AudioSource>().PlayOneShot(audio3,1f);
			timer = 0.5f;
			break;
		case 4:
			subtitles.text = "";
			timer = 1f;
			break;
		case 5:
			fadeIn = true;
			timer = 1f;
			break;
		case 6:
			subtitles.text = "Dear viewers, due to an earthquake I'm currently stuck at the bottom of the Dom tower. Hopefully I can still make it to the red carpet event in time...";
			GetComponent<AudioSource>().PlayOneShot(audio4,1f);
			timer = 10f;
			break;
		case 7:
			subtitles.text = "";
			timer = 10f;
			break;
		case 8:
			timer = 23f;
			break;
		case 9:
			timer = 4f;
			break;
		case 10:
			subtitles.text = "Let's see if I can get anywhere using some real-life editing. Is there an object somewhere here which I can record?";
			GetComponent<AudioSource>().PlayOneShot(audio6,1f);
			helpText.text = cameraHelpText;
			timer = 10f;
			break;
		case 11:
			subtitles.text = "";
			helpText.text = "";
			break;
		}
	}
}