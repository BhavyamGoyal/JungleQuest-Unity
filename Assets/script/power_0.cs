using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power_0 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	//	Destroy (gameObject, 10);
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	void OncollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "ground") {
			gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 0);
			gameObject.GetComponent<Rigidbody> ().angularVelocity = new Vector3 (0, 0, 0);
		}

	}
}
