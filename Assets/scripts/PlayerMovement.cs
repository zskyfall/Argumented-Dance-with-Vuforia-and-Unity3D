﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed = 100f;            // The speed that the player will move at.

	Vector3 movement;                   // The vector to store the direction of the player's movement.
	Animator anim;                      // Reference to the animator component.
	Rigidbody playerRigidbody;          // Reference to the player's rigidbody.
         
	float camRayLength = 100f;          // The length of the ray from the camera into the scene.

	void Awake ()
	{
		
		// Set up references.
		anim = GetComponent <Animator> ();
		playerRigidbody = GetComponent <Rigidbody> ();
	}


	void FixedUpdate ()
	{
		// Store the input axes.
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");

		// Move the player around the scene.
		Move (h, v);


		// Animate the player.
		Animating (h, v);
	}

	void Move (float h, float v)
	{
		// Set the movement vector based on the axis input.
		movement.Set (h, 0f, v);

		// Normalise the movement vector and make it proportional to the speed per second.
		movement = movement.normalized * speed * Time.deltaTime;

		// Move the player to it's current position plus the movement.
		playerRigidbody.MovePosition (transform.position + movement);
	}



	void Animating (float h, float v)
	{
		// Create a boolean that is true if either of the input axes is non-zero.
		bool walking = h != 0f || v != 0f;

		// Tell the animator whether or not the player is walking.
		anim.SetBool ("running", walking);
	}
}