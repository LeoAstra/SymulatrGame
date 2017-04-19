using UnityEngine;

public class ChangeAcceleration2D : MonoBehaviour {
	public delegate void ClickAction();
	public static event ClickAction OnPlayerClicked;

	private Vector3 target;
	private Rigidbody2D myRigidBody;
	private GameObject arrow;
	private Vector2 myAcceleration;

	void Start() {
		target = transform.position;
		myRigidBody = GetComponent<Rigidbody2D>();
		arrow = GameObject.FindWithTag("Arrow");
		myAcceleration = new Vector2(0.0f,0.0f);
	}

	private void Update() {
		Debug.Log(myRigidBody.velocity);
		myRigidBody.velocity = myRigidBody.velocity + (myAcceleration * Time.deltaTime);
	}

	void OnEnable() {
		SymulateButton.OnSymulateClicked += movePlayer;
	}


	void OnDisable() {
		SymulateButton.OnSymulateClicked -= movePlayer;
	}

	void movePlayer() {
		arrow.GetComponent<Arrow2D>().rend.enabled = false;
		myAcceleration = (arrow.GetComponent<Arrow2D>().targetPosition - arrow.GetComponent<Arrow2D>().playerPosition);
	}
	void OnMouseDown() {
		if (OnPlayerClicked != null) {
			OnPlayerClicked();
			Debug.Log("Clicked");
		}
	}
}
