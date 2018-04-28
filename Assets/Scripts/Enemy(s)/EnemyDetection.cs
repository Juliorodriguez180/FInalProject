using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour {
	public Transform Target;
	private GameObject Enemy;
	private GameObject Player;
	private float Range;
	public float Speed;
	public bool isAlwaysSeeking;
	public int MaxHealth; 
	[HideInInspector]
	public int CurrentHealth; 


	// Use this for initialization
	void Start () {
		Player = GameManager.instance.Player; 
		CurrentHealth = MaxHealth; 

	}

	// Update is called once per frame
	void Update () {
		Range = Vector2.Distance (this.transform.position, Player.transform.position);
		if (Range <= 15f) {
			transform.Translate(Vector2.MoveTowards (this.transform.position, Player.transform.position, Range) * Speed * Time.deltaTime);
		}
		if (CurrentHealth <= 0) {
			GameManager.instance.EnemiesInGame.Remove (this.gameObject);
			Destroy (this.gameObject);
		}
	}
}