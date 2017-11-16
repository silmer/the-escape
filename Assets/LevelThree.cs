using UnityEngine;
using System.Collections;

public class LevelThree : MonoBehaviour {

	// Use this for initialization
	void Start () {
	if (PlayerPrefs.GetInt("LevelNum") < 3)
		{
			PlayerPrefs.SetInt("LevelNum", 3);
		}
		
		if (!PlayerPrefs.HasKey("DmgOutput"))
		{
			PlayerPrefs.SetInt("DmgOutput", 20);
		}
		
		PlayerPrefs.SetInt("CurrentHealth", (PlayerPrefs.GetInt("MaxHealth")));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
