using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_0 : MonoBehaviour {

	public int hit_count=0,flag,flag2=0,flag3=0,col_flag=0;
	public GameObject player;
	public Animation anim;
	Rigidbody rb;
	Vector3 pos;
	// Use this for initialization
	void Start () {
		flag = 0;
		player=GameObject.FindGameObjectWithTag("attack_here");
		hit_count = 1;
		//anim.Play ("Run");
		rb=gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -30) {
			Destroy (gameObject);
		}
		pos=player.transform.position;
		//Debug.Log (pos);
		Vector3 direction = pos - this.transform.position;

		if (hit_count >= 2) {
			flag = 1;
			anim.Play ("Death");
			if(anim["Death"].normalizedTime >= .9)
			Destroy (this.gameObject);
		}

		if (flag == 0)	 {

			if (Vector3.Distance (pos, this.transform.position) > 3) {
				direction.y = 0;
				//direction.x = 0;
				//this.transform.rotation = Quaternion.Slerp (this.transform.rotation, Quaternion.LookRotation (direction), 0.1f);
				this.transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.LookRotation (direction), 350 * Time.deltaTime);
				if (flag2 == 0) {
					anim.Play ("Run");
					anim ["Run"].speed = 2f;
					flag2 = 1;
					flag3 = 0;
				}
				rb.velocity = new Vector3(0,0,0);
				transform.Translate (0f, 0f, 8f * Time.deltaTime);
			} 
			else {
				anim.Stop ("Run");
				if (flag3 == 0) {
					anim.Play ("Attack02");
					flag2 = 0;
					flag3 = 1;
				//	this.transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.LookRotation (direction), 350 * Time.deltaTime);

				}

			}
		}
		transform.position = new Vector3 (1f, -0.86f, transform.position.z);


	}
/* void OnCollisionEnter(Collision c)
	{
	//	Debug.Log (c.gameObject.name);
		if (c.gameObject.tag == "knight_small") {
			Debug.Log("entered collision");
			col_flag = 1;

		}
	}

	void OnCollisionExit(Collision c)
	{
		if (c.gameObject.tag == "knight_small") {
			Debug.Log("out of collision");
			col_flag = 0;

		}

	}*/




}
