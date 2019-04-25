using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class c_rotate2 : MonoBehaviour {

	private Vector3 firstpoint; 
	private Vector3 secondpoint;
	public float xAngle = 0.0f; //angle for axes x for rotation
	public float yAngle = 0.0f;
	public float xAngTemp = 0.0f; //temp variable for angle
	public float yAngTemp = 0.0f;
	public rotates first;


	void  Start() {


		firstpoint = new Vector3 (0, 0, 0);
		secondpoint = new Vector3 (0, 0, 0);



		xAngle = 0.0f; 
		yAngle = 0.0f;

		transform.localRotation = Quaternion.Euler(yAngle, xAngle, 0.0f);
	}

	void Update() {


		//Check count touches

		if (Input.touchCount ==2) {
			//Touch began, save position
			if (Input.GetTouch (1).phase == TouchPhase.Began) {
				firstpoint = Input.GetTouch (1).position;
				if (firstpoint.x <00f && firstpoint.x>600 && firstpoint.y<400 )
					return;
				xAngTemp = xAngle;
				yAngTemp = yAngle;
			}
			//Move finger by screen
			if (Input.GetTouch (1).phase == TouchPhase.Moved) {
				secondpoint = Input.GetTouch (1).position;
				if (firstpoint.x <0f&& firstpoint.y<400  && firstpoint.x>600  )
					return;
				//Mainly, about rotate camera. For example, for Screen.width rotate on 180 degree

				yAngle = yAngTemp - (secondpoint.y - firstpoint.y) * 90.0f / Screen.height;



				if (yAngle < 0)
					yAngle  +=360;
				if (yAngle > 360)
					yAngle  -=360;

				if (yAngle > 90 && yAngle < 270)
					xAngle = xAngTemp - (secondpoint.x - firstpoint.x) * 180.0f / Screen.width;
				else
					xAngle = xAngTemp + (secondpoint.x - firstpoint.x) * 180.0f / Screen.width;

				if (xAngle < 0)
					xAngle  +=360;

				if (xAngle > 360)
					xAngle  -=360;
				if (yAngle > 5 && yAngle < 180) {
					yAngle = 5;
				}
				if (yAngle < 346 && yAngle>= 180) {
					yAngle = 346;
				}
				first.xAngle = xAngle;
				first.yAngle = yAngle;


				transform.localRotation = Quaternion.Euler (yAngle,xAngle, 0.0f);

			}
		}
	}
}
