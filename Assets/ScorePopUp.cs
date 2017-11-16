using UnityEngine;
using System.Collections;

public class ScorePopUp : MonoBehaviour {
	
	private float scroll = 0.05f;
	private float duration = 1.5f;
	private float alpha;
	// Use this for initialization
	void Start ()
	{
		alpha = 1f;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (alpha > 0)
		{
			//transform.position.y += scroll*Time.deltaTime;
			alpha -= Time.deltaTime/duration;
			//guiText.material.color.a = alpha;
		}
		else
		{
			Destroy(transform.gameObject);
		}
	}
}
