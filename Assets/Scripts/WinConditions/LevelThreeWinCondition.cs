using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelThreeWinCondition : MonoBehaviour {

	private bool isEnemyInRing;

	private void Start() {
		isEnemyInRing = false;
	}

	private void Update() {
		Debug.Log(isEnemyInRing);
	}

	void OnEnable() {
		WhenInRing.OnEnterRing += enemyEnteredRing;
		WhenInRing.OnExitRing += enemyExitedRing;
	}

	void OnDisable() {
		WhenInRing.OnEnterRing -= enemyEnteredRing;
		WhenInRing.OnEnterRing -= enemyExitedRing;
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (isEnemyInRing) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
		else {
			Debug.Log("Reset");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

	void enemyEnteredRing() {
		isEnemyInRing = true;
	}

	void enemyExitedRing() {
		isEnemyInRing = false;
	}
}
