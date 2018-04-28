using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
				
	}
	//If Player Presses the Start Button on Menu, the game scene will load 
	public void StartGame(){
		SceneManager.LoadScene ("Game");
	}
	//If player clicks the Quit Button on Main Menu, the game will quit 
	public void ExitGame(){
		Application.Quit(); 
	}
}



