using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power_box : MonoBehaviour {
	public GameObject shield,jump,sword,box_des;
	GameObject p;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 13);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, -5 * Time.deltaTime, 0);
	}

	void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.tag == "sword" && c.gameObject.GetComponent<BoxCollider>().isTrigger==false) {
				p =	Instantiate (box_des, transform.position, transform.rotation);
				p.transform.parent = null;
				Destroy (p, 2f);
				int x = Random.Range (1, 10);
				//Debug.Log("hitttttttt");
				if (x > 6) {
					p =	Instantiate (shield, transform.position, transform.rotation);

					p.transform.parent = null;
				p.gameObject.GetComponent<Rigidbody> ().AddForce (0f, 100f, 100f);
				} else if (x > 3) {
					p =	Instantiate (sword, transform.position, transform.rotation);
					p.transform.parent = null;
				p.gameObject.GetComponent<Rigidbody> ().AddForce (0f, 100f, 100f);
				} else {
					p =	Instantiate (jump, transform.position, transform.rotation);
					p.transform.parent = null;
				p.gameObject.GetComponent<Rigidbody> ().AddForce (0f, 100f, 100f);
				}
				Destroy (this.gameObject);
			}
}
}
