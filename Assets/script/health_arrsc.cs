using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class health_arrsc : MonoBehaviour {

	// Use this for initialization
	public int rem,fl1,h=20;
	public Image[] hearts ;
	public pause p;
	public AudioSource hit,lassthit;
	public Animation anim;
	public Button hitbutt;
	void Start () {fl1 = 0;

	}
	
	// Update is called once per frame
	void Update () {
		


	
		
	}

	public void decrement_health()
	{

		if (h >= 1) {
			h--;
			hit.Play ();
			hearts [h].enabled = false;
		} else 
		
			if(fl1==0){
			hitbutt.enabled = false;
			lassthit.Play ();
			
			anim.Play ("die1");
			fl1 = 1;
			if (anim ["die1"].normalizedTime >= 0.76f) {
				Time.timeScale = 0;
				//p.Onpause ();
			}
		}
	}

}
