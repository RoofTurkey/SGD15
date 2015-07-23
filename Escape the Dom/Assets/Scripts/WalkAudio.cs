using UnityEngine;
using System.Collections;

public class WalkAudio : MonoBehaviour {

	public float audioSpeed = 1f;
	public AudioClip[] sounds;
	AudioSource audioPlayer;
	float timer;

	void Start () {
		audioPlayer = GetComponent<AudioSource>();
	}

	void Update () {
		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) {
			if (Input.GetKey(KeyCode.LeftShift)) {
				if (timer <= 0f) {
					audioPlayer.PlayOneShot(sounds[Random.Range(0,sounds.Length)],1f);
					timer = audioSpeed / 2f;
					timer -= Time.deltaTime;
				} else {
					timer -= Time.deltaTime;
				}
			} else {
				if (timer <= 0f) {
					audioPlayer.PlayOneShot(sounds[Random.Range(0,sounds.Length)],1f);
					timer = audioSpeed;
					timer -= Time.deltaTime;
				} else {
					timer -= Time.deltaTime;
				}
			}
		}
	}
}