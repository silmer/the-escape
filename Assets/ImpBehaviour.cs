using UnityEngine;
using System.Collections;

public class ImpBehaviour : MonoBehaviour {
	
	public GameObject egg;
	public float maxDT;
	public Vector3 eggPos;
	
	public float attackThreshold;
	public float attackRepeatTime;
	public float attackTime;
	
	// Use this for initialization
	void Start ()
	{
		attackThreshold = 1f;
		attackRepeatTime = 1f;
		attackTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		
		maxDT = 0.04f;
		GameObject egg = GameObject.FindWithTag("Player");
		float distanceToPlayer = Vector3.Distance(egg.transform.position, transform.position);
		
		//transform.position = Vector3.MoveTowards(transform.position, egg.transform.position, maxDT);
		if (distanceToPlayer <= 5f)
		{
			transform.position = Vector3.MoveTowards(transform.position, new Vector3 (egg.transform.position.x, transform.position.y, transform.position.z), maxDT);
		}
		
		if (distanceToPlayer < attackThreshold && Time.time > attackTime)
		{
			PlayerPrefs.SetInt("CurrentHealth", ((PlayerPrefs.GetInt("CurrentHealth")) -20));
			print ("ATTAAAAACK " + PlayerPrefs.GetInt("CurrentHealth").ToString());
			
			attackTime = Time.time + attackRepeatTime;
		}
		
	}
	
	void OnTriggerEnter (Collider other)
	{
		if (other.name == "Egg")
		{
			//Application.LoadLevel("mainmenu");
			
		}
		
		if (other.name == "Terrain")
		{ 
			
		}

	}

}
