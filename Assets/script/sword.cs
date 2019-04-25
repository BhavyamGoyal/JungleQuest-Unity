using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour {
	public Animation anim;
	public AudioSource swoosh;
	// Use this for initialization
	public GameObject swor;
	public int stri=0,strike1=0,strike2=0;
	void Start () {
		anim.Play ("stance");
	}
	
	// Update is called once per frame
	void Update () {
		 if (strike2 == 1 && anim ["swordStrike2"].normalizedTime > .7) {
			strike2 = 0;
			swor.GetComponent<BoxCollider> ().isTrigger=true;
		} 
		
	}
	public void strike (){


			if (strike2 == 0) {

				swor.GetComponent<BoxCollider> ().isTrigger = false;
				anim.Play ("swordStrike1");
				anim ["swordStrike1"].speed = 1.5f;
				strike1 = 1;
				
				swoosh.Play ();
	}
 }
}
