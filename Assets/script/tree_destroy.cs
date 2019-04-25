using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree_destroy : MonoBehaviour {

	// Use this for initialization
	public manager m;
	int rang;
	public GameObject shield,jump,sword,here,health;
	void Start () {
		m = GameObject.FindGameObjectWithTag ("manager").GetComponent<manager> ();
		rang = 7;
		if (m.dis < 800) {
			rang = 10;
		}

		GameObject p;

		int x = Random.Range (1, rang);
		//Debug.Log("hitttttttt");
		if (x > 7) {
			p =	Instantiate (sword, here.transform.position, here.transform.rotation);

			p.transform.parent = null;
		
		} else if (x > 5) {
			p =	Instantiate (shield, here.transform.position, here.transform.rotation);
			p.transform.parent = null;

		} else if (x >= 3) {
			p =	Instantiate (health, here.transform.position, here.transform.rotation);
			p.transform.parent = null;

		} else {

			p =	Instantiate (health, here.transform.position, here.transform.rotation);
			p.transform.parent = null;

		}
	}

	// Update is called once per frame
	void Update () {
		if (m.playerTransform.position.z -transform.position.z > 125f)
			Destroy (gameObject);
		
	}
}
