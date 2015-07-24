using UnityEngine;
using System.Collections;

public class Radio : MonoBehaviour {

	public AudioClip music;

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			GetComponent<AudioSource>().Stop();
		}
	}
}