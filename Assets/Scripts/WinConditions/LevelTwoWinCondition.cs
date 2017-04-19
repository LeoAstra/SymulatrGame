using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelTwoWinCondition : MonoBehaviour {

	public CountdownTimer countDownTimer;
	public float remainingTime;

	private void Start() {
		countDownTimer = GetComponent<CountdownTimer>();
		remainingTime = countDownTimer.targetTime;
	}

	private void Update() {
		remainingTime = countDownTimer.remainingTime;
		//Debug.Log(remainingTime);
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (isWinningConditionsPassed()) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
		else {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

	bool isWinningConditionsPassed() {
		return remainingTime <= 1.0f && remainingTime>= -1.0f;
	}
}
