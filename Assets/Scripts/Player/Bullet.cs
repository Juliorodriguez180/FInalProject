using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	public float force; 
	public float BulletTime; 
	public void OnTriggerEnter2D (Collider2D otherCollider){
		if (otherCollider.gameObject.CompareTag("Enemy")){
			otherCollider.gameObject.GetComponent<EnemyDetection> ().CurrentHealth -= 1; 
			Destroy (this.gameObject);
		}
	}
	void Start(){
		this.gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (force, 0));
	}


	void Update(){

		Destroy (this.gameObject, BulletTime);
	}
	
}