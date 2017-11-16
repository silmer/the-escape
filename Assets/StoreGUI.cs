using UnityEngine;
using System.Collections;

public class StoreGUI : MonoBehaviour {
	

	public int scrnW;
	public int scrnH;
	
	public bool storeFront;
	public string storeSection;
	public string startText;
	public Transform titleText;
	
	public int lNum;
	
	void Start()
	{
		scrnW = Screen.width;
		scrnH = Screen.height;
		lNum = PlayerPrefs.GetInt("LevelNum");
		startText = "Start";
		storeSection = "StoreFront";
		titleText = transform.Find("titleText");
		
	}
	
	void OnGUI() 
	{
		if(storeSection == "StoreFront")
		{
			if (GUI.Button(new Rect((scrnW/2)-350, (scrnH/2)-25, 200, 50), "Upgrades"))
			{
				storeSection = "Upgrades";
				titleText.transform.guiText.text = (storeSection);
			}
			
			if (GUI.Button(new Rect((scrnW/2)-100, (scrnH/2)-25, 200, 50), "Flair"))
			{
				storeSection = "Flair";
				titleText.transform.guiText.text = (storeSection);
				
			}
			if (GUI.Button(new Rect((scrnW/2)+150, (scrnH/2)-25, 200, 50), "Extra Content"))
			{
				storeSection = "Extra Content";
				titleText.transform.guiText.text = (storeSection);
			}
			if (GUI.Button(new Rect((scrnW/2)-100, (scrnH/2)+50, 200, 50), "Main Menu"))
			{
				Application.LoadLevel("mainmenu");
			}
		}
		
		else if(storeSection == "Upgrades")
		{
			if (GUI.Button(new Rect((scrnW/2)-225, (scrnH/2)-25, 200, 50), "Speed"))
			{
			}
			
			if (GUI.Button(new Rect((scrnW/2)+25, (scrnH/2)-25, 200, 50), "Jump"))
			{
			}
			
			if (GUI.Button(new Rect((scrnW/2)-225, (scrnH/2)+50, 200, 50), "Attack"))
			{
			}
			
			if (GUI.Button(new Rect((scrnW/2)+25, (scrnH/2)+50, 200, 50), "Flight"))
			{
			}
			
			if (GUI.Button(new Rect((scrnW/2)-100, (scrnH/2)+125, 200, 50), "Back"))
			{
				storeSection = "StoreFront";
			}
			
			
		}
		else if(storeSection == "Flair")
		{
			if (GUI.Button(new Rect((scrnW/2)-100, (scrnH/2)+125, 200, 50), "Back"))
			{
				storeSection = "StoreFront";
			}
		}
		else if(storeSection == "Extra Content")
		{
			if (GUI.Button(new Rect((scrnW/2)-100, (scrnH/2)+125, 200, 50), "Back"))
			{
				storeSection = "StoreFront";
			}
		}
	}
}
