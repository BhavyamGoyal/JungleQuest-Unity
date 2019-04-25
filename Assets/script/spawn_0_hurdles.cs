using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_0_hurdles : MonoBehaviour {

	public GameObject empty,empty1,coin1,coin2,trap1,trap2;
	Vector3 v;
	public int r,flag=0,fl2=0,fl3=0;
	public manager m;
	// Use this for initialization
	void Start () {
		m = GameObject.FindGameObjectWithTag ("manager").GetComponent<manager> ();
		flag = 0;
		fl2=1;
		fl3 =1;
	}
	
	// Update is called once per frame
	void Update () {

	//	Debug.Log ("my flag"+flag);
		v = new Vector3 (empty1.transform.position.x, empty1.transform.position.y, empty1.transform.position.z);
		if (m.dis>700f) {
			if (fl3 == 1) {
				r = Random.Range (1, 4);
				if (r == 1) {
					Instantiate (coin1, empty.transform.position, empty.transform.rotation, transform);
					fl3 = 0;
				} else if (r == 2) {
					Instantiate (coin2, empty.transform.position, empty.transform.rotation, transform);
					fl3 = 0;
				} 
				else {
					Instantiate (coin1, empty.transform.position, empty.transform.rotation, transform);
					Instantiate (coin2, empty.transform.position, empty.transform.rotation, transform);
					fl3 = 0;
				}

			}
		}
		else {
			if (fl2 == 1) {

				r = Random.Range (1, 2);
				if (r == 1) {
					Instantiate (coin1, empty.transform.position, empty.transform.rotation, transform);
					v.y = v.y - 0.4f;
					v.z += 15f;
					Instantiate (trap1, v, empty1.transform.rotation, transform);
					fl2 = 0;
				}
				if (r == 2) {
					Instantiate (coin2, empty.transform.position, empty.transform.rotation, transform);
					v.y = v.y + 0.42f;
					v.z += 15f;
					Instantiate (trap2, v, empty1.transform.rotation, transform);
					fl2 = 0;
				}
			}
		}

	}
	/*public void set_flag()
	{
		this.flag=1;
		Debug.Log ("funccccc"+this.flag);
	}*/
}
