using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndGame : MonoBehaviour {

	GameObject score;
	public Text winText;

	void Start () {
		score = GameObject.Find("Score");
		winText.text = "";
	}
	
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			score.GetComponent<Timer>().Finish();
			winText.text = "Gefeliciteerd, je hebt het gehaald! Jou tijd was " + score.GetComponent<Timer>().timeDisplay.text + " en je hebt maar liefst " + score.GetComponent<ScoreCounter>().playerScore + " van de 5 informatiepunten gevonden en afgespeeld!";
		}
	}
}