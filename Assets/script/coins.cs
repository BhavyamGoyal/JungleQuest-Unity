using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour {
	public AudioSource coin_aud;
	public manager m;

	// Use this for initialization
	void Start () {
		m = GameObject.FindGameObjectWithTag ("manager").GetComponent<manager> ();
		coin_aud = GameObject.FindGameObjectWithTag ("coin_sound").GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 100 * Time.deltaTime, 0);
		
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.CompareTag ("Player")||col.gameObject.CompareTag ("arrow")) {
		
			coin_aud.Play ();
			m.coins++;
			Destroy (gameObject);
		}


	
		}
}
