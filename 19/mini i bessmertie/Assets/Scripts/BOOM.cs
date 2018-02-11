using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOOM : MonoBehaviour {
	public Transform UndyingPlayer;
	// Use this for initialization
	void Start () {
		
	}	
	
	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance(transform.position, UndyingPlayer.position);
			if (dist <= 2){
			UndyingPlayer.position = new Vector3(0,0,0);
		}
	}
}
	
