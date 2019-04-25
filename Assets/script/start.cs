using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour {
	public int dir=1,move_forward=2;
	Animation anim;
	float move;
	// Use this for initialization
	void Start () {
		anim = GameObject.FindGameObjectWithTag ("Player").GetComponent<Animation> ();
		anim.Play ("horseRun");

	}
	
	// Update is called once per frame
	void Update () {



		move = 5.5f * move_forward * Time.deltaTime;
		gameObject.transform.Translate (move,0,0 );

	}
	public void move_right(){
		anim ["horseRun"].speed = 1.3f ;
			move_forward = 3;
		//anim.Stop ("horseWalk");

	}
	public void move_left(){
		anim ["horseRun"].speed = .9f ;
		move_forward = 1;
	}
	public void move_none(){
		move_forward =2 ;
		anim ["horseRun"].speed = 1f ;

		//anim.Play("horseWalk");
	}
}
