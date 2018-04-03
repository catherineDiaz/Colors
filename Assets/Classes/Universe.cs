using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Universe : MonoBehaviour {

	// Use this for initialization

	//public string sceneName;
	private int paintOnce;
	private int waterColorOnce;
	private GameObject player;


	void Start () {

		player = GameObject.Find("Player");

		
	}


	public void loadSceneObjects(Scene scene)
	{
		if(scene.name == "PaintUniverse")
		{
			SceneManager.MoveGameObjectToScene(player, scene);
			player.transform.position = new Vector3(-31.6f, 0.26f, 45);

		}
		if(scene.name == "WaterColorUniverse")
		{
			SceneManager.MoveGameObjectToScene(player, scene);
			player.transform.position = new Vector3(-31.6f, 0.26f, 45);

		}
		
	}


	void OnCollisionEnter (Collision col)
	{
		if (gameObject.name == "PortalToPaint" && paintOnce == 0) 
		{
			paintOnce = 1;
			Debug.Log("Paint Portal Has Been Touched");
			UI travelUI = GameObject.Find("UIController").GetComponent<UI>();
			travelUI.TravelUI();

		}

		if (gameObject.name == "PortalToWaterColor" && waterColorOnce == 0) 
		{
			waterColorOnce = 1;
			Debug.Log("Water Color Portal Has Been Touched");
			UI travelWaterColorUI = GameObject.Find("UIController").GetComponent<UI>();
			travelWaterColorUI.TravelWaterColorUI();

		}
	}



	
	// Update is called once per frame
	void Update () {
		
	}
}
