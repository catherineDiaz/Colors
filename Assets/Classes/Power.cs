using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour {

	string powerName_;
	GameObject ball;
	GameObject person;
	Vector3 position_;

	int once;


	//Change to ball
	void Start()//public Power(string powerName)
	{
		//powerName_ = powerName;
		bool now = false;
		once = 0;
		ball = GameObject.Find("RollerBall");
		ball.SetActive(false);
		person = GameObject.Find("ThirdPersonController");
		person.SetActive(true);


	}

	//X-ray Vision
	/*public Power(string powerName) //list of objects in the environment, material to change to)
	{
		powerName_ = powerName;

	}*/

	public void ApplyPower()
	{
		if(gameObject.name == "ballPower")
		{
			ball.SetActive(true);

			GameObject switchCameraFollow = GameObject.Find("Main Camera").GetComponent<CameraFollow>().player;
			Debug.Log(switchCameraFollow.name);
			switchCameraFollow = ball;
			Debug.Log(switchCameraFollow.name);


			person.SetActive(false);




		}
		
	}

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



	
	// Update is called once per frame
	void Update () {


		
	}
}
