using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followndshoot_0 : MonoBehaviour {

	public int hit_count,flag,flag2=0,flag3=0,temp=0,fl,t=0;
	public GameObject player,spear,emp4;
	public Animation anim;
	Vector3 pos;
	// Use this for initialization
	void Start () {
		flag = 0;
		fl = 1;
		hit_count = 1;
		player=GameObject.FindGameObjectWithTag("Player");
		//StartCoroutine ("Inum");
		//anim.Play ("Run");
	}

	// Update is called once per frame
	void Update () {
	//	Debug.Log (anim ["Attack01"].normalizedTime%1);
		if (transform.position.y < -30) {
			Destroy (gameObject);
		}
		pos = player.transform.position;
		//Debug.Log (pos);
		Vector3 direction = pos - this.transform.position;

		if (hit_count >= 2) {
			flag = 1;
			anim.Play ("Death");
			if (anim ["Death"].normalizedTime >= .9)
				Destroy (this.gameObject);
		}

		if (flag == 0) {
			if (Vector3.Distance (pos, this.transform.position) <30) {
				anim.Stop ("Run");
				if (flag3 == 0) {

					anim.Play ("Attack01");
					anim ["Attack01"].speed = .4f;
					t = 1;
					flag3 = 1;


				}
				this.transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.LookRotation (direction), 350 * Time.deltaTime);

			}
			else{
				direction.y = 0;
			//	direction.x = 0;
				//this.transform.rotation = Quaternion.Slerp (this.transform.rotation, Quaternion.LookRotation (direction), 0.1f);
				this.transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.LookRotation (direction), 350 * Time.deltaTime);
				if(t==0)
				transform.Translate (0f, 0f, 8f * Time.deltaTime);
				if (flag2 == 0) {
					anim.Play ("Run");
					anim ["Run"].speed = 2f;
					flag2 = 1;
					flag3 = 0;

				}

			} 


			if (anim ["Attack01"].normalizedTime%1 >= .72) {
				fl = 1;
			//	transform.Translate (0f, 0f, 8f * Time.deltaTime);
			}
			if(anim ["Attack01"].normalizedTime%1 >= .30&& anim ["Attack01"].normalizedTime%1 <= .5&&fl==1)
			{
				if (Vector3.Distance (pos, this.transform.position) >3) {
					Instantiate (spear, emp4.transform.position, emp4.transform.rotation);
				}
				this.transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.LookRotation (direction), 350 * Time.deltaTime);

				fl = 0;
			}
		}
		transform.position = new Vector3 (1f, -0.86f, transform.position.z);

	}


	}
/*IEnumerator Inum()
	{
		int i;
		while (flag==0) {
		if (temp == 1) {

				anim.Play ("Attack01");
				p = Instantiate (spear, emp4.transform.position, emp4.transform.rotation);
			
			

				yield return new WaitForSeconds(2f);
			}
			else
				yield return new WaitForSeconds(6f);
		}


	}*/

