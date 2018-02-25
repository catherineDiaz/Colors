using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

	// Use this for initialization
	GameObject powerUI;
	Button useNow;
	Button useLater;
	Player player;
	Power ball;


	public void CollectedPower()
	{
		powerUI = Instantiate(Resources.Load("powerUI") as GameObject);
		useNow = GameObject.Find("UseNow").GetComponent<UnityEngine.UI.Button>();
		useLater = GameObject.Find("UseLater").GetComponent<UnityEngine.UI.Button>();
		useNow.onClick.AddListener(() => OnButtonClicked(useNow.name)); 
		useLater.onClick.AddListener(() => OnButtonClicked(useLater.name));
		player.addPowerToList(ball);

	}

	void OnButtonClicked(string name)
	{

		if(name == "UseNow")
		{
			Debug.Log("Transforming into a ball...");
			ball.ApplyPower();
			Destroy(powerUI);
			Destroy(GameObject.Find("ballPower"));

		}

		if (name == "UseLater")
		{
			Debug.Log("Storing the power for later...");
			Destroy(powerUI);
			Destroy(GameObject.Find("ballPower"));
		}

			
	}
		
	void Start () {

		player = GameObject.Find("Player").GetComponent<Player>();
		ball = GameObject.Find("ballPower").GetComponent<Power>();


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
