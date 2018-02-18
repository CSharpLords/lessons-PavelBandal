using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SexManiac : MonoBehaviour {
	 
	public Transform target; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector3 direction  = target.position - transform.position;

		direction.Normalize();

		direction = direction * 5;

		transform.Translate(direction * Time.deltaTime);

	}
}
