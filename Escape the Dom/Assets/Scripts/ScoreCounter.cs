using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

	public int playerScore;
	public Text scoreDisplay;

	void Start () {
		playerScore = 0;
		scoreDisplay.text = "";
	}

	public void AddScore () {
		playerScore += 1;
		scoreDisplay.text = "Info " + playerScore + "/5";
	}
}