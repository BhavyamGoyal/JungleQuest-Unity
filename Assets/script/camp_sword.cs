using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camp_sword : MonoBehaviour {
	public	AudioSource swordaud;
	public GameObject hit1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "knight") {

				Vector3 v = new Vector3 (col.transform.position.x,col.transform.position.y,col.transform.position.z);
				v.y++;
				Destroy(Instantiate (hit1, v, transform.rotation, null),1.6f);
				swordaud.Play ();
				//col.gameObject.GetComponent<follow_0> ().hit_count++;
			Destroy(col.gameObject);
				gameObject.GetComponent<BoxCollider> ().isTrigger =true;

		}
	}
}
