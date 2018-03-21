using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour {

	// Use this for initialization
	Button quit;
	Player player;
	Power ball;

	//For if a user collects a power
	GameObject powerUI;
	Button useNow;
	Button useLater;

	//For if a user goes to a portal
	GameObject travelUI;
	Button YesTravelNow;
	Button NoNotNow;

	Universe loadObj;




	/**
    	Initializes the UI object

	*/
	void Start () {

		player = GameObject.Find("Player").GetComponent<Player>();
		ball = GameObject.Find("ballPower").GetComponent<Power>();
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
		useNow.onClick.AddListener(() => OnButtonClicked(useNow.name)); 
		useLater.onClick.AddListener(() => OnButtonClicked(useLater.name));
		player.addPowerToList(ball);

	}

	/**
    	Loads the UI for if a user runs into a portal, wanting to travel

	*/
	public void TravelUI()
	{
		travelUI = Instantiate(Resources.Load("travelUI") as GameObject);
		YesTravelNow = GameObject.Find("YesTravelNow").GetComponent<UnityEngine.UI.Button>();
		NoNotNow = GameObject.Find("NoNotNow").GetComponent<UnityEngine.UI.Button>();
		YesTravelNow.onClick.AddListener(() => OnButtonClicked(YesTravelNow.name)); 
		NoNotNow.onClick.AddListener(() => OnButtonClicked(NoNotNow.name));


	}





		
	/**
    	Performs a set of actions depending on which button was pressed

	@param name - name of button that was clicked

	*/
	void OnButtonClicked(string name)
	{


		switch (name) {
		case "UseNow":
			Debug.Log("Transforming into a ball...");
			ball.ApplyPower();
			Destroy(powerUI);
			Destroy(GameObject.Find("ballPower"));
			break;

		case "UseLater":
			Debug.Log("Storing the power for later...");
			Destroy(powerUI);
			Destroy(GameObject.Find("ballPower"));
			break;

		case "Exit":
			Debug.Log(name);
			Application.Quit();
			break;

		case "YesTravelNow":
			Debug.Log("Traveling to Paint Universe");
			Scene sceneToLoad = SceneManager.GetSceneByName("PaintUniverse");
			SceneManager.LoadScene(sceneToLoad.name, LoadSceneMode.Additive);
			Destroy(travelUI);
			loadObj.loadSceneObjects(sceneToLoad);

			break;
		case "NoNotNow":
			Destroy(travelUI);
			break;
		default:
			Debug.Log("No Action for Button");
			break;
		}
			
			
	}


	void Update () {


		
	}
}
