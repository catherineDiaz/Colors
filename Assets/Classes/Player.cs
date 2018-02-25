using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Singleton<Player> {

    string name_;
    Vector3 position_;
	GameObject player3DModel;
	List<Power> powerList_;
	List<Token> tokenList_;



    // Use this for initialization
	void Start(){//public Player (string name, Vector3 position) {
		name_ = name;
		//position_ = position;
		powerList_ = new List<Power>();
		tokenList_ = new List<Token>();

	}

	public void addPowerToList(Power power)
	{

		powerList_.Add(power);
		Debug.Log("Current List of Powers: ");
		foreach (Power i in powerList_)
		{
			Debug.Log(i);
		}
		
	}

	public void addTokenToList(Token token)
	{

		tokenList_.Add(token);
		foreach (Token i in tokenList_)
		{
			Debug.Log(i);
		}

	}
		
	// Update is called once per frame
	void Update () {

		position_ = this.transform.position;


		
	}
}
