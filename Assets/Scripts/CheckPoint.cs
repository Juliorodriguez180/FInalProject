using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {
	//Sets the checkpoint for player to respawn at 
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Player")) {
			GameManager.instance.LastCheckPoint = this.gameObject;

		}
	}
}