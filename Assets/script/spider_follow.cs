using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spider_follow : MonoBehaviour {

	// Use this for initialization
	public int hit_count=0,flag,flag2=0,flag3=0,col_flag=0,flag_hit=0;
	public GameObject player;
	public Animation anim;
	check_trig_0 hit_player;
	Vector3 pos;
	int f=0;
	// Use this for initialization
	void Start () {
		int f=0;
		transform.eulerAngles = new Vector3 (0, 0, 0);
		flag = 0;
		player=GameObject.FindGameObjectWithTag("Player");
		//anim.Play ("Run");
		flag_hit=0;
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.y < -30) {
			Destroy (gameObject);
		}
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

			if (Vector3.Distance (pos, this.transform.position) > 2) {
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
					hit_player.Spider_hit ();
					flag_hit = 0;
				//	Debug.Log ("spider flag 1");
				}
				if((anim ["attack"].normalizedTime % 1) >= 0.8)
				{
					flag_hit=1;
				}
			}
			transform.position = new Vector3 (1.7f, -0.96f, transform.position.z);

		}

}
	void OnTriggerEnter(Collider c)
	{

		if (c.gameObject.tag == "Player"&& flag_hit==0) {
			//Debug.Log ("spiderrrr");
			hit_player=	c.gameObject.GetComponent<check_trig_0> ();
			flag_hit = 1;
		}
	}
}