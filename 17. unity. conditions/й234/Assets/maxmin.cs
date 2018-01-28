using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maxmin : MonoBehaviour {
	double y = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (y < transform.position.y){ 
			y = transform.position.y;
			print (y);
		}


		
	}
}
