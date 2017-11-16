using UnityEngine;
using System.Collections;

public class LevelTwo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	if (PlayerPrefs.GetInt("LevelNum") < 2)
		{
			PlayerPrefs.SetInt("LevelNum", 2);
		}
		
		PlayerPrefs.SetInt("CurrentHealth", (PlayerPrefs.GetInt("MaxHealth")));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
