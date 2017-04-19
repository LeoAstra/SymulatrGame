using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour {

	private Vector2 velocity;
	private Rigidbody2D myRigidBody;

	void Start () {
		myRigidBody = GetComponent<Rigidbody2D>();
		velocity = new Vector2(-5.0f,0.0f);
	}

	void OnEnable() {
		SymulateButton.OnSymulateClicked += moveEnemy;
	}


	void OnDisable() {
		SymulateButton.OnSymulateClicked -= moveEnemy;
	}

	// Update is called once per frame
	void moveEnemy () {
		myRigidBody.velocity = velocity;
	}
}
