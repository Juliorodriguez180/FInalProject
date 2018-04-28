using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GameManager : MonoBehaviour {

	public static GameManager instance; 
	public GameObject LastCheckPoint;
	public bool PlayerIsDead; 
	public GameObject Player;
	public List <GameObject> EnemiesInGame; 
	public int PlayerLife; 
	public Text LifeCounter; 

	[HideInInspector]
	public bool Paused = false;
	public bool DeathByEnemy; 

	// Use this for initialization

	void Awake(){
		if (instance == null) {
			instance = this; 
			DontDestroyOnLoad (gameObject);
		} else {
			Destroy (this.gameObject);
	
		}
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit();
		}

		LifeCounter.text = "Lifes: " + PlayerLife;
		if (PlayerLife <= 0) {	
			//To Do 

		if (Player.activeSelf == false) {
			foreach (GameObject Enemies in EnemiesInGame){
				Destroy(Enemies);
				EnemiesInGame.Remove (Enemies); 
			}
		}

		//Here we are making the checkpoint system, to where when ever the player dies, they can press space to respawn at the checkpoint 
		if (PlayerIsDead == true) {
			if (Input.GetKeyDown(KeyCode.Space)){
				Player.transform.position = LastCheckPoint.transform.position;
				Player.SetActive (true);	
			}
		
		}
		if (Input.GetKeyDown(KeyCode.Escape)){
			UIManager.UIinstance.PauseGame ();
		}
	}
		if (PlayerIsDead == true) {
			if (Input.GetKeyDown(KeyCode.Space)){
				DeathByEnemy = false;
				Player.transform.position = Vector3.zero;
				Player.SetActive (true);
				PlayerIsDead = false;

		}
		
	
	}
}
}
