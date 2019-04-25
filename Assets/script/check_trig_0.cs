using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class check_trig_0 : MonoBehaviour {
	public instantiate_0 i1;
	int health=100;
	public AudioSource sp;
	public Text healthtxt;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		health = 100;
		rb=gameObject.GetComponent<Rigidbody> ();
		healthtxt.text = health.ToString ();	
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}


	void OnCollisionEnter(Collision cd)
	{
		

	}
	public void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.tag == "trap") {
			rb.AddForce (0, 6000, -1000);
			sp.Play ();
			health = health - 20;
			healthtxt.text = health.ToString ();
		}
		if (c.gameObject.tag == "trigger_obj") {
			Debug.Log ("Trigger entered");
			i1.coInst ();
			Destroy (c.gameObject);
		}

		if (c.gameObject.tag == "spear")
		{
			sp.Play ();
			rb.AddForce (0, 5000, -2000);
			c.gameObject.transform.parent = gameObject.transform;
			//Destroy (c.gameObject, 4f);
			Destroy(c.gameObject,1);
			c.gameObject.GetComponent<spear_scrpt> ().speed = 0;
			health = health - 5;
			c.gameObject.transform.localPosition = new Vector3 (0.00f, 0.7675f, 0.381f);
			healthtxt.text = health.ToString ();
		}

		if (c.gameObject.tag == "spear_inhand"&& c.gameObject.transform.root.GetComponent<follow_0>().flag3==1) {
			rb.AddForce (0, 7000, -2000);
			sp.Play ();
			health = health - 5;
			healthtxt.text = health.ToString ();
		}

	}
	public void Spider_hit()
	{
		health = health - 5;
		rb.AddForce (0, 10000, -4000);
		healthtxt.text = health.ToString ();
	
	
	}

}
