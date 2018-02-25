using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Singleton<Player> {

    string name_;
    Vector3 position_;
	GameObject player3DModel;
	List<Power> powerList_;
	List<Token> tokenList_;

	/**
    	Initializes Player object which inherits from the Singleton Class making this object a 
    	singleton

	*/
	void Start(){
		name_ = this.name;
		position_ = this.transform.position;
		powerList_ = new List<Power>();
		tokenList_ = new List<Token>();

	}

	/**
    	Adds a power to the list of powers if player collects a power

	*/
	public void addPowerToList(Power power)
	{

		powerList_.Add(power);
		Debug.Log("Current List of Powers: ");
		foreach (Power i in powerList_)
		{
			Debug.Log(i);
		}
		
	}

	/**
    	Adds a token to the list of tokens if player collects a token

	*/
	public void addTokenToList(Token token)
	{

		tokenList_.Add(token);
		foreach (Token i in tokenList_)
		{
			Debug.Log(i);
		}

	}
		
	/**
    	Keeps track of the player position

	*/




	void Update () {

		position_ = this.transform.position;




		
	}
}
