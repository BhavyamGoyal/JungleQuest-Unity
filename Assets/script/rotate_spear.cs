using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_spear : MonoBehaviour {
	GameObject p;
	Vector3 d;
	// Use this for initialization
	void Start () {
			p = GameObject.FindGameObjectWithTag ("attack_here2");
			

	}

	
	// Update is called once per frame
	void Update () {
		d=	 p.transform.position - this.transform.position;
		this.transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.LookRotation (d), 350 );
	}
}
