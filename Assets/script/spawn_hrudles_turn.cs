using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_hrudles_turn : MonoBehaviour {

	public GameObject hurd_bladetrap,hurd_greataxetrap,hurd_hammertrap,hurd_sawtrap,hurd_sawtrap2,hurd_trapcutter,hurd_trapfire,hurd_trapneedle, empty1,empty2,empty3,g,empty4,empty5,empty6;
	int prev,rand,difficulty;
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

			Instantiate(g,empty2.transform.position, empty2.transform.localRotation,empty2.transform);
			rand = Random.Range (1,8);
			g = Instantiate_object(rand);
			Instantiate(g,empty4.transform.position, empty4.transform.localRotation,empty4.transform);
		}
		if (difficulty == 2) {

			rand = Random.Range (1,8);
			g = Instantiate_object(rand);
			Instantiate(g,empty1.transform.position, empty1.transform.localRotation,empty1.transform);
			rand = Random.Range (1,8);
			g = Instantiate_object(rand);
			Instantiate(g,empty3.transform.position, empty3.transform.localRotation,empty3.transform);
			rand = Random.Range (1,8);
			g = Instantiate_object(rand);
			Instantiate(g,empty5.transform.position, empty5.transform.localRotation,empty5.transform);
			rand = Random.Range (1,8);
			g = Instantiate_object(rand);
			Instantiate(g,empty6.transform.position, empty6.transform.localRotation,empty6.transform);
		}


		if (difficulty == 3) {
			rand = Random.Range (1,8);
			g = Instantiate_object(rand);
			Instantiate(g,empty1.transform.position, empty1.transform.localRotation,empty1.transform);
			rand = Random.Range (1,8);
			g = Instantiate_object(rand);
			Instantiate(g,empty2.transform.position, empty2.transform.localRotation,empty2.transform);

			rand = Random.Range (1,8);
			g = Instantiate_object(rand);
			Instantiate(g,empty3.transform.position, empty3.transform.localRotation,empty3.transform);
			rand = Random.Range (1,8);
			g = Instantiate_object(rand);
			Instantiate(g,empty5.transform.position, empty5.transform.localRotation,empty5.transform);
			rand = Random.Range (1,8);
			g = Instantiate_object(rand);
			Instantiate(g,empty4.transform.position, empty4.transform.localRotation,empty4.transform);
			rand = Random.Range (1,8);
			g = Instantiate_object(rand);
			Instantiate(g,empty6.transform.position, empty6.transform.localRotation,empty6.transform);
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
			go = hurd_bladetrap;
		}

		if (r == 2) {
			go =hurd_greataxetrap ;
		}if (r == 3) {
			go = hurd_hammertrap ;
		}if (r == 4) {
			go = hurd_sawtrap ;
		}if (r == 5) {
			go = hurd_sawtrap2 ;
		}
		if (r == 6) {
			go = hurd_trapfire ;
		}if (r == 7) {
			go = hurd_trapcutter ;
		}if (r == 8) {
			go = hurd_trapneedle ;
		}


		return go;


	}

}
