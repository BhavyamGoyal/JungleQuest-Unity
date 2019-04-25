using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class save_details : MonoBehaviour {


	// Use this for initialization
	public void SaveCoins(int coins)
	{
		PlayerPrefs.SetInt ("Player_Coins", coins);
	
	
	}
	public int Load_Coins()
	{
		
		return(PlayerPrefs.GetInt ("Player_Coins"));

	}


	public void Save_level(int ind,int level)
	{
		if (ind == 1) {
			PlayerPrefs.SetInt ("level_arrowpwr", level);
		}

		if (ind==2)
		PlayerPrefs.SetInt ("level_coinpwr", level);
		if (ind==3)
			PlayerPrefs.SetInt ("level_quiverpwr", level);

		if (ind==4)
			PlayerPrefs.SetInt ("level_shieldpwr", level);
	}


	public int Load_level(int ind)
	{
		if (ind==1)
			 return(PlayerPrefs.GetInt ("level_arrowpwr"));

		if (ind==2)
			return(PlayerPrefs.GetInt ("level_coinpwr"));

		if (ind==3)
			return(PlayerPrefs.GetInt ("level_quiverpwr"));

		if (ind==4)
			return(PlayerPrefs.GetInt ("level_shieldpwr"));

	
		return -1;
}

	public void Save_Mute(int a)
	{
		PlayerPrefs.SetInt ("Mute_flag", a);
	}
	public int Load_Mute()
	{
		return (PlayerPrefs.GetInt ("Mute_flag"));
	}
}