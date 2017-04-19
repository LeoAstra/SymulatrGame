using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenInRing : MonoBehaviour {

	public delegate void EnterRing();
	public static event EnterRing OnEnterRing;

	public delegate void ExitRing();
	public static event ExitRing OnExitRing;

	private GameObject ring;
	private Rigidbody2D myRigidBody;
	private Vector2 myPosition;

	private void Start() {
		myRigidBody = GetComponent<Rigidbody2D>();
		ring = GameObject.FindWithTag("Ring");
		myPosition = ring.transform.position;
	}

	void Update() {

		if (isInsideRing()) {
			if (OnEnterRing != null) OnEnterRing();
		}

		if (isOutsideRing()) {
			if (OnExitRing != null) OnExitRing();
		}
	}

	bool isInsideRing() {
		//return myRigidBody.position.x >= -8.5f && myRigidBody.position.x <= -6.5f;
		return (myRigidBody.position.x >= myPosition.x -1.0f && myRigidBody.position.x <= myPosition.x - 1.0f) && myRigidBody.position.y == myPosition.y;
	}

	bool isOutsideRing() {
		return myRigidBody.position.x < -8.5f || myRigidBody.position.x > -6.5f;
	}
}
