using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrel_roll : MonoBehaviour {
	
//	move_barrel mo;
	// Use this for initialization
	void Start () {
		//mo = transform.root.GetComponent<move_barrel> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0f,150 * Time.deltaTime, 0f);

	}

}
