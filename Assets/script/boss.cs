using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour {
	public Animation anim;
	public 	GameObject g1,g2,g3,g4,g5,player;
	Vector3 dir,pos1,pos2,pos3,pos4,pos5,dir1,dir2,temp;
	int flag1,flag2,flag_hitting;
	public int check;
	// Use this for initialization
	void Start () {
		pos1 = g1.transform.position;
		pos2 = g2.transform.position;
		pos3 = g3.transform.position;
		pos4 = g4.transform.position;
		pos5 = g5.transform.position;
		player = GameObject.FindGameObjectWithTag ("archer");
		dir = pos1 - transform.position;
		this.transform.rotation = Quaternion.LookRotation (dir);
		flag1 = 1;
		flag_hitting = 0;
	}
	
	// Update is called once per frame
	void Update () {

	//	dir1 = pos1 - transform.position;
	//	dir2 = pos2 - transform.position;
		if(flag_hitting==0)
		transform.Translate (0f, 0f, 6f * Time.deltaTime);

		if (flag_hitting == 1) {
			dir2 = player.transform.position-transform.position;
			dir2.y = 0;
			this.transform.rotation = Quaternion.LookRotation (dir2);
			anim.Stop("walk");
			anim.Play ("attack");
			if (anim["attack"].normalizedTime>0.8f) {
				anim.Play ("walk");
				this.transform.rotation = Quaternion.LookRotation (temp);
				flag_hitting = 0;
			}

		}

	}

	public void boss_hit ()

	{


		flag_hitting = 1;
		dir2 = player.transform.position-transform.position;
		dir2.y = 0;
		this.transform.rotation = Quaternion.LookRotation (dir2);
		anim.Stop("walk");
		anim.Play ("attack");


			//Debug.Log ("thissssisssittttttt");
			anim.Stop("attack");
			anim.Play ("walk");
			flag_hitting = 0;




	}

	public void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.tag == "bos_trigger") {

			if (flag1 % 5 == 0) {	
				dir = pos1 - transform.position;
				dir.y = 0;
				flag1++;
			}
			else
				if(flag1 % 5 == 1)
			{	
				dir = pos2 - transform.position;
				dir.y = 0;
					temp = dir;
					flag_hitting = 1;
				flag1++;
			}
				else
					if(flag1 % 5== 2)
					{	
						dir = pos3 - transform.position;
						dir.y = 0;
						flag1++;
					}
					else
						if(flag1 % 5== 3)
					{	
				
						dir = pos4 - transform.position;
						dir.y = 0;
							temp = dir;
							flag_hitting = 1;

						flag1++;
					}

						else
						{	
							dir = pos5 - transform.position;
							dir.y = 0;
							flag1++;
						}
			
			this.transform.rotation = Quaternion.LookRotation (dir);
		
		}

	}
}
