using UnityEngine;
using System.Collections;

public class ChapterGUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI ()
	{
		
			if (GUI.Button (new Rect(Screen.width/2-100, Screen.height/2-150, 200, 100), "Main Menu"))
			{
				Application.LoadLevel("mainmenu");
			}
		
		if (PlayerPrefs.GetInt("LevelNum") >= 1)
				
		{
			if (GUI.Button (new Rect(Screen.width/2-100, Screen.height/2-50, 200, 100), "Level 1"))
			{
				Application.LoadLevel("1");
			}
		}
		if (PlayerPrefs.GetInt("LevelNum") >= 2)
				
		{
			if (GUI.Button (new Rect(Screen.width/2-100, Screen.height/2+50, 200, 100), "Level 2"))
			{
				Application.LoadLevel("2");
			}
		}
		if (PlayerPrefs.GetInt("LevelNum") >= 3)
		{
			if (GUI.Button (new Rect(Screen.width/2-100, Screen.height/2+150, 200, 100), "Level 3"))
			{
				Application.LoadLevel("3");
			}
		}
	}
}
