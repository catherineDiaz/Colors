using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Universe : MonoBehaviour {

	// Use this for initialization

	public string sceneName;
	private int once;


	void Start () {
		
	}


	void loadSceneObjects()
	{
		if(sceneName == "PaintUniverse")
		{
			//Resources.load course
		}
		
	}


	void OnCollisionEnter (Collision col)
	{
		if (gameObject.name == "PortalToPaint" && once == 0) 
		{
			once = 1;
			Debug.Log("Portal Has Been Touched");
			UI travelUI = GameObject.Find("UIController").GetComponent<UI>();
			travelUI.TravelUI();

		}

	}



	
	// Update is called once per frame
	void Update () {
		
	}
}
