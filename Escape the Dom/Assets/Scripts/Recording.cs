using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Recording : MonoBehaviour {

	public Camera playerCam;
	public Camera handCam;
	public Camera screenShotCam;
	public Camera activeCam;
	public GameObject recordingImage;
	public bool canRecord;
	private Renderer renderer;
	// Use this for initialization
	void Start ()
	{
		playerCam = Camera.main;
		activeCam = playerCam;

		recordingImage = GameObject.FindGameObjectWithTag ("Recording");
		foreach (Camera cam in Camera.allCameras) 
		{
			if(cam.tag == "ScreenShotCam")
			{
				screenShotCam = cam;
			}
			if(cam.tag == "HandHeldCam")
			{
				handCam = cam;
			}
		}
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetMouseButtonUp(1) || Input.GetKeyUp(KeyCode.R)){
			OnClickScreenCaptureButton();
		}
	}

	public void OnClickScreenCaptureButton()
	{
		StartCoroutine(UpdateCamera());
	}

	public IEnumerator UpdateCamera()
	{
		renderer = recordingImage.GetComponent<Renderer> ();
		renderer.enabled = false;
		if (canRecord) {
			handCam.enabled = false;
		    CreateRecordedImage ();
			for (int i = 0; i < 10; ++i) {
				if (i % 2 == 0) {
					renderer.enabled = true;
				} else {
					renderer.enabled = false;
				}
				yield return new WaitForSeconds (0.2f);
			}
			handCam.enabled = true;
		}
	}

	public void CreateRecordedImage()
	{
		GameObject obj = GameObject.FindGameObjectWithTag ("ScreenShotUIView");
		// Create a texture the size of the screen, RGB24 format
		int width = Screen.width;
		int height = Screen.height;
		Texture2D texture = new Texture2D(width, height, TextureFormat.RGB24, false );
		
		// Read screen contents into the texture
		texture.ReadPixels( new Rect(0, 0, width, height), 0, 0 );
		texture.Apply();
		
		Sprite image = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100);
		obj.GetComponent<Image> ().sprite = image;
	}
}
