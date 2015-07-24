using UnityEngine;
using System.Collections;

public class PlayAnimationScript : MonoBehaviour {

	public GameObject Ground;
	public GameObject Ceiling;
	public GameObject Otherbell;
	public float speed, step;
	public Vector3 Yaxis, oldPosition;

	public bool canPlay;

	// Use this for initialization
	void Start () {
		speed = 1f;
		canPlay = true;
		Yaxis = new Vector3(0,30,0);
		oldPosition = transform.position;
		step = speed * Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {

		//transform.position = Vector3.MoveTowards(transform.position, (transform.position += Yaxis), step);
		if (canPlay == true) {
			Play ();
		}
	}

	public void Play(){
	
		Otherbell.transform.position = Vector3.MoveTowards(Otherbell.transform.position, Ceiling.transform.position, step);

		transform.position = Vector3.MoveTowards(transform.position, (Ground.transform.position), step);

	}

}
