﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketBallPlayer : MonoBehaviour {

	public BasketBall ball;
	public GameObject playerCamera;

	public float ballDistance = 2f;
	public float ballThrowingForce = 5f;

	public bool holdingBall = true;

	// Use this for initialization
	void Start () {
		ball.GetComponent<Rigidbody> ().useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (holdingBall) {
			ball.transform.position = playerCamera.transform.position + playerCamera.transform.forward * ballDistance;

			if (Input.GetMouseButtonDown(0)) {
				holdingBall = false;
				ball.ActivateTrail ();
				ball.GetComponent<Rigidbody> ().useGravity = true;
				ball.GetComponent<Rigidbody> ().AddForce (playerCamera.transform.forward * ballThrowingForce);
			}
		}
	}
}
