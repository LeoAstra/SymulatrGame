using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerateLeft : MonoBehaviour {

	private Rigidbody2D myRigidBody;
	private Vector2 myAcceleration;

	void Start() {
		myRigidBody = GetComponent<Rigidbody2D>();
		myAcceleration = new Vector2(0.0f, 0.0f);
	}

	private void Update() {
		Debug.Log(myRigidBody.velocity);
		myRigidBody.velocity = myRigidBody.velocity + (myAcceleration * Time.deltaTime);
	}

	void OnEnable() {
		SymulateButton.OnSymulateClicked += accelerateEnemy;
	}


	void OnDisable() {
		SymulateButton.OnSymulateClicked -= accelerateEnemy;
	}

	void accelerateEnemy() {
		myAcceleration = new Vector2(-3.0f, 0.0f);
	}
}
