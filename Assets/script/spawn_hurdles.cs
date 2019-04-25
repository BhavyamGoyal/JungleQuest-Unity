using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_hurdles : MonoBehaviour {
	public GameObject hurd_bladetrap,hurd_greataxetrap,hurd_hammertrap,hurd_sawtrap,hurd_sawtrap2,hurd_trapcutter,hurd_trapfire,hurd_trapneedle, empty1,empty2,empty3,g;
	int prev,rand,difficulty;
	//manager manage;
	// Use this for initialization
	void Start () {

		rand = 0;
		if (Time.timeSinceLevelLoad > 3000) {
			difficulty = 3;
		} else if (Time.timeSinceLevelLoad > 1500) {
			difficulty = 2;
		} else {
			difficulty = 1;}
		if (difficulty == 1) {
			rand = Random.Range (1,8);
			g = Instantiate_object(rand);
			g.transform.position = empty2.transform.position;

		}
		if (difficulty == 2) {
			rand = Random.Range (1,8);
			g = Instantiate_object(rand);
			g.transform.position = empty3.transform.position;
			rand = Random.Range (1,8);
			g = Instantiate_object(rand);
			g.transform.position = empty1.transform.position;


		}


		if (difficulty == 3) {
			rand = Random.Range (1,8);
			g = Instantiate_object(rand);
			g.transform.position = empty2.transform.position;
			rand = Random.Range (1,8);
			g = Instantiate_object(rand);
			g.transform.position = empty1.transform.position;
			rand = Random.Range (1,8);
			g = Instantiate_object(rand);
			g.transform.position = empty3.transform.position;


		}


	}
	
	// Update is called once per frame
	void Update () {
		

		
	}
	GameObject Instantiate_object(int r)
	{
		GameObject go;
		go = null;
		if (r == 1) {
			go = Instantiate (hurd_bladetrap);
			}

		if (r == 2) {
			go = Instantiate (hurd_greataxetrap) ;
		}if (r == 3) {
			go = Instantiate (hurd_hammertrap) ;
		}if (r == 4) {
			go = Instantiate (hurd_sawtrap );
		}if (r == 5) {
			go = Instantiate (hurd_sawtrap2 );
		}
		if (r == 6) {
			go = Instantiate (hurd_trapfire );
		}if (r == 7) {
			go = Instantiate (hurd_trapcutter );
		}if (r == 8) {
			go = Instantiate (hurd_trapneedle );
		}

		go.transform.SetParent (transform);
	
		return go;


	}

}
