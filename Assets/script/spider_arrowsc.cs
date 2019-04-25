using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spider_arrowsc : MonoBehaviour {

	// Use this for initialization
	public int f,hit_count=0,flag,flag2=0,flag3=0,col_flag=0,flag_hit=0;
	public GameObject player;
	public Animation anim;
	health_arrsc h;
	Vector3 pos;
	void Start () {
		f = 0;
		flag = 0;
		player=GameObject.FindGameObjectWithTag("archer");
		//anim.Play ("Run");
		flag_hit=0;
	
		h = GameObject.FindGameObjectWithTag ("archer_parent").GetComponent<health_arrsc> ();
	}
	
	// Update is called once per frame
	void Update () {
		pos=player.transform.position;
		//Debug.Log (pos);
		Vector3 direction = pos - this.transform.position;

		if (hit_count >= 2&&f==0) {

			flag = 1;
			anim.Play ("die");
			f = 1;
			anim ["die"].speed = .7f;
			Destroy (this.gameObject,2f);

		}

		if (flag == 0)	 {

			if (Vector3.Distance (pos, this.transform.position) > 9) {
				direction.y = 0;
				//this.transform.rotation = Quaternion.Slerp (this.transform.rotation, Quaternion.LookRotation (direction), 0.1f);
				this.transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.LookRotation (direction), 350 * Time.deltaTime);
				if (flag2 == 0) {
					anim.Stop ("walk");
					anim.Play ("walk");
					anim ["walk"].speed = 1.5f;
					flag2 = 1;
					flag3 = 0;
				}
				transform.Translate (0f, 0f, 6f * Time.deltaTime);
			} 
			else {

				if (flag3 == 0) {
					anim.Stop ("walk");
					anim.Play ("attack");
					anim ["walk"].speed = .7f;
					flag2 = 0;
					flag3 = 1;
					this.transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.LookRotation (direction), 350 * Time.deltaTime);
				}
				/*	if (anim ["attack"].normalizedTime >= 0.7 && anim ["attack"].normalizedTime <= 0.8) {
					flag_hit = 1;
				} else
					flag_hit = 0;*/
				if ((anim ["attack"].normalizedTime % 1) >= 0.5 && (anim ["attack"].normalizedTime % 1) <= 0.7&& flag_hit==1) {
					//hit_player.Spider_hit ();
					h.decrement_health();
					flag_hit = 0;
					//	Debug.Log ("spider flag 1");
				}
				if((anim ["attack"].normalizedTime % 1) >= 0.8)
				{
					flag_hit=1;
				}
			}
		//	transform.position = new Vector3 (1.7f, -0.96f, transform.position.z);

		}
		//transform.position = new Vector3 (transform.position.x, -0.96f, transform.position.z);
	}
}
