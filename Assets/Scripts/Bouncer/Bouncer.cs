using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour {

	public float force = 500f;

	private Animator anim;

	void Awake () {
		anim = GetComponent<Animator> ();
	}

	IEnumerator AnimateBouncer () {
		anim.Play ("Up");
		yield return new WaitForSeconds (0.5f);
		anim.Play ("Down");
	}
	
	void OnTriggerEnter2D (Collider2D target) {
		if (target.tag == "Player") {
			target.gameObject.GetComponent<PlayerScript> ().BouncePlayer (force);
			StartCoroutine (AnimateBouncer ());
		}
	}

} // Bouncer