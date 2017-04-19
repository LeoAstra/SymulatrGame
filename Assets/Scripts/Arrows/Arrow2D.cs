using UnityEngine;
using System.Collections;

public class Arrow2D : MonoBehaviour {

	public Renderer rend;
	public GameObject player;
	public Vector2 playerPosition;
	public Vector2 targetPosition;
	public Vector3 mouseWorldPosition3D;
	public Vector2 mousePosition2D;
	private bool arrowSet;
	private bool isPlayerClicked;

	void Start() {
		rend = GetComponent<Renderer>();
		rend.enabled = false;
		player = GameObject.FindWithTag("Player");
		playerPosition = player.transform.position;
		arrowSet = false;
		isPlayerClicked = false;
		targetPosition = player.transform.position;

	}

	void OnEnable() {
		ChangeVelocity2D.OnPlayerClicked += triggerArrow;
		ChangeAcceleration2D.OnPlayerClicked += triggerArrow;
	}

	void dragArrow() {
		
		playerPosition = player.transform.position;

		if (!arrowSet && Input.GetMouseButton(0)) {
			rend.enabled = true;
			mouseWorldPosition3D = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			mousePosition2D = new Vector2(mouseWorldPosition3D.x, mouseWorldPosition3D.y);
			targetPosition = mousePosition2D;
		}
		if (Input.GetMouseButtonUp(0)) {
			arrowSet = true;
		}

		if (targetPosition != playerPosition) {
			Vector2 v2 = targetPosition - playerPosition;
			transform.position = playerPosition + (v2) / 2.0f;
			transform.localScale = new Vector2(transform.localScale.x, v2.magnitude/2.5f);
			transform.rotation = Quaternion.FromToRotation(Vector3.up, v2);
		}
	}
	void triggerArrow() {
		isPlayerClicked = true;
	}

	void Update() {
		if (isPlayerClicked) {
			dragArrow();
		}
	}
}
