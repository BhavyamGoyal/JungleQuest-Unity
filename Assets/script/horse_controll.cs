using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horse_controll : MonoBehaviour {
	float move;
	public start st;
	public Animation anim;
	public int dir = 1, move_forward=0,jumps=0;
	Vector3 c_pos,h_pos,set_pos,d_pos,l_pos,p_pos;
	public GameObject camera_sc;
	public save_details sdf;
	public manager mm;
	public player_controler pl;
	int x=0,y=2,die = 0,shield_power=0;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation> ();
		 h_pos = transform.localPosition;
		shield_power = sdf.Load_level (4);
		c_pos = camera_sc.transform.localPosition;
		d_pos = h_pos-c_pos;
		transform.localEulerAngles = new Vector3 (0, 90, 0);
		
	}
	
	// Update is called once per frame
	void Update () {
		


	
	}
	void OnTriggerEnter(Collider col)
	{
		
		if (col.gameObject.tag == "trap"&& die <= 0) {
			sdf.SaveCoins (mm.coins+mm.coins_loaded);
			//Destroy (gameObject);

		}
		if (col.gameObject.tag == "trap"&&die>0) {
			die--;
		}

		if (col.gameObject.tag == "arrows") {
			pl.addArrows ();
			Destroy (col.gameObject);
		}
		if (col.gameObject.tag == "shield") {
			die = shield_power;
			Destroy(col.gameObject);
		}
	}


}
