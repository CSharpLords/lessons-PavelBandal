using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {
	public Transform item;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance(item.position, transform.position);
		if (dist < 3)
		{
			print ("You Win!");
		}
	}
}
