using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class manager : MonoBehaviour {
	public GameObject[] tilePrefab;
	public Transform playerTransform;
	public float spawnz=60.0f;
	private float tileLength=58f;
	//private horse_controll ho;
	private GameObject distanceg,coins_textg;
	private Text distance,coins_text;
	public int noOfTiles= 3,met=1;
	public float dis;
	public int coins,coins_loaded,randecide,countforstraight=1,both=1,sigle=0;
	private List<GameObject> activeTiles;
	float x=0f;
	Vector3 begin;
	public GameObject meteor;
	private GameObject empty_m,camera_scene;
	public save_details sd;
	int  random,previous,flag;// Use this for initialization
	void Start () {
		int i;

		//distance.text = sd.Load_Distance ();
		//disload = sd.Load_Distance ();
		//coins_loaded=sd.Load_Coins();
		//Debug.Log ("coins loaded are"+coins_loaded);
		//coins = sd.Load_coins ();
		coins=0;
		random = 0;
		flag=1;
		randecide = 0;
		activeTiles = new List<GameObject> ();
		playerTransform=GameObject.FindGameObjectWithTag("Player").transform;
		begin = playerTransform.position;
		//ho=GameObject.FindGameObjectWithTag("Player").GetComponent<horse_controll>();
		distanceg = GameObject.FindGameObjectWithTag ("score_text");
		coins_textg = GameObject.FindGameObjectWithTag ("coin_text");
		distance = distanceg.GetComponent<Text> ();
		coins_text = coins_textg.GetComponent<Text> ();
		empty_m = GameObject.FindGameObjectWithTag ("empty_m");
		camera_scene = GameObject.FindGameObjectWithTag ("cam_scene");
		dis = 1000;

		for (i = 0; i < noOfTiles; i++) {
			SpawnTile ();


		}
	}
	// Update is called once per frame
	void Update () {
		//Debug.Log ();
		dis =1000- ((playerTransform.position.z-begin.z)/6); //+ (float)disload;
		distance.text = (Mathf.Floor (dis))+"m";
		coins_text.text = coins.ToString();

		/*if (ho.dir == 2) {
			if ((Mathf.Floor (Time.timeSinceLevelLoad)) % 4 == 0 && met == 1) {
				Instantiate (meteor, empty_m.transform.position, empty_m.transform.localRotation, camera_scene.transform);
				met = 0;
			} 
			if ((Mathf.Floor (Time.timeSinceLevelLoad)) % 4 != 0) {
				met = 1;
			}
		}*/
		if ((spawnz - playerTransform.position.z) <  tileLength) {
		
			SpawnTile ();
		//	Debug.Log("Spawning");
			DeleteTile ();
		//	Debug.Log("deleting");
		}

	}

		private void SpawnTile(int prefabIndex=-1)
		{
			GameObject go;
		float z = 0f;
		previous = random;
		if ((countforstraight <=0)) {	
			
			random = 0;

		
				countforstraight++;

		}

		else{	
			randecide=Random.Range (0,100);

			if (randecide >= 30)
				random = 0;
			else {
				//random = 1;
				random=0;
		//		Debug.Log ("turn block =" + random);
				countforstraight = 0;

			}

		
				
		}


		go = Instantiate (tilePrefab [random] as GameObject);
		go.transform.SetParent (transform);

		/*if (dis < 980) {
			go.GetComponent<spawn_0_hurdles> ().set_flag();

			Debug.Log("hurdlessss");
		}*/

		if (previous == 0 && random == 0) {
			go.transform.position =new Vector3(x,0f,spawnz);
		} else if (previous == 0 && random ==1) {
			//set for turntile after straight
			go.transform.position = new Vector3(x,0f,spawnz) ;
		}
		else if (previous == 1 && random == 0) {
			//set for strat after turn
			z=14f+spawnz;
			x = x + 187.7f;
			go.transform.position=new Vector3(x,0f,z);
			spawnz += 15;
				
		}
	//		go.transform.Rotate (0, 90, 0);
			spawnz += tileLength;
			activeTiles.Add (go);

		}
	private void DeleteTile()
	{
		Destroy (activeTiles [0]);
		activeTiles.RemoveAt (0);
	}
}
