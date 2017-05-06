using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour {
	public string RobotName;
	public Robot oponent;

	protected Animator animator;
	private Rigidbody myBody;



	// Use this for initialization
	void Start () {
		myBody = GetComponent<Rigidbody> ();
		animator = GetComponent<Animator> ();
	}

	public void UpdateRobotInput(){

		if (Input.GetAxis ("Horizontal") > 0.1) {
			animator.SetBool ("running", true);
		} else {
			animator.SetBool ("running", false);
		}

		if (Input.GetAxis ("Horizontal") < -0.1) {
			animator.SetBool ("walking", true);
		} else {
			animator.SetBool ("walking", false);
		}

		if (Input.GetKeyDown (KeyCode.H)) {
			animator.SetBool ("punch", true);
		}
	}
	
	// Update is called once per frame
	void Update () {
		UpdateRobotInput ();
	}
}
