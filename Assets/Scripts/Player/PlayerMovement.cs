using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Transform tf; 
	public float speed; 
	public bool FlipedLeft;
	public bool FlipedRight;
	public float jumpPower;
	public float jumpHight; 

	// Use this for initialization
	void Start () {
		tf = GetComponent <Transform> ();
	}
	
	// Update is called once per frame

	void Update () {
		
		if(Input.GetKey(KeyCode.W)){
			this.gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, jumpHight), ForceMode2D.Impulse);
		}

		if(GameManager.instance.Paused == true){
			return; 
		}

		//Player Will Move Right on the screen
		if (Input.GetKey(KeyCode.D)){
			Move(1);
			if (FlipedRight == false) {
				FlipModel ();
				FlipedRight = true;
				FlipedLeft = false;
			}
		}
		//Player Will Move Left on the Screen 
		if (Input.GetKey (KeyCode.A)) {
			Move (-1);
			if (FlipedLeft == false) {
				FlipModel ();
				FlipedRight = false;
				FlipedLeft = true;
			}

		}
}
	public void Move(int MoveDirection){
		//Take in the variable, If postive move to the right, if negitive move to the left 
		Vector3 Movement = new Vector3 (MoveDirection * speed, 0, 0);
		tf.Translate (Movement * Time.deltaTime, Space.World);
	}
	public void FlipModel(){
		//Flips Bassed off of direction we are moving
		Vector3 Flipscale = tf.localScale;
		Flipscale.x *= -1;
		tf.localScale= Flipscale;
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.CompareTag("Enemy")){
			this.gameObject.SetActive (false); 
			GameManager.instance.PlayerIsDead = true; 
			GameManager.instance.PlayerLife -= 1; 
		}
			
	}
}
