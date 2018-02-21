using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    string name_;
    Vector3 position_;
	GameObject player3DModel;
	List<Power> powerList_;
	List<Token> tokenList_;



    // Use this for initialization
	public Player (string name, Vector3 position) {
		name_ = name;
		position_ = position;
		powerList_ = new List<Power>();
		tokenList_ = new List<Token>();

	}
	/*
	public void addPowerToList(Power power)
	{

		powerList_.Add(power);
		
	}

	public void addTokenToList(Token token)
	{

		powerList_.Add(token);

	}


	*/






	
	// Update is called once per frame
	void Update () {


		
	}
}
