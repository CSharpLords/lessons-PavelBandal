using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Presledovat : MonoBehaviour {
	public Transform[] objects;
	// Use this for initialization
	Vector3 objectPosition;

	void Start () {
		float min = 999;
		for (int i = 0; i < objects.Length; i++) {
			float dist = Vector3.Distance (transform.position, objects[i].position);
			if (min > dist) {
				min = dist;
				objectPosition = objects[i].position;
				print (objectPosition);

			}

		}
	}

	// Update is called once per frame
	void Update () {
		Vector3 direction  = objectPosition - transform.position;
		direction.Normalize();
		direction = direction * 5;
		transform.Translate(direction * Time.deltaTime);



	}
}
