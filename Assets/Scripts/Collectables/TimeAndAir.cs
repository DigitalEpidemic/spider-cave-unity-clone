using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeAndAir : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D target) {
		if (target.tag == "Player") {
			if (gameObject.name == "Air") {
				GameObject.Find ("Gameplay Controller").GetComponent<AirTimer> ().air += 15f;
			} else {
				GameObject.Find ("Gameplay Controller").GetComponent<LevelTimer> ().time += 15f;
			}
			Destroy (gameObject);
		}
	}

} // TimeAndAir