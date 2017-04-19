using UnityEngine;

public class ChangeVelocity1D : MonoBehaviour {
	public delegate void ClickAction();
	public static event ClickAction OnPlayerClicked;

	private Vector3 target;
	private Rigidbody2D myRigidBody;
	private GameObject arrow;

	void Start() {
		target = transform.position;
		myRigidBody = GetComponent<Rigidbody2D>();
		arrow = GameObject.FindWithTag("Arrow");
	}

	void OnEnable() {
		SymulateButton.OnSymulateClicked += movePlayer;
	}


	void OnDisable() {
		SymulateButton.OnSymulateClicked -= movePlayer;
	}

	void movePlayer() {
		arrow.GetComponent<Arrow1D>().rend.enabled = false;
		myRigidBody.velocity = (arrow.GetComponent<Arrow1D>().targetPosition - arrow.GetComponent<Arrow1D>().playerPosition);
		Debug.Log(myRigidBody.velocity);
	}
	void OnMouseDown() {
		if (OnPlayerClicked != null)
			OnPlayerClicked();
	}
}
