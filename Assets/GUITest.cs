using UnityEngine;
using System.Collections;

public class GUITest : MonoBehaviour {
	
	public int playerScore;
	public int savedScore;
	public int playerHealth;
	public int maxHealth;
	
	public float scorePopUpDuration = 0.5f;
	public float startTime;

	public Transform scorePopUp;
	// Use this for initialization
	void Start ()
	{
		playerScore = PlayerPrefs.GetInt("Foodz");
		savedScore = PlayerPrefs.GetInt("Foodz");
		
		maxHealth = PlayerPrefs.GetInt("MaxHealth");
		
		
		scorePopUp = transform.Find("ScorePopUp");
		
		
	}
	
	
	// Update is called once per frame
	void Update ()
	{
		playerScore = PlayerPrefs.GetInt("Foodz");
		if (playerScore > savedScore)
		{
			startTime = Time.time;
		}
		playerHealth = PlayerPrefs.GetInt("CurrentHealth");
		
		if (playerHealth <= 0)
		{
			playerHealth = 0;
			PlayerPrefs.SetInt("CurrentHealth", playerHealth);
			GameObject.FindWithTag("Player").rigidbody.constraints = RigidbodyConstraints.FreezeAll;
		}
	}
	
	void OnGUI ()
	{
		GUI.Box (new Rect(20,20,200,40), "Foodz: " + playerScore  + "\n Health: " + playerHealth.ToString() + "/" + maxHealth.ToString());
		
		
		var guiTime = Time.time - startTime;
		
		if (playerScore > savedScore)
		{
			//GUI.Label(new Rect(Screen.width/2, Screen.height/2, 50, 20), ""+playerScore);
			//GUI.Label(new Rect(50, 50, 50, 20), "+ "+playerScore);
			
			scorePopUp.transform.guiText.enabled = true;
			scorePopUp.transform.guiText.text = (playerScore-savedScore).ToString();
			savedScore = playerScore;
			
			
			//print (guiTime.ToString());
			
		}
		if (guiTime >= 0.1f)
			{
				scorePopUp.transform.guiText.enabled = false;
				//print (guiTime.ToString());
			}
		
		if (playerHealth == 0)
		{
			if (GUI.Button (new Rect(Screen.width/2-100, Screen.height/2, 200, 25), "Retry"))
			{
				Application.LoadLevel(PlayerPrefs.GetInt("LevelNum").ToString());
			}
			if (GUI.Button (new Rect(Screen.width/2-100, Screen.height/2+50, 200, 25), "Main Menu"))
			{
				Application.LoadLevel("mainmenu");
			}
		}
		
	}
}
