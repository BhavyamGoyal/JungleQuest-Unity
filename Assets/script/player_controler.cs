using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player_controler : MonoBehaviour {

	// Use this for initialization
	public Animation anim;
	int shot=0,power=0,arr_count=20,max_arrows=20,shoot=0;
	public Text arrows;
	public save_details sdd;
	public GameObject arrow, aim,arr,aim1,aim2;
	void Start () {
		power = sdd.Load_level (1);
		max_arrows = 20 + sdd.Load_level (3) * 5;
		arrows.text = arr_count + "/" + max_arrows;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (shoot == 1 && arr_count>0) {
			anim.Stop ("runHorseBow");
			anim.Blend ("idleHorseBowShoot");
			anim ["idleHorseBowShoot"].speed = 3f;
			shoot = 0;

		}
		if (anim ["idleHorseBowShoot"].normalizedTime >= .5 && anim ["idleHorseBowShoot"].normalizedTime <= .6 && shot <= power && arr_count>0) {
			arr = Instantiate (arrow, aim.transform.position, aim.transform.localRotation, aim.transform);
			arr.transform.rotation = aim.transform.rotation;
			arr_count--;
			arrows.text = arr_count + "/" + max_arrows;
			shot++;
			if (shot <= power) {
				arr = Instantiate (arrow, aim2.transform.position, aim2.transform.localRotation, aim2.transform);
				arr.transform.rotation = aim2.transform.rotation;
				shot++;
			}
			if (shot <= power) {
				arr = Instantiate (arrow, aim1.transform.position, aim1.transform.localRotation, aim1.transform);
				arr.transform.rotation = aim1.transform.rotation;
				shot++;
			}

		} else if (anim ["idleHorseBowShoot"].normalizedTime >= .9) {
			shot = 0;
			anim.Play ("runHorseBow");

		}
	}
		public void addArrows()
		{
		arr_count = arr_count + 5;
		if (arr_count > max_arrows) {
			arr_count = max_arrows;

		}
		arrows.text = arr_count + "/" + max_arrows;
		}
	public void fire()
	{
		shoot = 1;
	}


}
