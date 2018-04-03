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



	public void xRayVision()
	{

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
