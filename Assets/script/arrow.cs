using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour {

	// Use this for initialization
	GameObject cam;
	void Start () {
		cam = GameObject.FindGameObjectWithTag ("cam_scene");
		gameObject.transform.parent = cam.transform;
		transform.Rotate (-90, 0, 0);
		Destroy (gameObject, 2);
	}
	
	// Update is called once per frame
	void Update () {
		
		gameObject.transform.Translate (0, -50 * Time.deltaTime, 0);
	}
}
