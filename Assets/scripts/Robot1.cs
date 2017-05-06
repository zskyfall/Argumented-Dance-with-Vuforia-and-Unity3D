using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot1 : MonoBehaviour {
	public string robotName;
	public static float MAX_HEALTH = 100f;
	public float moveSpeed = 200f;
	public float health = MAX_HEALTH;

	protected Animator animator;
	private Rigidbody robotBody;

	// Use this for initialization
	void Start () {
		robotBody = GetComponent<Rigidbody> ();
		animator = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		

	}
}
