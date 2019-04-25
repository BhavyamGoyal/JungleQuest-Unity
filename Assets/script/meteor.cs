using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteor : MonoBehaviour {
	
	public GameObject horse,cam_scene,ligh,fall;
	GameObject fa;
	Vector3 store;
	Vector3 dir;
	// Use this for initialization
	void Start () {
		horse = GameObject.FindGameObjectWithTag ("Player");
		cam_scene = GameObject.FindGameObjectWithTag ("cam_scene");
		store = new Vector3 (horse.transform.position.x,horse.transform.position.y+2,horse.transform.position.z);
		GameObject li = Instantiate (ligh, store, horse.transform.rotation,cam_scene.transform);
					 fa=Instantiate (fall, store, horse.transform.rotation,cam_scene.transform);
		Destroy (li, 2);
		Destroy (gameObject,5);
		Destroy (fa,5);
		 dir=fa.transform.position-transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (fa.transform.position+"global");
		Debug.Log (fa.transform.localPosition);

		transform.Translate (dir  *.3f* Time.deltaTime);



	}


}
