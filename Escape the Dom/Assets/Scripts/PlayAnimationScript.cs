using UnityEngine;
using System.Collections;

public class PlayAnimationScript : MonoBehaviour {

	public GameObject Ground;
	public GameObject Ceiling;
	public GameObject Otherbell;

	public float speed; 
	public float step;
	public bool canPlay;

	// Use this for initialization
	void Start () {
		speed = 1f;
		canPlay = false;
		step = speed * Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (canPlay) {
			Play();
		}
	}

	public void Play(){
	
		Otherbell.transform.position = Vector3.MoveTowards(Otherbell.transform.position, Ceiling.transform.position, step);

		transform.position = Vector3.MoveTowards(transform.position, (Ground.transform.position), step);

	}

}
