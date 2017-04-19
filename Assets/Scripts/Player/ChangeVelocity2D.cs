using UnityEngine;

public class ChangeVelocity2D : MonoBehaviour {
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
		arrow.GetComponent<Arrow2D>().rend.enabled = false;
		myRigidBody.velocity = (arrow.GetComponent<Arrow2D>().targetPosition - arrow.GetComponent<Arrow2D>().playerPosition) * 3.0f;
		Debug.Log(myRigidBody.velocity);
	}
	void OnMouseDown() {
		if (OnPlayerClicked != null)
			OnPlayerClicked();
	}
}
