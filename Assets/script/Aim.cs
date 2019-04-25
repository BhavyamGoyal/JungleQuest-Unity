using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour {



		private LineRenderer l;
		// Use this for initialization
		void Start () {
			l=GetComponent<LineRenderer>();	

		}

		// Update is called once per frame
		void Update () {

		}
		void FixedUpdate()
		{
			RaycastHit hit;

			if (Physics.Raycast(transform.position, transform.forward, out hit))
			{
				
					l.SetPosition(1,new Vector3 (0,0,hit.distance));	
				

			}
		}
}


