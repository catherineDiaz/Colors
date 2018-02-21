using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour {

	string powerName_;
	GameObject ball;
	Vector3 position_;
	bool now;





	//Change to ball
	public Power(string powerName)
	{
		powerName_ = powerName;
		GameObject ballPowerModel = Resources.Load ("ballPowerModel") as GameObject;
		ball = (GameObject) Instantiate(ballPowerModel, transform.position, transform.rotation);
		bool now = false;


	}

	//X-ray Vision
	/*public Power(string powerName) //list of objects in the environment, material to change to)
	{
		powerName_ = powerName;

	}*/

	public void ApplyPower(Power power)
	{
		if(gameObject.name == "ballPower")
		{
			
		}


		
	}

	void OnCollisionEnter (Collision col)
	{
		if (gameObject.name == "ballPowerModel") 
		{
			Debug.Log("Object Touched");
			//add to powerlist

			if (now == true) 
			{
				ApplyPower (this);
			}
			else// now == false
			{
				//show in box in the corner
			}
		
		
		}


	}



	
	// Update is called once per frame
	void Update () {


		
	}
}
