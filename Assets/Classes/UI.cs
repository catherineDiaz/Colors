using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

	// Use this for initialization
	GameObject powerUI;
	Button useNow;
	Button useLater;
	Button quit;
	Player player;
	Power ball;


	/**
    	Initializes the UI object

	*/
	void Start () {

		player = GameObject.Find("Player").GetComponent<Player>();
		ball = GameObject.Find("ballPower").GetComponent<Power>();
		quit = GameObject.Find("ExitButton").GetComponent<UnityEngine.UI.Button>();
		quit.onClick.AddListener(() => OnButtonClicked(quit.name));

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
    	Performs a set of actions depending on which button was pressed

	@param name - name of button that was clicked

	*/
	void OnButtonClicked(string name)
	{

		if(name == "UseNow")
		{
			Debug.Log("Transforming into a ball...");
			ball.ApplyPower();
			Destroy(powerUI);
			Destroy(GameObject.Find("ballPower"));

		}

		if (name == "UseLater")
		{
			Debug.Log("Storing the power for later...");
			Destroy(powerUI);
			Destroy(GameObject.Find("ballPower"));
		}

		if(name == "ExitButton")
		{
			Debug.Log(name);
			Application.Quit();
		}
			
	}


	void Update () {


		
	}
}
