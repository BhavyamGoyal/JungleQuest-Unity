using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quiever_arrsc : MonoBehaviour {

	// Use this for initialization
	public camp_shoot cs;
	// Use this for initialization
	void Start () {
		cs=GameObject.FindGameObjectWithTag ("archer_parent").GetComponent<camp_shoot> ();
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (0,0, 100 * Time.deltaTime);

	}


	void OnTriggerEnter(Collider c)
	{	Debug.Log("quiverrrrr");
		if (c.gameObject.tag == "arrow") {
			Debug.Log("quiverrrrr");
			cs.addArrows ();
			cs.addArrows ();
			Destroy (c.gameObject);
			Destroy (gameObject);
		}
	}
}
