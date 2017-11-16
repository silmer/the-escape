using UnityEngine;
using System.Collections;

public class JumpScript : MonoBehaviour {
	public GameObject Egg;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void onCollisionEnter ()
	{
		Egg.GetComponent<Eggsy>().touchingPlatform = true;
		print ("Colliding");
	}
	
	void onCollisionExit ()
	{
		Egg.GetComponent<Eggsy>().touchingPlatform = false;
	}
}
