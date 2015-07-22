using UnityEngine;
using System.Collections;

public class Recording : MonoBehaviour {

	public Camera playerCam;
	public Camera handCam;
	public Camera screenShotCam;

	private Camera activeCam;
	public GameObject obj;
	// Use this for initialization
	void Start ()
	{
		playerCam = Camera.main;
		activeCam = playerCam;

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
		///plane for the screenshot
		obj = GameObject.FindGameObjectWithTag ("ScreenShotView");
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetMouseButtonUp(1) || Input.GetKeyUp(KeyCode.R)){
			OnClickScreenCaptureButton();
		}
	}

	public void ShowPlayerCam() 
	{
		activeCam = playerCam;
	}

	public void showHandCam() 
	{

		activeCam = handCam;
	}

	public void ShowScreenShotCam() 
	{
		activeCam = screenShotCam;
	}

	public void OnClickScreenCaptureButton()
	{
	 	showHandCam ();
		StartCoroutine(StartRecording());
		ShowPlayerCam ();
	}

	private void SetMainCameraScreen()
	{
		//mainCam.targetTexture = 
	}

	public IEnumerator StartRecording()
	{
		   //todo camera switching en todo screenshot van de frontcam
			yield return new WaitForEndOfFrame();

			Renderer renderer = obj.GetComponent<Renderer> ();
		    //int width =  activeCam.pixelWidth;
			//int height = activeCam.pixelHeight;
			Texture tex = renderer.material.mainTexture;
			
		    ShowScreenShotCam ();
			
		//texture.SetPixels (tex.GetPixels ());	
		//texture.Apply();
			//SetMainCameraScreen();
		//	renderer.material.mainTexture = tex;
	}


}
