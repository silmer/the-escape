using UnityEngine;
using System.Collections;

public class Eggsy : MonoBehaviour {

	public Vector3 push;
	public bool touchingPlatform;
	// Use this for initialization
	void Start ()
	{
		
		
		push = new Vector3(0,0,0);
		rigidbody.AddForce(2000, 1000, 0);
	}
	
	// Update is called once per frame
	void Update ()
	{
	//transform.Translate (5f * Time.deltaTime, 0f, 0f);
		
		
		if (touchingPlatform && Input.GetKey("right"))
		{
			push.x = 600;
			//print ("push " + push);
			
		}

		
		if (touchingPlatform && Input.GetButtonDown ("Jump"))
		{
			push.y = 5000;
			//print ("push " + push);
		}
	}
	
	void FixedUpdate ()
	{
		if (touchingPlatform)
		{
		rigidbody.AddForce(push);
		}
		
		push.x = 200;
			push.y = 0;
			//print ("push " + push);
		//print ("touching platform? " + touchingPlatform);
	}
	
	void OnCollisionEnter ()
	{
		touchingPlatform = true;
		
	}
	
	void OnCollisionExit ()
	{
		touchingPlatform = false;
		
	}
	

		
}
