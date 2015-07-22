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
			OnClickScreenCaptureButton();
		}
	}

	public void OnClickScreenCaptureButton()
	{
		StartCoroutine(StartRecording());
	}


	public IEnumerator StartRecording()
	{
		if (rec.canRecord) 
		{
			yield return new WaitForEndOfFrame();

			Application.CaptureScreenshot ("Assets/Resources/Screenshot.png");
			string pathToImage = "Screenshot";
			print ("recording");
			Texture2D texture = Resources.Load(pathToImage)as Texture2D;
			Renderer renderer = GetComponent<Renderer>();
			renderer.material.mainTexture = texture;
			rec.canRecord = false;
		} 
	}



}
