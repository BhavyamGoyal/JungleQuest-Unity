using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sword_control : MonoBehaviour {
	public Animation anim;
	public GameObject brea,sword_normal,sword_dragon,p,ps1,ps2,power,here;
	int grounded=1,fl=1,move_forward = 0;public int stri=0,strike1=0,strike2=0;
	public AudioSource  run_aud,swoosh,dia,collect;
	int sword_power = 1;
	float min=-45f;
	public AudioSource jump_s;
	int coins,jump_force=46500;
	public Text coin;
	public GameObject sword;
	int left=0;
	// Use this for initialization
	public Rigidbody rb;
	float move=0;
	void Start () {
		sword = sword_normal;
		anim.Play ("stance");
		sword_normal.SetActive (true);
		sword_dragon.SetActive(false);

	}

	// Update is called once per frame
	void Update () {
		if (transform.position.z > min)
		{	
			min = transform.position.z;
	}
	//	Debug.Log (gameObject.transform.position);
		if (left == 1 && transform.position.z<(min-60)) {
			move_forward = 0;
			if (move_forward == 1 && grounded==1) {
				anim.Play ("Take 001");
			}

		}
		if (strike1 == 1 && anim ["swordStrike1"].normalizedTime > .5) {
			strike1 = 0;

			if (move_forward == 1 && grounded==1) {
				anim.Play ("Take 001");
			}
			sword.GetComponent<BoxCollider> ().isTrigger=true;
		}
		if (strike2 == 1 && anim ["swordStrike2"].normalizedTime > .5) {
			strike2 = 0;
			sword.GetComponent<BoxCollider> ().isTrigger=true;
		}
		if (grounded == 1 && fl == 1) {
			run_aud.Play ();
			fl = 0;

		} 
		move = 8 * move_forward * Time.deltaTime;
		gameObject.transform.Translate (0, 0, move);
		if( anim["jump"].normalizedTime >= .9)
		{
			anim.Play ("stance");
			//anim.Stop ("jump");
			//anim.Blend ("Take 001");


		}
		if (grounded==0){
			fl = 1;
			run_aud.Stop ();
		}
		//Debug.Log (transform.position);

		transform.position = new Vector3 (1f, transform.position.y, transform.position.z);

	}
	public void jump()
	{
		if (grounded==1 ) {
			rb.AddForce (0,jump_force,0);
			anim.Stop ("Take 001");
			anim.Play ("jump");
			anim["jump"].speed=.35f ;
			//jump_aud.Play ();
			strike1 = 0;
			jump_s.Play ();
			strike2 = 0;
			grounded = 0;

		}

	}
	public void move_right(){
		
			strike1 = 0;
			strike2 = 0;
			move_forward = 1;
			run_aud.Play ();
			transform.localEulerAngles = new Vector3 (0, 90, 0);
		if(grounded==1){
			anim.Play ("Take 001");
		}
	}
	public void move_left(){
		
			
			move_forward = 1;
			strike1 = 0;
			strike2 = 0;
			left = 1;
			run_aud.Play ();
		transform.localEulerAngles = new Vector3 (0, 270, 0);
		if (grounded == 1) {
			anim.Play ("Take 001");
		}
	
	}

	void OnCollisionEnter(Collision col)
	{//Debug.Log ("grounded");
		if(col.gameObject.tag=="ground"){
			grounded=1;
			if (move_forward == 1) {
				anim.Play ("Take 001");
			}
		}
		if(col.gameObject.tag=="diamond"){
			dia.Play ();
			Destroy(Instantiate (ps2, transform.position, transform.rotation, null),1.6f);
			Destroy (col.gameObject);

			}

		if (col.gameObject.tag == "moving_barrel") {
			
			col.transform.root.GetComponent<move_barrel> ().move = 0;
			rb.AddForce (0, 30000, -30000);
		//	gameObject.GetComponent<Rigidbody> ().isKinematic = true;
			//Instantiate (brea, transform.position,transform.rotation,null);
			p=Instantiate (brea, col.gameObject.transform.position,col.gameObject.transform.rotation,null);
			Destroy (p, 1f);
			p=Instantiate (brea, col.gameObject.transform.position,col.gameObject.transform.rotation,null);
			Destroy (p, 1f);
			p=	Instantiate (brea, col.gameObject.transform.position,col.gameObject.transform.rotation,null);
			Destroy (p, 1f);
			Destroy (col.gameObject);
			//gameObject.GetComponent<Rigidbody> ().isKinematic = false;

		}
		if(col.gameObject.tag=="health1"){
			collect.Play ();
			Destroy(Instantiate (ps1, transform.position, transform.rotation, null),1.6f);
			Destroy (col.gameObject);
		}


		if(col.gameObject.tag=="coins"){
			dia.Play ();
			Destroy (col.gameObject);
			coins += 1;
			coin.text = coins.ToString();
		}
		if(col.gameObject.tag=="sword_up"){
			sword_normal.SetActive (false);
			sword = sword_dragon;
			sword_power = 2;
			sword.SetActive (true);
			sword.GetComponent<sword_script> ().swor = 2;
			sword_dragon.SetActive(true);
			Destroy (col.gameObject);
			sword.GetComponent<BoxCollider> ().isTrigger=true;
			collect.Play ();

		}
		if(col.gameObject.tag=="jump_up"){
			jump_force = 56500;
				Destroy (col.gameObject);
			collect.Play ();

		}
		if(col.gameObject.tag=="shield"){
			//	jump_force=5450;collect.Play ();
			Destroy(Instantiate (ps1, transform.position, transform.rotation, null),1.6f);
				Destroy (col.gameObject);
				collect.Play ();

		}
	}
	public void move_none(){
		move_forward = 0;
		anim.Play ("stance");
		left = 0;
		strike1 = 0;
		strike2 = 0;
	}
	public void strike (){
		
		if (stri >= 2) {
			if (strike2==0) {
				
				sword.GetComponent<BoxCollider> ().isTrigger=false;
				anim.Play ("swordStrike1");
				anim ["swordStrike1"].speed=1.5f;
				strike1 = 1;
				stri = 0;
				swoosh.Play ();
				if (sword_power == 2) {
					p=Instantiate (power,new Vector3(here.gameObject.transform.position.x,here.gameObject.transform.position.y+.3f,here.gameObject.transform.position.z),here.gameObject.transform.rotation);
					Destroy (p, 2f);
				}


			}
		} else if(strike1==0&&strike2==0 ){
			sword.GetComponent<BoxCollider> ().isTrigger=false;
			anim.Play ("swordStrike2");
			anim ["swordStrike2"].speed=1.5f;
			strike2 = 1;
			stri++;
			swoosh.Play ();

		}

	}

}
