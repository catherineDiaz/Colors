using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UI : MonoBehaviour {

	// Use this for initialization
	Button quit;


	//For if a user collects a power
	GameObject powerUI;
	Button useNow;
	Button useLater;

	//For if a user goes to a portal
	GameObject travelUI;
	Button YesTravelNow;
	Button NoNotNow;

	Universe loadObj;

	GameObject playerObj;
	GameObject player;
	GameObject rollerBall;

	Player playerScript;

	Power ball;

	/**
    	Initializes the UI object

	*/
	void Start () {

		player = GameObject.Find("ThirdPersonController");
		rollerBall = GameObject.Find("RollerBall");
		playerObj = GameObject.Find("Player");
		//ball = GameObject.Find("ballPower").GetComponent<Power>();
		//quit = GameObject.Find("ExitButton").GetComponent<UnityEngine.UI.Button>();
		//quit.onClick.AddListener(() => OnButtonClicked(quit.name));

	}

	/**
    	Loads the UI for if a user touched a power, adds listeners to the buttons, adds
    	power to the power list

	*/
	public void CollectedPower()
	{
		
		powerUI = Instantiate(Resources.Load("powerUI") as GameObject);
		useNow = GameObject.Find("UseNow").GetComponent<UnityEngine.UI.Button>();
		useLater = GameObject.Find("UseLater").GetComponent<UnityEngine.UI.Button>();
		//playerScript.addPowerToList(ball);

	}

	/**
    	Loads the UI for if a user runs into a portal, wanting to travel

	*/
	public void TravelUI()
	{
		travelUI = Instantiate(Resources.Load("travelUI") as GameObject);
		YesTravelNow = GameObject.Find("YesTravelNow").GetComponent<UnityEngine.UI.Button>();
		NoNotNow = GameObject.Find("NoNotNow").GetComponent<UnityEngine.UI.Button>();


	}

	/**
    	Performs a set of actions depending on which button was pressed

	@param name - name of button that was clicked

	*/

	public void useNowClick()
	{
		Debug.Log("Transforming into a ball...");
		ball = GameObject.Find("ballPower").GetComponent<Power>();
		ball.ApplyPower();
		GameObject clone = GameObject.Find("powerUI(Clone)");
		Destroy(clone);
		Debug.Log("Power UI was destroyed");
		Destroy(GameObject.Find("ballPower"));
	}

	public void userLaterClick()
	{
		Debug.Log("Storing the power for later...");
		Destroy(powerUI);
		Destroy(GameObject.Find("ballPower"));
		
	}

	public void ExitClick()
	{
		Debug.Log(name);
		Application.Quit();	
	}

	public void YesTravelNowClick()
	{
		Debug.Log("Traveling to Paint Universe");
		SceneManager.LoadScene("PaintUniverse", LoadSceneMode.Single);

		SceneManager.MoveGameObjectToScene(playerObj, SceneManager.GetSceneByName("PaintUniverse"));
		playerObj.transform.position = new Vector3(-2.5f,1,4);
		player.transform.position = new Vector3(-2.5f,1,4);
		Destroy(travelUI);
		//GameObject.Find("FreeLookCameraRig").GetComponent<UnityStandardAssets.Cameras.FreeLookCam>().Target = player;
	}

	public void NoNotNowClick()
	{
		Destroy(travelUI);
	}



	void Update () {


		
	}
}
