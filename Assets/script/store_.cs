using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class store_ : MonoBehaviour {
	public int level_arrowpwr,level_coinpwr,level_quieverpwr,level_shieldpwr;
	int cost_arrpwr,cost_coinpwr,cost_quiverpwr,cost_shieldpwr;
	public int coins,flag_mute;
    public save_details sdd;
	public Text coin_txt,cost_arrpwrtxt,cost_coinpwrtxt,cost_quiverpwrtxt,cost_shieldpwrtxt,rate_1,rate_2,rate_3,rate_4;
	public GameObject shop,menu,mute_b,unmute_b,img_ar1,img_ar2,img_ar3;


	// Use this for initialization
	void Start () {

		sdd.SaveCoins (100000);


		coins = sdd.Load_Coins ();
		coin_txt.text = coins.ToString();
		//Debug.Log ("coins loaded==" + coins);
		flag_mute = sdd.Load_Mute();
		if (flag_mute == 0) {
			mute_b.SetActive (false);
			unmute_b.SetActive (true);
			AudioListener.pause = false;
		} else {
			mute_b.SetActive (true);
			unmute_b.SetActive (false);
			AudioListener.pause = true;
		
		}
		level_arrowpwr = sdd.Load_level (1);
		level_coinpwr = sdd.Load_level (2);
		level_quieverpwr = sdd.Load_level (3);
		level_shieldpwr = sdd.Load_level (4);

		cost_arrpwr = 2500*(level_arrowpwr+1);
		cost_coinpwr = 3000*(level_coinpwr+1);
		cost_quiverpwr = 500*(level_quieverpwr+1);
		cost_shieldpwr = 1000*(level_shieldpwr+1);
		cost_arrpwrtxt.text = "LEV " + level_arrowpwr;
		rate_1.text =  cost_arrpwr + "";

		cost_coinpwrtxt.text = "LEV " + level_coinpwr;
		rate_2.text =  (cost_coinpwr )+ "";

		cost_quiverpwrtxt.text = "LEV " + level_quieverpwr;
		rate_3.text =  ( cost_quiverpwr )+ "";
		cost_shieldpwrtxt.text = "LEV " + level_shieldpwr;
		rate_4.text = ( cost_shieldpwr )+ "";


		if (level_arrowpwr == 0) {
			img_ar1.SetActive (true);
			img_ar2.SetActive (true);
		}
		if (level_arrowpwr == 1) {
			img_ar1.SetActive (true);
			img_ar2.SetActive (true);
			img_ar3.SetActive (true);
		}

	}
	// Update is called once per frame
	void Update () {
		
	}
	public void OnQuit()
	{
		Application.Quit ();

	}
	public void OnBack()
	{
		menu.SetActive (true);
		shop.SetActive (false);

	}
	public void OnShop()
	{
		menu.SetActive (false);
		shop.SetActive (true);

	}

	public void OnPlay()
	{
		Application.LoadLevel ("scene0");

	}
	public void OnMute()
	{
		

		flag_mute = 1;
		mute_b.SetActive (true);
		unmute_b.SetActive (false);
		AudioListener.pause = true;
		sdd.Save_Mute (flag_mute);
		

	}
	public void OnUnMute()
	{
		
			flag_mute = 0;
			mute_b.SetActive (false);
			unmute_b.SetActive (true);
			AudioListener.pause = false;
			sdd.Save_Mute (flag_mute);



	}

	public void Button_arrpwr()
	{



		level_arrowpwr = sdd.Load_level (1);
		//Debug.Log ("level loaded==" + level_arrowpwr);
		if (level_arrowpwr < 2) {
			if (coins >= cost_arrpwr) {
				coins = coins - cost_arrpwr;
				coin_txt.text = coins.ToString ();

				level_arrowpwr++;
				cost_arrpwr = 2500 * (level_arrowpwr + 1);



				cost_arrpwrtxt.text = "LEV " + (level_arrowpwr);
				rate_1.text = cost_arrpwr + "";

				if (level_arrowpwr >= 1) {
				
					img_ar3.SetActive (true);
				}
				sdd.SaveCoins (coins);
				sdd.Save_level (1, level_arrowpwr);

			} else
				Debug.Log ("not epossible");
		}

	}
	public 	void Button_coinpwr()
	{


		level_coinpwr = sdd.Load_level (2);
		if (level_coinpwr <= 2) {
			if (coins >= cost_coinpwr) {
				coins = coins - cost_coinpwr;
				coin_txt.text = coins.ToString ();
				level_coinpwr++;
				cost_coinpwr = 3000 * (level_coinpwr + 1);
				cost_coinpwrtxt.text = "LEV " + (level_coinpwr);
				rate_2.text = (cost_coinpwr) + "";
				sdd.SaveCoins (coins);
				sdd.Save_level (2, level_coinpwr);

			} else
				Debug.Log ("not epossible");
		}
	}

	public 	void Button_Queiverpwr()
	{


		level_quieverpwr = sdd.Load_level (3);
		if (level_quieverpwr <= 2) {
			if (coins >= cost_quiverpwr) {
				coins = coins - cost_quiverpwr;
				coin_txt.text = coins.ToString ();
				level_quieverpwr++;
				cost_quiverpwr = 500 * (level_quieverpwr + 1);
				cost_quiverpwrtxt.text = "LEV " + level_quieverpwr;
				rate_3.text = (cost_quiverpwr) + "";
				sdd.SaveCoins (coins);
				sdd.Save_level (3, level_quieverpwr);

			} else
				Debug.Log ("not epossible");
		}
	}
	public 	void Button_Shieldpwr()
	{


		level_shieldpwr = sdd.Load_level (4);
		if (level_shieldpwr <= 2) {
			if (coins >= cost_shieldpwr) {
				coins = coins - cost_shieldpwr;
				coin_txt.text = coins.ToString ();
				level_shieldpwr++;
				cost_shieldpwr = 1000 * (level_shieldpwr + 1);
				cost_shieldpwrtxt.text = "Lev " + level_shieldpwr;
				rate_4.text = (cost_shieldpwr) + "";
				sdd.SaveCoins (coins);
				sdd.Save_level (4, level_shieldpwr);

			} else
				Debug.Log ("not epossible");
		}
	}
}
