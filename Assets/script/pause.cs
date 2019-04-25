using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour {
	public GameObject left,right,jump,home,pause,resume,shoot;
	// Use this for initialization
	public save_details sdd;
	void Start(){
		Time.timeScale = 1;
	}
	public void Onpause()
	{
		shoot.SetActive(false);
		left.SetActive(false);
		right.SetActive(false);
		jump.SetActive(false);
		pause.SetActive (false);
		home.SetActive (true);
		resume.SetActive (true);
		AudioListener.pause = true;
		Time.timeScale = 0;
	}
	public void Onresume()
	{int x = sdd.Load_Mute ();
		if (x == 0) {
			AudioListener.pause = false;
		}
		AudioListener.pause = false;
		Debug.Log (resume);
		Time.timeScale = 1;
		shoot.SetActive(true);
		left.SetActive(true);
		right.SetActive(true);
		jump.SetActive(true);
		pause.SetActive (true);
		home.SetActive (false);
		resume.SetActive (false);
	}
	public void onHome()
	{
		Application.LoadLevel ("menu_scene");
	}
}
