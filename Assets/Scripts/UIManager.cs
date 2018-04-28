using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {
	public static UIManager UIinstance;
	public GameObject PauseMenu;

	void Awake(){
		if (UIinstance == null) {
			UIinstance = this; 
			DontDestroyOnLoad (gameObject);
		} else {
			Destroy (this.gameObject);

		}
	}

	public void PauseGame(){
		if (PauseMenu.activeSelf) {
			PauseMenu.SetActive (false);
			GameManager.instance.Paused = false;
		} else {
			PauseMenu.SetActive (true);
			GameManager.instance.Paused = true;
		}
			
	}
}
