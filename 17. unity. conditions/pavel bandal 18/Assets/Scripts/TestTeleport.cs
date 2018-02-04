using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTeleport : MonoBehaviour {
	float time = 0; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		time = time + Time.deltaTime;
		if (time >= 15)
		{
			time = 0;
			transform.position = new Vector3(0,0,-25);
		}
	}
}
