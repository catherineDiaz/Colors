using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour {

	string powerName_;
	GameObject ball;
	GameObject person;
	Vector3 position_;
	int once;

	/**
    	Initializes Power object, the constructor

	*/
	void Start()
	{
		powerName_ = this.name;
		bool now = false;
		once = 0;
		ball = GameObject.Find("RollerBall");
		ball.SetActive(false);
		person = GameObject.Find("ThirdPersonController");
		person.SetActive(true);


	}

	/**
    	If a power is touched, apply the power to the player

	*/
	public void ApplyPower()
	{
		if(gameObject.name == "ballPower") // If the object touched was the ball power
		{
			ball.SetActive(true);

			GameObject switchCameraFollow = GameObject.Find("Main Camera").GetComponent<CameraFollow>().player;
			Debug.Log(switchCameraFollow.name);
			switchCameraFollow = ball;
			Debug.Log(switchCameraFollow.name);

			person.SetActive(false);

		}
		
	}

	/**
    	Waiting for collision on the power 3D object in the game, if another game object (the Player)
    	collides with the Power then the UI is initialized and asks the player if they want to use
    	the power now or later

	*/
	void OnCollisionEnter (Collision col)
	{
		if (gameObject.name == "ballPower" && once == 0) 
		{
			once = 1;
			Debug.Log("Object Touched");
			UI powerUI = GameObject.Find("UIController").GetComponent<UI>();
			powerUI.CollectedPower();

		}

	}



	void Update () {


		
	}
}
