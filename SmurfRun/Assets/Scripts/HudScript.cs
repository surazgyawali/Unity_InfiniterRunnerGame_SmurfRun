﻿using UnityEngine;
using System.Collections;

public class HudScript : MonoBehaviour {

	float playerScore = 0;
	
	// Update is called once per frame
	void Update () {
		playerScore += Time.deltaTime;
	}
	public void IncreaseScore(int amount)
	{
		playerScore += amount;
	}
	void OnDisable(){

		PlayerPrefs.SetInt("Score",(int)playerScore);
		}
	void OnGUI()
	{
		GUI.Label (new Rect (10, 10, 100, 30), "Score:" + (int)(playerScore));
		}
}
