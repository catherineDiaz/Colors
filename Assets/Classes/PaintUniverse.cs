using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaintUniverse : MonoBehaviour {

	GameObject playerFollow;
	GameObject personController;
	GameObject ballFollow;
	GameObject rollerBall;
	GameObject paintToken;
	int once = 0;



	/**
    	Initializes the Paint Universe object

	*/
	void Start () {


		playerFollow = GameObject.Find("PlayerFollow");
		ballFollow = GameObject.Find("BallFollow");
		personController = GameObject.Find("ThirdPersonController");
		paintToken = GameObject.Find("paintToken");

		
	}



	/**
    	If the token is collected then we launch the UI sending the player back to the home scene

	@params col - the collision that is detected

	*/
	void OnCollisionEnter (Collision col)
	{
		if (gameObject.name == "paintToken" && once == 0) 
		{
			once = 1;
			Debug.Log("Token Touched");
			UI tokenUIPaint = GameObject.Find("UIController").GetComponent<UI>();
			tokenUIPaint.TokenUIPaint();

		}

	}

	
	/**
		Update the camera following position, if the object is currently the person then have the camera 
		follow the person, if the person transforms into the ball then follow it 

	*/
	void Update () {
		
		if(personController.activeSelf == false)
		{
			rollerBall = GameObject.Find("RollerBall");
			playerFollow.transform.position = rollerBall.transform.position;
		}
		else
		{
			playerFollow.transform.position = personController.transform.position;
			
		}
			
		
	}
}
