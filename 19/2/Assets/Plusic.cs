

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plusic : MonoBehaviour {
	public Text age; 
	int t = 0;
	// Use this for initialization
	void Start () {
		Button button = GetComponent<Button>();
		button.onClick.AddListener(PlusAge);

	}

	void PlusAge () {
		t = t + 1;
		age.text = t.ToString();
	}
}
