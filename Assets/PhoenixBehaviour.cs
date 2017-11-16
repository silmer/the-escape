using UnityEngine;
using System.Collections;

public class PhoenixBehaviour : MonoBehaviour {
	
	public GameObject egg;
	public float maxDT;
	public Vector3 eggPos;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		maxDT = 0.1f;
		GameObject egg = GameObject.FindWithTag("Player");
		
		float distanceToPlayer = Vector3.Distance(egg.transform.position, transform.position);
		
		if (distanceToPlayer >= 8f)
		{
			maxDT = 0.5f;
		}
		
		if (egg)
		{
		transform.position = Vector3.MoveTowards(transform.position, egg.transform.position, maxDT);
		}
	}
	
	void OnTriggerEnter (Collider other)
	{
		if (other.name == "Egg")
		{
			Application.LoadLevel("mainmenu");
		}
		
		if (other.name == "Terrain")
		{ 
			rigidbody.AddForce(0, 150, 0);
		}

	}

}
