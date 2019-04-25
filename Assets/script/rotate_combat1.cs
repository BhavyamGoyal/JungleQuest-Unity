using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class rotate_combat1 : MonoBehaviour {
	public Quaternion v;
	public int scene=1,weapon=1;
	private Vector3 firstpoint; 
	private Vector3 secondpoint;
	public float xAngle = 0.0f; //angle for axes x for rotation
	public float yAngle = 0.0f;
	public float xAngTemp = 0.0f; //temp variable for angle
	public float yAngTemp = 0.0f;
	//public rotate_comat2 second;
	public GameObject sword, arrow,bsw,barr;
	public GameObject sw,csh;
	public sword cs;
	public	AudioSource draw; 
	public Animation anim;
	void  Start() {
		v = gameObject.transform.localRotation;

		firstpoint = new Vector3 (0, 0, 0);
		secondpoint = new Vector3 (0, 0, 0);



		xAngle = 230f; 
		yAngle = 0.0f;

		transform.localRotation = Quaternion.Euler(yAngle, xAngle, 0.0f);
	}

	void Update() {
		//Check count touches
		Debug.Log(gameObject.transform.localEulerAngles);
		if (Input.touchCount ==1) {
			//Touch began, save position
			if (Input.GetTouch (0).phase == TouchPhase.Began) {
				firstpoint = Input.GetTouch (0).position;
				if (firstpoint.x <1200||firstpoint.y<400)
					return;
				xAngTemp = xAngle;
				yAngTemp = yAngle;
			}
			//Move finger by screen
			if (Input.GetTouch (0).phase == TouchPhase.Moved) {
				secondpoint = Input.GetTouch (0).position;
				if ( firstpoint.x<1200 || firstpoint.y<400)
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








				if (yAngle > 10 && yAngle < 180) {
					yAngle = 10;
				}
				if (yAngle < 346 && yAngle >= 180) {
					yAngle = 346;
				}
				if (xAngle > 300 && scene == 1) {
					xAngle = 300f;

				}else if (xAngle < 190 && scene==1) {
					xAngle = 190f;

				}

				if (xAngle > 145 && scene==2) {
					xAngle = 145f;

				}else if (xAngle < 60 && scene==2) {
					xAngle = 60f;

				}
			//	second.xAngle = xAngle;
			//	second.yAngle = yAngle;

					transform.localRotation = Quaternion.Euler (yAngle,xAngle, 0.0f);

			}
		}
	}
	public void change()
	{
		if (scene == 1) {
			scene = 2;

			xAngle = 102.5f;
			xAngTemp = xAngle;
			yAngTemp = yAngle;
			transform.localRotation = Quaternion.Euler (yAngle, xAngle, 0.0f);
		} else {
			scene = 1;
			xAngle = 230f;
			xAngTemp = xAngle;
			yAngTemp = yAngle;
			transform.localRotation = Quaternion.Euler (yAngle, xAngle, 0.0f);
		
		}
	}
	public void sword_p()
	{
		if (weapon == 1) {
			weapon = 2;
			draw.Play ();
			cs.strike1 = 0;
			cs.strike2 = 0;
		//	csh.enabled = false;
			anim.Stop ("idleBow");
			anim.Play ("stance");
			csh.SetActive (false);
			sw.SetActive (true);;
			barr.SetActive (true);
			bsw.SetActive (false);
			arrow.SetActive (false);
			sword.SetActive (true);
		} else {
			weapon = 1;

			anim.Play ("idleBow");
			anim.Stop ("stance");
			csh.SetActive(true);
			barr.SetActive (false);
			bsw.SetActive (true);
			sw.SetActive (false);
			arrow.SetActive (true);
			sword.SetActive (false);
		

		}
		
		
	}
}
