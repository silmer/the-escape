using UnityEngine;
using System.Collections;

public class GUIManager : MonoBehaviour {
	

	public int scrnW;
	public int scrnH;
	
	public bool startMenu = true;
	
	public string startText = "Start";
	public int lNum;
	
	void Start()
	{
		scrnW = Screen.width;
		scrnH = Screen.height;
		lNum = PlayerPrefs.GetInt("LevelNum");
		
		if (!PlayerPrefs.HasKey("MaxHealth"))
		{
			PlayerPrefs.SetInt("MaxHealth", 200);
			PlayerPrefs.Save();
		}
		
		if (!PlayerPrefs.HasKey ("Foodz"))
		{
			PlayerPrefs.SetInt("Foodz", 0);
			PlayerPrefs.Save();
		}
	}
	
	void Update()
	{
		print (PlayerPrefs.GetInt("MaxHealth"));
		print (PlayerPrefs.GetInt("Foodz"));
	}
	
	void OnGUI() 
	{
		if(startMenu)
		{
			if (PlayerPrefs.HasKey("LevelNum"))
			{
				startText = "Continue";
			}
			
			if (GUI.Button(new Rect((scrnW/2)-350, (scrnH/2)-25, 200, 50), startText))
			{
				if (startText == "Continue")
				{
					Application.LoadLevel(lNum.ToString());
				}
				else
				{
					Application.LoadLevel("1");
				}
			}
			
			if (GUI.Button(new Rect((scrnW/2)-100, (scrnH/2)-25, 200, 50), "Chapters"))
			{
				Application.LoadLevel("chaptermenu");
			}
			if (GUI.Button(new Rect((scrnW/2)+150, (scrnH/2)-25, 200, 50), "Store"))
			{
				Application.LoadLevel("storemenu");
			}
			
			if (GUI.Button(new Rect((scrnW/2)-100, (scrnH/2)+50, 200, 50), "Delete save data"))
			{
				PlayerPrefs.DeleteAll();
				Application.LoadLevel("mainmenu");
			}
		}
	}
}
