using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class advme : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		while (true){
		Renderer render = GetComponent<Renderer> ();
		float time = Time.deltaTime;
		render.material.color = Color.red;
		render.material.color = Color.yellow;
		render.material.color = Color.green;

		}
	}
}
