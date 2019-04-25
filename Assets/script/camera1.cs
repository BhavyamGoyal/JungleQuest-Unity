using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera1 : MonoBehaviour {

	// Use this for initialization
	Vector3 dis;
	public GameObject cam1,cam2;
	int cam=1;
	void Start () {
		dis = transform.position - GameObject.FindGameObjectWithTag ("Player").transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = dis + GameObject.FindGameObjectWithTag ("Player").transform.position;
		
	}
	public void change_cam()
	{
		if (cam == 1) {
			cam2.SetActive (true);
	            cam1.SetActive (false);
			  
			cam = 2;
		} else {
			cam1.SetActive (true);
			cam2.SetActive (false);
			cam = 1;

		}
		
	}
}
