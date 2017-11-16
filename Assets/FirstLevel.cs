using UnityEngine;
using System.Collections;

public class FirstLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	if (!PlayerPrefs.HasKey("LevelNum"))
		{
			PlayerPrefs.SetInt("LevelNum", 1);
		}
		
		PlayerPrefs.SetInt("CurrentHealth", (PlayerPrefs.GetInt("MaxHealth")));
	}
	
	
	
	// Update is called once per frame
	void Update () {
	
	}
}
