using UnityEngine;
using System.Collections;

public class fall: MonoBehaviour {

	// Use this for initialization
	 Rigidbody rb;
	//public GameObject bush,bush2;
	 Vector3 pos;
	public AudioSource leaves;

	void Start () {
		pos=transform.position;
		rb = GetComponent<Rigidbody>();
	}


	void Update () {

	}
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag=="Player")
		{//leaves.Play ();
			StartCoroutine(fall_());

		}
	}

	IEnumerator fall_()
	{
		yield return new WaitForSeconds(4f);
		leaves.Play ();
		transform.position = new Vector3 (0, -10000, 0);
		yield return new WaitForSeconds(2f);
		transform.position = pos;
	

		yield return 0;
	}
}
