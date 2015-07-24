using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	void Start () {
		Time.timeScale = 0f;
	}

	public void StartGame () {
		Time.timeScale = 1f;
	}
}