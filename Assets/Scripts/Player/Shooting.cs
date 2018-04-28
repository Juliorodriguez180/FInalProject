using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
	public GameObject Lazer1Prefab; 
	public Transform ShootPoint; 
	public float BulletSpeed; 
	public Vector3 Offset; 
	public AudioSource Gunshot;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			GameObject InstantiateBullet; 

			InstantiateBullet = Instantiate (Lazer1Prefab, this.transform.position+Offset,Quaternion.identity) as GameObject; 
			if (this.gameObject.GetComponent<PlayerMovement> ().FlipedRight) {
				InstantiateBullet.GetComponent<Bullet> ().force *= 1; 

			} else {
				InstantiateBullet.GetComponent<Bullet> ().force *= -1;
			}

		}
	}

	}

