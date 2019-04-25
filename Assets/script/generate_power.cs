using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generate_power : MonoBehaviour {
	public GameObject empty, shield, arrows;
	int random,randecide;
	// Use this for initialization
	void Start () {
		randecide = Random.Range (1, 10);
		if (randecide <= 8)
			Instantiate (arrows, empty.transform.position, empty.transform.rotation, this.transform);
		else {
			Instantiate (shield, empty.transform.position, empty.transform.rotation, this.transform);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
