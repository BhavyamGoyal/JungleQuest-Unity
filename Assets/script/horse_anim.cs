using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horse_anim : MonoBehaviour {
	public Animation anim;
	int grounded=1,fl=1,djump=1;
	public AudioSource  run_aud, jump_aud;
	// Use this for initialization
	public Rigidbody rb;
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (grounded == 2 && fl == 1) {
			run_aud.Play ();
			fl = 0;

		} 
		if( anim["horseJump"].normalizedTime >= .76)
		{
			//anim.Stop ("horseJump");
			//anim.Blend ("horseRun");
			anim.Play ("horseRun");

		}
		if (grounded==0){
			fl = 1;
			run_aud.Stop ();
		}
		//Debug.Log (grounded);
	

			
	}
	public void jump()
	{
		if (grounded>0 ) {
			rb.AddForce (0,350,0);
			anim.Stop ("horseRun");
			anim.Blend ("horseJump");
			anim["horseJump"].speed=.6f ;
			jump_aud.Play ();

			grounded--;

		}

	}

	void OnCollisionEnter(Collision col)
	{//Debug.Log ("grounded");
		if(col.gameObject.tag=="ground"){
			grounded=djump;
		}
	}

}
