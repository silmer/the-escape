using UnityEngine;
using System.Collections;

public class EggsyLegsyBitey : MonoBehaviour {

	public Vector3 push;
	public bool touchingGround;
	public bool touchingWall;
	
	public float attackThreshold;
	public float attackRepeatTime;
	public float attackTime;
	
	// Use this for initialization
	void Start ()
		
	{
		attackThreshold = 1f;
		attackRepeatTime = 1f;
		attackTime = Time.time;
		
		push = new Vector3(0,0,0);
		//rigidbody.AddForce(1000, 1000, 0);
	}
	
	// Update is called once per frame
	void Update ()
	{
	//transform.Translate (5f * Time.deltaTime, 0f, 0f);
		
		if (Physics.Raycast (transform.position, new Vector3(1,0,0), 0.3f) || Physics.Raycast (transform.position, new Vector3(-1,0,0), 0.3f))
		{
			print ("walls of steel");
			touchingWall = true;
		} else { touchingWall = false;}
		
		if (Physics.Raycast (transform.position, new Vector3(0,-1,0), 1.0f))
		{
			print ("ground of steel?");
			touchingGround = true;
		} else {touchingGround = false;}
		
		
		if (Input.GetKey("right"))
		{
			push.x = 20;
			//print ("push " + push);
			
		}
		else if (Input.GetKey ("left"))
		{
			push.x = -20;
			//print ("push " + push);
		}
		
		if (touchingGround /*&& !touchingWall*/ && Input.GetButtonDown ("Jump"))
		{
			push.y = 400;
			//print ("push " + push);
		}
	
	}
	
	void FixedUpdate ()
	{

		rigidbody.AddForce(push);
		
		push.x = 0;
		push.y = 0;
	}
	
	void OnCollisionEnter (Collision collisionInfo)
	{
		
	}
	
	void OnCollisionExit ()
	{
		touchingGround = false;
	}
	

		
}