using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoombie : MonoBehaviour {
	public AudioSource audio;
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
		audio.Play();
	}
	void Awake(){
	

	}
	// Update is called once per frame
	void Update () {
		
	}
}
