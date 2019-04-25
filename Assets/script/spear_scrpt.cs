using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spear_scrpt : MonoBehaviour {
	//GameObject p;
	//Vector3 d;
	public int speed=13;
	int flag=0,r;
	// Use this for initialization
	void Start () {
	//	p = GameObject.FindGameObjectWithTag ("attack_here2");
		//	d=	 p.transform.position - this.transform.position;

		transform.parent = null;
		transform.Rotate (90, 0, 0);
		//this.transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.LookRotation (d), 350 );
		Destroy (gameObject, 5f);
	}
	
	// Update is called once per frame
	void Update () {
		if (flag == 0)
			gameObject.transform.Translate (0, speed * Time.deltaTime, 0);
		else {
			
			if(r<=5)
			transform.eulerAngles = new Vector3 (77.5f, -65f, 180f);
			else 
				transform.eulerAngles = new Vector3 (77f, 60f, 180f);
			gameObject.transform.Translate (0f, 8f* Time.deltaTime, 0f);
		}
		
	}

	public void spear_hit()
	{
		r = Random.Range (1,10);
		flag = 1;

	}
}
