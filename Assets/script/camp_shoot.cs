using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class camp_shoot : MonoBehaviour {

	// Use this for initialization
	public Animation anim;
	int shot=0,power=0,arr_count=20,max_arrows=20,shoot=0;
	public Text arrows;
	public save_details sdd;
	public GameObject arrow, aim,arr,aim1,aim2;
	void Start () {
	//	anim.Play ("idleBow");
		power = sdd.Load_level (1);
		max_arrows = 20 + sdd.Load_level (3) * 5; 
	//	anim ["shoot"].normalizedTime = 0.48f;
	//	anim.Stop ("shoot");
		arrows.text = arr_count + "/" + max_arrows;
	}

	// Update is called once per frame
	void Update () {
		Debug.Log (transform.eulerAngles);
		if (Input.GetAxis ("Horizontal") > 0) {
			transform.Rotate (0f,10*Time.deltaTime,0f);
		}
		if (Input.GetAxis ("Horizontal") < 0) {
			transform.Rotate (0f, -10 * Time.deltaTime, 0f);
		}
		if (shoot == 1 && arr_count>0) {
			anim.Stop ("idleBow");
			anim.Blend ("shoot");
			anim ["shoot"].speed = 3f;
			shoot = 0;
		}
		if (anim ["shoot"].normalizedTime >= .5 && anim ["shoot"].normalizedTime <= .6 && shot <= power && arr_count>0) {
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

		} else if (anim ["shoot"].normalizedTime >= .9) {
			shot = 0;
			anim.Stop ("shoot");
			anim.Play ("idleBow");

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
