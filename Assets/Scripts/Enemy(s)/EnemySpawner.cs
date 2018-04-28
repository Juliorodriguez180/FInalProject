using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	private float Delay; 
	public List <GameObject> Enemies; 


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			// What this is doing is Delay is 0, we can attempt to spawn an enemie, but if there is 3 enemies, nothing spawn, untill there is less then 3 enemies 
			if (Delay <= 2) {

				if (GameManager.instance.EnemiesInGame.Count < 5) {
					int RandomEnemie = Random.Range (0, Enemies.Count);

					GameObject SpawnedEnemie; 
					SpawnedEnemie = Instantiate (Enemies[RandomEnemie], this.transform.position, this.transform.rotation);
					//Adding Enemie that we spawned In 
					GameManager.instance.EnemiesInGame.Add (SpawnedEnemie);
					Delay = 5; 
					int RandomNum = Random.Range (0, 10);
					//IF number is greater for enemies spawned, so 9 or 10 will be heat seaking 
					if (RandomNum > 8) {
					SpawnedEnemie.GetComponent<EnemyDetection> ().isAlwaysSeeking = true;
					}

				}
			} else {
				Delay -= Time.deltaTime; 
			}
		}

	}

