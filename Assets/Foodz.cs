using UnityEngine;
using System.Collections;

public class Foodz : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter (Collider other)
	{
		if (other.name == "Egg")
		{
			Destroy(gameObject);
			int i = PlayerPrefs.GetInt("Foodz");
			PlayerPrefs.SetInt("Foodz", i+20);
			print (PlayerPrefs.GetInt("Foodz"));
			
			
		}
	}
}
