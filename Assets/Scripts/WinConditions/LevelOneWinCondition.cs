using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelOneWinCondition : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		if (isWinningConditionsPassed()) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}

	bool isWinningConditionsPassed() {
		Debug.Log("Level 1 Cleared");
		return true;
	}
}
