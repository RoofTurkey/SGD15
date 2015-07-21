using UnityEngine;
using System.Collections;

public class Recording : MonoBehaviour {

	Interaction rec;

	// Use this for initialization
	void Start () {
		rec = GameObject.Find ("HandHeldCam").GetComponent<Interaction> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("r")){
			print("I am recording");
			StartRecording(rec.canRecord);
		}
	}



	public void StartRecording(bool canRecord) {
		print("insideRecordingMethod");
		if (rec.canRecord) {

			Application.CaptureScreenshot ("Assets/Resources/Screenshot.png");
			print("khebt geprint");
			string pathToImage = "Screenshot";
			print (pathToImage);

			Texture2D texture = Resources.Load(pathToImage)as Texture2D;

			print (texture);
			Renderer renderer = GetComponent<Renderer>();
			renderer.material.mainTexture = texture;
			//GetComponent<Renderer>().material.color = pathToImage;


			rec.canRecord = false;
		} else {

		}
	}



}
