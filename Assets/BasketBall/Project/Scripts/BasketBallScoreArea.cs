﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketBallScoreArea : MonoBehaviour {

	public GameObject effectObject;

	void Start () {
		effectObject.SetActive (false);
	}

	void OnTriggerEnter (Collider otherCollider) {
		if (otherCollider.GetComponent<BasketBall> () != null) {
			effectObject.SetActive (true);
		}
	}
}
