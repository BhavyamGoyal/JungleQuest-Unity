using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_barrel : MonoBehaviour {
	public int move = 10;
	// Use this for initialization
	void Start () {
		move = 10;
		transform.eulerAngles = new Vector3 (0f, 0f, 90f);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -30) {
			Destroy (gameObject);
		}
		transform.Translate (0f, 0f, -move * Time.deltaTime);
	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "knight_small") {
			Destroy (col.gameObject);
		}
		if (col.gameObject.tag == "knight_small_spear") {
			Destroy (col.gameObject);
		}

	
	}
}
