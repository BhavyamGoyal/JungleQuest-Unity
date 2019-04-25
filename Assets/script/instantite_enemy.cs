using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantite_enemy : MonoBehaviour {
	public GameObject[] empty_objs;

	public GameObject arrows,knight,p,quiver1,quiver2,spider1,emptysp1,emptysp2;
	private following f;
	public int random,count,rl,dif1,dif2,time_to_be,ttb1,ttb2,rand,count_spider;

	// Use this for initialization
	void Start () {
		count = 0;
		time_to_be = 0;
		rl = 0;
		ttb1 = 2;
		ttb2 = 30;
		//InvokeRepeating("Instantiate_enemy",2.0f,4f);

	//	StartCoroutine(Instantiate_enemy());
		dif1 = 4;
		dif2 = 3;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Time.timeSinceLevelLoad > time_to_be) {
			rand = Random.Range (1, 10);
			if (rand <= 5) {
				Destroy (Instantiate (arrows, quiver1.transform.position, quiver1.transform.rotation), 20f);

			} else {
				Destroy (Instantiate (arrows, quiver2.transform.position, quiver2.transform.rotation, null), 20f);
			}

			time_to_be = time_to_be + 35;

		}

		if (Time.timeSinceLevelLoad > ttb1&& count<41)
		{
			if (count <= 15) {
				count++;
				if (rl <= 2) {
					random = Random.Range (1, 3);
					p = Instantiate (knight, empty_objs [random].transform.position, empty_objs [random].transform.rotation);
					p.GetComponent<following> ().flag_rl = 0;
					rl++;
				} else {
					random = Random.Range (4, 6);

					p = Instantiate (knight, empty_objs [random].transform.position, empty_objs [random].transform.rotation);
					p.GetComponent<following> ().flag_rl = 1;
					rl++;
					if (rl == 7)
						rl = 0;

				}
				ttb1 = ttb1 + 4;
				Debug.Log ("insttttttt");

			}
			else
				if (count > 15 && count < 40) {
					count++;
					if (rl <= 2) {
						random = Random.Range (1, 3);
						p = Instantiate (knight, empty_objs [random].transform.position, empty_objs [random].transform.rotation);
						p.GetComponent<following> ().flag_rl = 0;
						rl++;
					} else {
						random = Random.Range (4, 6);

						p = Instantiate (knight, empty_objs [random].transform.position, empty_objs [random].transform.rotation);
						p.GetComponent<following> ().flag_rl = 1;
						rl++;
						if (rl == 7)
							rl = 0;

					}
				ttb1 = ttb1 + 3;

				}

		}

		if (Time.timeSinceLevelLoad > ttb2&& count_spider<35)
		{
			if (count_spider <= 15) {
				count_spider++;
				rand = Random.Range (1, 10);
				if (rand <= 5) {
					Instantiate (spider1, emptysp1.transform.position, emptysp1.transform.rotation, null);

				} else {
					Instantiate (spider1, emptysp2.transform.position, emptysp2.transform.rotation, null);
				}

				ttb2 = ttb2 + 15;


			}
			else
				if (count_spider > 15) {
					count_spider++;
					rand = Random.Range (1, 10);
					if (rand <= 5) {
						Instantiate (spider1, emptysp1.transform.position, emptysp1.transform.rotation, null);

					} else {
						Instantiate (spider1, emptysp2.transform.position, emptysp2.transform.rotation, null);
					}

					ttb2 = ttb2 + 9;


				}

		}



		




		
	}

	IEnumerator Instantiate_enemy()
	{
		int random,fl;
		yield return new WaitForSeconds (2f);
		while (count <= 41) {
			if (count <= 15) {
				count++;
				if (rl <= 2) {
					random = Random.Range (1, 3);
					p = Instantiate (knight, empty_objs [random].transform.position, empty_objs [random].transform.rotation);
					p.GetComponent<following> ().flag_rl = 0;
					rl++;
				} else {
					random = Random.Range (4, 6);
			
					p = Instantiate (knight, empty_objs [random].transform.position, empty_objs [random].transform.rotation);
					p.GetComponent<following> ().flag_rl = 1;
					rl++;
					if (rl == 7)
						rl = 0;
				
				}
				yield return new WaitForSeconds (dif1);
				Debug.Log ("insttttttt");

			}
			else
			if (count > 15 && count < 40) {
				count++;
				if (rl <= 2) {
					random = Random.Range (1, 3);
					p = Instantiate (knight, empty_objs [random].transform.position, empty_objs [random].transform.rotation);
					p.GetComponent<following> ().flag_rl = 0;
					rl++;
				} else {
					random = Random.Range (4, 6);

					p = Instantiate (knight, empty_objs [random].transform.position, empty_objs [random].transform.rotation);
					p.GetComponent<following> ().flag_rl = 1;
					rl++;
					if (rl == 7)
						rl = 0;

				}
				yield return new WaitForSeconds (dif2);

			}
	
		}
	
	
	
	}
}
