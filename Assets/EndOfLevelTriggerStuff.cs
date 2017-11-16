using UnityEngine;
using System.Collections;

public class EndOfLevelTriggerStuff : MonoBehaviour {
	
	public string nextLevel;
	public bool levelFinished;
	// Use this for initialization
	void Start () {
	levelFinished = false;
	Time.timeScale = 1;

	}
	
	// Update is called once per frame
	void Update () {
	print (Application.loadedLevelName);
	}
	
		void OnTriggerEnter (Collider other)
	{
		if (other.name == "Egg" || other.name == "EggLeg" || other.name == "EggLegBite")
		{
			levelFinished = true;
			Time.timeScale = 0;
			
			if (Application.loadedLevelName == "1" && PlayerPrefs.GetInt("LevelNum") == 1)
			{
				PlayerPrefs.SetInt("LevelNum", 2);
				nextLevel = "2";
			}
			if (Application.loadedLevelName == "2" && PlayerPrefs.GetInt("LevelNum") == 2)
			{
				PlayerPrefs.SetInt("LevelNum", 3);
				nextLevel = "3";
			}
		}
	}
	
	void OnGUI()
	{
		if (Application.loadedLevelName == "1"  && levelFinished == true)
		{
			if (GUI.Button(new Rect(Screen.width/2-100, Screen.height/2-50, 200, 100), "Level 2"))
			{
				Application.LoadLevel("2");
			}
			if (GUI.Button(new Rect(Screen.width/2-100, Screen.height/2+100, 200, 100), "Main Menu"))
			{
				Application.LoadLevel("mainmenu");
			}
			
		}
		if (Application.loadedLevelName == "2"  && levelFinished == true)
		{
			if (GUI.Button(new Rect(Screen.width/2-100, Screen.height/2-50, 200, 100), "Level 3"))
			{
				Application.LoadLevel("3");
			}
			if (GUI.Button(new Rect(Screen.width/2-100, Screen.height/2+100, 200, 100), "Main Menu"))
			{
				Application.LoadLevel("mainmenu");
			}
		}
		if (Application.loadedLevelName == "3"  && levelFinished == true)
		{
			if (GUI.Button(new Rect(Screen.width/2-100, Screen.height/2-50, 200, 100), "Main Menu"))
			{
				Application.LoadLevel("mainmenu");
			}

		}
	}
}
