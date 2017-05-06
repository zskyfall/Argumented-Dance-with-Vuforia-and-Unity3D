using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnController : MonoBehaviour {
	public GameObject zoombieBoy;
	public GameObject TopZoombieBoy;
	public GameObject zoombieGirlPan;
	public Material[] mats;
	private int dem = 0;


	Renderer rend,rendGirl;
	// Use this for initialization
	void Start () {
		//Zoombie Boy Renderer
		rend = TopZoombieBoy.GetComponent<Renderer> ();
		rend.enabled = true;


		//Zoombie Girl Renderer
		rendGirl = zoombieGirlPan.GetComponent<Renderer> ();
		rendGirl.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void changeSkinNext(){
		
		if (dem < mats.Length) {
			rend.sharedMaterial = mats [dem];
			rendGirl.sharedMaterial = mats [dem];
			dem = dem + 1;
		} else {
			dem = 0;
			rendGirl.sharedMaterial = mats [dem];
			rend.sharedMaterial = mats [dem];

		}
	}

	public void changeSkinPrevious(){
		if (dem > 0) {
			rendGirl.sharedMaterial = mats [dem];
			rend.sharedMaterial = mats [dem];
			dem = dem - 1;
		} else {
			dem = mats.Length - 1;
			rendGirl.sharedMaterial = mats [dem];
			rend.sharedMaterial = mats [dem];

		}
	}
	public void QuitGame(){
		Application.Quit ();
	}
	public void OpenAuthorUrl(){
		Application.OpenURL ("http://huuthang.me");
	}
}
