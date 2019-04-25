using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class following : MonoBehaviour {

	 public Animation anim;
	public GameObject death_effect;
	GameObject player,player1;
	 health_arrsc archerh;
	public int flag,flag_rl,arrow_count,fl1,fl2,flag_hit;
	Vector3 pos;

	// Use this for initialization
	void Start () {
		flag = 0;
		player=GameObject.FindGameObjectWithTag("follow1");
		player1=GameObject.FindGameObjectWithTag("follow2");
		archerh = GameObject.FindGameObjectWithTag ("archer_parent").GetComponent<health_arrsc> ();
		fl1 = 0;
		fl2 = 0;
		flag_hit = 1;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(flag_rl==0)
		pos = player.transform.position;
		else
		pos=player1.transform.position;
		//Debug.Log (pos);
		Vector3 direction = pos - this.transform.position;

		if (Vector3.Distance (pos, this.transform.position) > 4.8) {
			flag = 0;
		} else
			flag = 1;


		if (flag == 0) {
			direction.y = 0;
		
			//this.transform.rotation = Quaternion.Slerp (this.transform.rotation, Quaternion.LookRotation (direction), 0.1f);
			this.transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.LookRotation (direction), 100 * Time.deltaTime);

			if (fl1 == 0) {
				
				anim.Play ("WK_heavy_infantry_04_charge");
				fl1 = 1;
				fl2 = 0;
			}

			transform.Translate (0f, 0f, 4f * Time.deltaTime);
		} else if (fl2 == 0) {

			anim.Play ("WK_heavy_infantry_08_attack_B");
			fl2 = 1;
			fl1 = 0;
		}

		if ((anim ["WK_heavy_infantry_08_attack_B"].normalizedTime % 1) >= 0.5 && (anim ["WK_heavy_infantry_08_attack_B"].normalizedTime % 1) <= 0.7&& flag_hit==1) {
			//hit_player.Spider_hit ();
			archerh.decrement_health();
			Debug.Log("hittttt");
			flag_hit = 0;
			//	Debug.Log ("spider flag 1");
		}
		if((anim ["WK_heavy_infantry_08_attack_B"].normalizedTime % 1) >= 0.8)
		{
			flag_hit=1;
		}
	}


	void OnCollisionEnter(Collision c)
	{
		if (c.gameObject.tag == "barrel") {
			flag = 1;
		}
		if (c.gameObject.tag == "knight") {
			flag = 1;
		}
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "arrow") {
			arrow_count++;
			Destroy (col);
		}
		if (arrow_count == 2) {
			Destroy (Instantiate (death_effect, new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y + 2, gameObject.transform.position.z), transform.rotation, null), 2f);
			Destroy (this.gameObject);
		}
	
	
	}


}
