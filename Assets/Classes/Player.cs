using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : Singleton<Player> {

    string name_;
    Vector3 position_;
	public GameObject player;
	public GameObject rollerBall;
	List<Power> powerList_;
	List<Token> tokenList_;
	GameObject camera1;
	GameObject camera2;
	public bool isUsingRollerPower;
	GameObject playerFollow;
	GameObject playerObj;
	int count;
	GameObject newFollow;

	/**
    	Initializes Player object which inherits from the Singleton Class making this object a 
    	singleton

	*/
	void Start(){
		name_ = this.name;
		position_ = this.transform.position;
		powerList_ = new List<Power>();
		tokenList_ = new List<Token>();
		rollerBall = GameObject.Find("RollerBall");
		rollerBall.SetActive(false);
		playerObj = GameObject.Find("Player");
		player = GameObject.Find("ThirdPersonController");
		player.SetActive(true);
		isUsingRollerPower = false;
		playerFollow = GameObject.Find("PlayerFollow");
		count = 0;
	}

	/**
    	Adds a power to the list of powers if player collects a power

	*/
	public void addPowerToList(Power power)
	{

		powerList_.Add(power);
		Debug.Log("Current List of Powers: ");
		foreach (Power i in powerList_)
		{
			Debug.Log(i);
		}
		
	}

	/**
    	Adds a token to the list of tokens if player collects a token

	*/
	public void addTokenToList(Token token)
	{

		tokenList_.Add(token);
		foreach (Token i in tokenList_)
		{
			Debug.Log(i);
		}

	}

	/**
    	For when the player completes the paint level and needs to transform back into a person
    	instead of a ball

	*/

	public void ChangeBackToPlayer()
	{
		rollerBall.SetActive(false);
		player.SetActive(true);
		//player.transform.position = new Vector3(0, 0, 0);

	}
		
	/**
    	Keeps track of the player position, and updates camera follows depending on which form
    	the player is currently in

	*/

	void Update () {

		position_ = this.transform.position;


		if(SceneManager.GetActiveScene().name == "PaintUniverse")
		{
			camera1 = GameObject.Find("FreeLookCameraRig");

			if (isUsingRollerPower == true)
			{
				
				rollerBall.SetActive(true);

				rollerBall.transform.position = player.transform.position;

				player.SetActive(false);

				isUsingRollerPower = false;
			
				
			}
			
		}
		Debug.Log(player.transform.position);

		if(SceneManager.GetActiveScene().name == "Home")
		{
			if(player != null)
			{
				playerFollow = GameObject.Find("PlayerFollow");
				playerFollow.transform.position = player.transform.position;	
			}

		}


		
	}
}
