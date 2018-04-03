using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterColorUniverse : MonoBehaviour {
	GameObject playerFollow;
	GameObject personController;
	GameObject player;
	int once = 0;
	GameObject maze;




	/**
    	Initializes the WaterColor Universe object

	*/
	void Start () {
		maze = GameObject.Find("waterColorMaze");
		playerFollow = GameObject.Find("PlayerFollow");
		personController = GameObject.Find("ThirdPersonController");
		player = GameObject.Find("Player");


	}

	void OnCollisionEnter (Collision col)
	{
		if (gameObject.name == "WaterColorToken" && once == 0) 
		{
			once = 1;
			Debug.Log("Water Color Token Touched");
			UI tokenUIWaterColor = GameObject.Find("UIController").GetComponent<UI>();
			tokenUIWaterColor.TokenUIWaterColor();

		}

	}


	public void xRayVision()
	{

	}
	
	// Update is called once per frame
	void Update () {
		
		playerFollow.transform.position = personController.transform.position;

		if(playerFollow.transform.position.y < -200)
		{
			UI fallUI = GameObject.Find("UIController").GetComponent<UI>();
			player.GetComponent<Player>().ChangeBackToPlayer();
			fallUI.YesTravelNowToWaterColorClick();
		}
		
	}
}
