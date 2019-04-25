using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiate_0 : MonoBehaviour {
	int count,d ;
	int flag,fl1,fl2,fl3,fl4,flb1,flb2,flb3,flb4;
	public int sc_count,t_to_ble1=670 ,t_to_ble=880,t_to_be=11,t_to_be1,dif=0,dif_barel,for_barrel=180,count_e;
	public GameObject enemy,enemy2,emp1,emp2,box,barrel,tree1;
	public manager m;
	GameObject p,dest;
	Vector3 v;
	int range1,range2,range3,range4,range5;
	// Use this for initialization
	void Start () {
		d = 1000;
		dif_barel = 0;
		count = 0;
		dif = 0;
		t_to_be = 880;
		t_to_be1 = 670;
		count_e = 0;
		m = gameObject.GetComponent<manager> ();
		range1 = Random.Range (1, 7);
		range2 = Random.Range (5,10);
		range3=Random.Range (15,25);
		flag = 1;
	

	}
	
	// Update is called once per frame
	void Update () {
		//	range1 = Random.Range (1, 7);
		//	range2 = Random.Range (5,15);
		Debug.Log("count of eeeeee"+count_e);
		if (count_e < 0)
			count_e = 0;


		//	Debug.Log ("flag is " + flag);
		//Debug.Log ("dis " + m.dis);
			if (count_e <= 3 && flag == 1) {
			if (m.dis>= (978 + range1)&&m.dis<= (978.1 + range1)&&fl1==0) {
				inst_e1_front (8);
				fl1=1;
			//	Debug.Log ("thidssssss");
			} 
			if ((m.dis) >= (950 + range1)&&m.dis<= (950.1+ range1)&&fl2==0) {
				inst_e1_front (8);
				inst_e1_back (2);
				fl2=1;
			
			}
			if ((m.dis) >= (925 + range1)&&m.dis<= (925.1 + range1)&&fl3==0) {
				inst_e2_front (11);
				inst_e1_front (8);
				inst_e1_back (0);
				fl3=1;
			}
			if ((m.dis) >= (900 + range1)&m.dis<= (900.1+ range1)&&fl4==0) {
				inst_e1_back (0);
				inst_e2_front (8);
				fl4=1;
			}
	if (m.dis <= 880) {
				if (m.dis > (d - 260 + range2)&& m.dis<t_to_be) {
					inst_e1_back (0);
					inst_e2_front (10);
					inst_e1_front (8);
				//	dif_barel = 1;
					t_to_be = t_to_be - range2;
				} else if (m.dis > (d - 550 + range1)&& m.dis<t_to_be1) {
					inst_e1_front (8);
					inst_e1_front (10);
					inst_e1_back (2);
					inst_e2_back (0);
					dif_barel = 2;
					t_to_be = t_to_be1 - range2;
				} else if (m.dis > d - 400) {
					dif_barel = 3;
					//flag = 0;
				} 
			}
		}

/*	if (m.dis>= (978 + range1)&&m.dis<= (978.1 + range1)&&flb1==0) {
			inst_barrel();
			flb1=1;
			//	Debug.Log ("thidssssss");
		} 
		if ((m.dis) >= (950 + range1)&&m.dis<= (950.1+ range1)&&flb2==0) {
			inst_barrel();

			flb2=1;

		}
		if ((m.dis) >= (925 + range1)&&m.dis<= (925.1 + range1)&&flb3==0) {
			inst_barrel();
			flb3=1;
		}
		if ((m.dis) >= (900 + range1)&m.dis<= (900.1+ range1)&&flb4==0) {
			inst_barrel();
			flb4=1;
		}
		if (m.dis <= 880) {
			if (m.dis > (d - 260 + range2)&& m.dis<t_to_ble) {
				inst_barrel();
				//dif_barel = 1;
				t_to_ble = t_to_ble - range3;
			} else if (m.dis > (d - 550 + range1)&& m.dis<t_to_ble1) {
				inst_barrel();
				//dif_barel = 2;
				t_to_ble1 = t_to_ble1 - range3;
			} else if (m.dis > d - 400) {
				dif_barel = 3;
				//flag = 0;
			} 
		}*/

		/*if (Time.timeSinceLevelLoad >=35 && Time.timeSinceLevelLoad<=35.02f) {
			Instantiate (enemy, emp2.transform.position, emp2.transform.rotation,null);
			count_e++;
			v = new Vector3 (emp2.transform.position.x, emp2.transform.position.y, emp2.transform.position.z + 5);
			Instantiate (enemy2, v, emp2.transform.rotation,null);
			count_e++;
		}

		if (Time.timeSinceLevelLoad >= 20&&Time.timeSinceLevelLoad <=20.02f) {

			Instantiate (enemy, emp2.transform.position, emp2.transform.rotation,null);
			count_e++;
		}
			*/		

		/*		if (Time.timeSinceLevelLoad >for_barrel) {

		//	Debug.Log (dif_barel);

		if (dif_barel == 1) {

			for_barrel= Random.Range (60,90) + for_barrel;

			inst_barrel();

		}
		if (dif_barel == 2) {
			for_barrel= Random.Range (45,50) + for_barrel;
			inst_barrel();

		}
		if (dif_barel == 3) {
			for_barrel= Random.Range (30,40 ) + for_barrel;
			inst_barrel();

		}


	}*/

	/*	if (Time.timeSinceLevelLoad > t_to_be) {

	t_to_be = Random.Range (15, 25) + t_to_be;
	if (dif == 1&&count_e<=2) {
		inst1 ();
		Debug.Log("difficulty"+dif);
	}
	if (dif == 2 && count_e <= 2) {
		inst2 ();
		Debug.Log("difficulty"+dif);
	}
	if (dif == 3 && count_e <= 2) {
		inst3 ();
		Debug.Log("difficulty"+dif);
	}
}*/



	}
	public void inst_barrel(Vector3 v)
	{
		
		//v = new Vector3 (emp2.transform.position.x, emp2.transform.position.y, emp2.transform.position.z + 6);
		if(GameObject.FindGameObjectWithTag("moving_barrel")==null)
		{      Debug.Log ("barrrrrrel");
				Instantiate (barrel, v, emp2.transform.rotation,null);
			}

	}
	/*public void inst3f()
	{

		Instantiate (enemy, emp2.transform.position, emp2.transform.rotation,null);
		v = new Vector3 (emp2.transform.position.x, emp2.transform.position.y, emp2.transform.position.z + 2);
		Instantiate (enemy, v, emp2.transform.rotation,null);
		v.z += 2;

		Instantiate (enemy, v, emp2.transform.rotation,null);

	
		v.z += 2;
		v.y += 5;
		//Instantiate (box, v, emp2.transform.rotation,null);
		count_e += 3;
	}

	public void inst2fr1back()
	{
		Instantiate (enemy, emp2.transform.position, emp2.transform.rotation,null);
		v = new Vector3 (emp2.transform.position.x, emp2.transform.position.y, emp2.transform.position.z + 2);
		Instantiate (enemy, v, emp2.transform.rotation,null);
		Instantiate (enemy, emp1.transform.position, emp1.transform.rotation,null);

		v.z += 2;
		v.y += 5;
	//	Instantiate (box, v, emp2.transform.rotation,null);
		count_e += 3;
	}

	public void inst3()
	{
		Instantiate (enemy, emp2.transform.position, emp2.transform.rotation,null);
		v = new Vector3 (emp2.transform.position.x, emp2.transform.position.y, emp2.transform.position.z + 2);
		Instantiate (enemy, v, emp2.transform.rotation,null);
		Instantiate (enemy, emp1.transform.position, emp1.transform.rotation,null);
		v = new Vector3 (emp2.transform.position.x, emp2.transform.position.y, emp2.transform.position.z + 5);
		Instantiate (enemy2, v, emp2.transform.rotation,null);
	
		v.z += 4;
		v.y += 5;
	//	Instantiate (box, v, emp2.transform.rotation,null);
		count_e += 4;

	}*/

	public void inst_e1_front(int zpos)
	{
		v = new Vector3 (emp2.transform.position.x, emp2.transform.position.y, emp2.transform.position.z + zpos);
		Instantiate (enemy, v, emp2.transform.rotation,null);
		count_e++;
	}

	public void inst_e1_back (int zpos)
	{
		v = new Vector3 (emp1.transform.position.x, emp1.transform.position.y, emp1.transform.position.z + zpos);
		Instantiate (enemy, v, emp1.transform.rotation,null);
		count_e++;
	}

	public void inst_e2_front(int zpos)
	{
		v = new Vector3 (emp2.transform.position.x, emp2.transform.position.y, emp2.transform.position.z + zpos);
		Instantiate (enemy2, v, emp2.transform.rotation,null);
		count_e++;
	}

	public void inst_e2_back(int zpos)
	{
		v = new Vector3 (emp1.transform.position.x, emp1.transform.position.y, emp1.transform.position.z + zpos);
		Instantiate (enemy2, v, emp1.transform.rotation,null);
		count_e++;
	}




	public void coInst()
	{
		int i, r = 0;

		r = Random.Range (5, 10);


		v = new Vector3 (emp2.transform.position.x, emp2.transform.position.y + 5, emp2.transform.position.z + 8);
		dest = GameObject.FindGameObjectWithTag ("box");
		if (dest != null) {
			Destroy (dest);
		}
		Instantiate (box, v, emp2.transform.rotation, null);


		v.y = emp2.transform.position.y;
		v.z += 13;
		
		if (m.dis <= 770) {
			if (r <= 3) {
				v.y = -0.18f;
				Instantiate (tree1, v, emp2.transform.rotation, null);
			}
			else if (r <= 7)
				inst_barrel (v);
			else {

				inst_e1_front (8);
				//count_e++;
			}
		} else {

			if (r <= 6) {
				v.y = -0.18f;
				Instantiate (tree1, v, emp2.transform.rotation, null);
			}
			else {

				inst_e1_front (8);
				//count_e++;
			}
	
		}
	}
	//Debug.Log (count + "hjkhk");

		/*if (Time.timeSinceLevelLoad > 100f) {
			Instantiate (enemy, emp2.transform.position, emp2.transform.rotation,null);
			v = new Vector3 (emp2.transform.position.x, emp2.transform.position.y, emp2.transform.position.z + 2);
			Instantiate (enemy, v, emp2.transform.rotation,null);
			Instantiate (enemy, emp1.transform.position, emp1.transform.rotation,null);
			v = new Vector3 (emp2.transform.position.x, emp2.transform.position.y, emp2.transform.position.z + 5);
			Instantiate (enemy2, v, emp2.transform.rotation,null);
			v.z += 4;
			Instantiate (box, v, emp2.transform.rotation,null);

		}

		else
		if (Time.timeSinceLevelLoad > 60f) {
			Instantiate (enemy, emp2.transform.position, emp2.transform.rotation,null);
			v = new Vector3 (emp2.transform.position.x, emp2.transform.position.y, emp2.transform.position.z + 2);
			Instantiate (enemy, v, emp2.transform.rotation,null);
			Instantiate (enemy, emp1.transform.position, emp1.transform.rotation,null);

				if (dest != null) {
					Destroy (dest);
				}
				v.z += 2;
				Instantiate (box, v, emp2.transform.rotation,null);
		}
		else
		if (Time.timeSinceLevelLoad > 10f) {

			 Instantiate (enemy, emp2.transform.position, emp2.transform.rotation,null);
			v = new Vector3 (emp2.transform.position.x, emp2.transform.position.y, emp2.transform.position.z + 2);
			Instantiate (enemy, v, emp2.transform.rotation,null);
					v.z += 2;
	
					Instantiate (enemy, v, emp2.transform.rotation,null);

					if (dest != null) {
						Destroy (dest);
					}
			v.z += 2;
					 Instantiate (box, v, emp2.transform.rotation,null);
				}
	
		/*	
				p = Instantiate (enemy, emp1.transform.position, emp1.transform.rotation);
				p.transform.parent = null;
				p = Instantiate (enemy, emp2.transform.position, emp2.transform.rotation);
				p.transform.parent = null;
				v = new Vector3 (emp2.transform.position.x, emp2.transform.position.y, emp2.transform.position.z + 4);

				p = Instantiate (enemy2, v, emp2.transform.rotation);
				p.transform.parent = null;
			    v = new Vector3 (emp2.transform.position.x, emp2.transform.position.y+5, emp2.transform.position.z + 8);
		dest = GameObject.FindGameObjectWithTag ("box");
		if (dest != null) {
			Destroy (dest);
		}
		p = Instantiate (box, v, emp2.transform.rotation);
		p.transform.parent = null;*/

			
		
		
			


	
	


	}

