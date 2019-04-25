using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power_up1 : MonoBehaviour {
	public GameObject gen,up;
    float t_gen_after,t_to_be=120;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ( Time.timeSinceLevelLoad>t_to_be) {
			Debug.Log("jkjljljljljl",gameObject);
			t_to_be = Random.Range (60, 90) + t_to_be ;
			Instantiate (gen,new Vector3(up.transform.position.x,up.transform.position.y+7,up.transform.position.z) ,up.gameObject.transform.rotation,null);
		}
		
	}
}
