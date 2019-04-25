using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_box : MonoBehaviour {
	public GameObject box_des,p,spider,diamond,health;
	// Use this for initialization
	void Start () {
		transform.Rotate (0	, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (30*Time.deltaTime, 40 * Time.deltaTime, 0);

	}
	void OnTriggerEnter(Collider c)
	{

		if (c.gameObject.tag == "sword" && c.gameObject.GetComponent<BoxCollider>().isTrigger==false) {
			p =	Instantiate (box_des, transform.position, transform.rotation);
			p.transform.parent = null;
			Destroy (this.gameObject);
			Destroy (p, 2f);
			int x = Random.Range (-1, 10);
			//Debug.Log("hitttttttt");
			if (x > 6) {
				p =	Instantiate (health, transform.position, transform.rotation);
				//p.gameObject.GetComponent<Rigidbody> ().AddForce (0f,200f, 4000f);
				p.transform.parent = null;

			} else if (x > 3) {
				p =	Instantiate (spider, transform.position, transform.rotation);
				p.transform.parent = null;
			} else {
				p =	Instantiate (diamond, transform.position, transform.rotation);
				p.transform.parent = null;
				//p.gameObject.GetComponent<Rigidbody> ().AddForce (0f, 200f, 200f);
			}

		}
	}
}

