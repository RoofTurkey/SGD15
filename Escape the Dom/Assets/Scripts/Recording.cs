using UnityEngine;
using System.Collections;

public class Recording : MonoBehaviour {

	public Camera playerCam;
	public Camera handCam;
	public Camera screenShotCam;
	private int test;
	public Camera activeCam;
	public GameObject obj;
	// Use this for initialization
	void Start ()
	{
		test = 0;
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

	public IEnumerator ShowPlayerCam() 
	{
		screenShotCam.enabled = false;
		activeCam = playerCam;
		yield return new WaitForSeconds (4);
	}

	public void showHandCam() 
	{

		activeCam = handCam;
	}

	public IEnumerator ShowScreenShotCam() 
	{
		playerCam.enabled = false;
		activeCam = screenShotCam;
		yield return new WaitForSeconds (4);
	}

	public void OnClickScreenCaptureButton()
	{
		StartCoroutine(UpdateCamera());
		ShowPlayerCam ();
	}

	public IEnumerator UpdateCamera()
	{
		screenShotCam.enabled = true;
		playerCam.enabled = false;

		yield return new WaitForSeconds(4);

		playerCam.enabled = true;
		screenShotCam.enabled = false;
	}
}
