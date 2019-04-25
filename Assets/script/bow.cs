using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		

		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (transform.localEulerAngles);
		if (Input.GetAxis ("Vertical") > 0) {
			if ((transform.localEulerAngles.x < 5 && transform.localEulerAngles.x >= 0) || (transform.localEulerAngles.x < 360 && transform.localEulerAngles.x > 340)) {
				transform.Rotate (10 * Time.deltaTime, 0, 0);
			}	} else if (Input.GetAxis ("Vertical") < 0) {

			if((transform.localEulerAngles.x <7 && transform.localEulerAngles.x>=0)||(transform.localEulerAngles.x<360 && transform.localEulerAngles.x>346))
				{transform.Rotate (-10 * Time.deltaTime, 0, 0);}
				}

	}

}
