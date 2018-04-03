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

	//For if a user gets paint token
	GameObject tokenUIPaint;
	Button GoingBackHomeFromPaint;

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
    	Loads the UI for if a user collects the token at the end of a level

	*/
	public void TokenUIPaint()
	{
		tokenUIPaint = Instantiate(Resources.Load("tokenUIPaint") as GameObject);
		//GoingBackHomeFromPaint = GameObject.Find("GoingBackHomeFromPaint").GetComponent<UnityEngine.UI.Button>();
	}

	/**
    	If the user clicks the use now button, then apply the ball power to the player

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


	/**
    	If the user clicks the use later button, then store the power for later

	*/
	public void userLaterClick()
	{
		Debug.Log("Storing the power for later...");
		Destroy(powerUI);
		Destroy(GameObject.Find("ballPower"));
		
	}


	/**
    	Exit the application button

	*/
	public void ExitClick()
	{
		Debug.Log("GoodBye!");
		Application.Quit();	
	}


	/**
    	If the user clicks the travel to new universe button then change the scene and move the 
		player to the new scene with different position

	*/
	public void YesTravelNowClick()
	{
		Debug.Log("Traveling to Paint Universe");
		SceneManager.LoadScene("PaintUniverse", LoadSceneMode.Single);
		SceneManager.MoveGameObjectToScene(playerObj, SceneManager.GetSceneByName("PaintUniverse"));
		DontDestroyOnLoad(playerObj);
		playerObj.transform.position = new Vector3(-2.5f,1,4);
		player.transform.position = new Vector3(-2.5f,1,4);
		Destroy(travelUI);
	}

			
	/**
    	For if the user does not want to travel to a new universe at the moment

	*/
	public void NoNotNowClick()
	{
		Destroy(travelUI);
	}

	/**
    	For when the user collects a token and needs to go back to the home land

	*/
	public void GoingBackHomeFromPaintClick()
	{
		
		Debug.Log("Going Back Home From Paint");
		Destroy(tokenUIPaint);

		SceneManager.LoadScene("Home", LoadSceneMode.Single);
		SceneManager.MoveGameObjectToScene(playerObj, SceneManager.GetSceneByName("Home"));
		DontDestroyOnLoad(playerObj);
		playerObj.GetComponent<Player>().ChangeBackToPlayer();
		playerObj.transform.position = new Vector3(309.4f,20f,236.7f);


	}



	void Update () {


		
	}
}
