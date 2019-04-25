using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect_diamond : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.eulerAngles = new Vector3 (0f, 0f, 0f);
		gameObject.GetComponent<Rigidbody> ().AddForce (0f, 200f, 1000f);

	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0f, 30 * Time.deltaTime, 0f);
	}
}
