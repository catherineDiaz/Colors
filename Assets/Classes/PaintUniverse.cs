using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaintUniverse : MonoBehaviour {

	GameObject playerFollow;
	GameObject personController;
	GameObject ballFollow;
	GameObject rollerBall;



	// Use this for initialization
	void Start () {


		playerFollow = GameObject.Find("PlayerFollow");
		ballFollow = GameObject.Find("BallFollow");
		personController = GameObject.Find("ThirdPersonController");

		
	}
	
	// Update is called once per frame
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
