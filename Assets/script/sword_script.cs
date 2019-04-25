using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword_script : MonoBehaviour {
	//public instantiate_0 i;
	public sword_control sw;
	public instantiate_0 i;
	public GameObject brea,b,hit1;
	public int swor=1;
	public AudioSource swordaud,swordspearaud,spiderhitaud;
	Vector3 pos;
	// Use this for initialization
	void Start () {
		pos = this.transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.localPosition = pos;
		
	}
	void OnCollisionEnter(Collision c)
	{
		//Debug.Log (c.gameObject.name);
	
		if (c.gameObject.tag == "knight_small") {
			Vector3 v = new Vector3 (c.transform.position.x,c.transform.position.y,c.transform.position.z);
			v.y++;
			Destroy(Instantiate (hit1, v, transform.rotation, null),1.6f);
			swordaud.Play ();
			c.gameObject.GetComponent<follow_0> ().hit_count++;
		i.count_e--;
			gameObject.GetComponent<BoxCollider> ().isTrigger =true;
		}
		if (c.gameObject.tag == "knight_small_spear") {
			c.gameObject.GetComponent<followndshoot_0> ().hit_count++;
			Vector3 v = new Vector3 (c.transform.position.x,c.transform.position.y,c.transform.position.z);
			v.y++;
			Destroy(Instantiate (hit1, v, transform.rotation, null),1.6f);
			swordaud.Play ();
			//s	i.sc_count--;
			i.count_e--;
			gameObject.GetComponent<BoxCollider> ().isTrigger =true;
		}


	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "spear" && (sw.strike1==1 || sw.strike2==1)) {
			//Destroy (col.gameObject);
			col.gameObject.GetComponent<spear_scrpt> ().spear_hit();
			swordspearaud.Play();


		}
		if (col.gameObject.tag == "spider"  && (sw.strike1==1 || sw.strike2==1)) {
			col.gameObject.GetComponent<spider_follow> ().hit_count++;
			Vector3 v = new Vector3 (col.transform.position.x,col.transform.position.y,col.transform.position.z);
			v.y+=0.5f;
			Destroy(Instantiate (hit1, v, transform.rotation, null),1.6f);
			spiderhitaud.Play ();
			//Destroy (col.gameObject);
		}
		if (col.gameObject.tag == "moving_barrel" && swor==2) {
			col.transform.root.GetComponent<move_barrel> ().move = 0;

			//	gameObject.GetComponent<Rigidbody> ().isKinematic = true;
			//Instantiate (brea, transform.position,transform.rotation,null);
			b=Instantiate (brea, col.gameObject.transform.position,col.gameObject.transform.rotation,null);
			Destroy (b, 2f);
			b=Instantiate (brea, col.gameObject.transform.position,col.gameObject.transform.rotation,null);
			Destroy (b, 2f);
			b=Instantiate (brea, col.gameObject.transform.position,col.gameObject.transform.rotation,null);
			Destroy (b, 2f);
			Destroy (col.gameObject);
			//gameObject.GetComponent<Rigidbody> ().isKinematic = false;

		}

	}
}
