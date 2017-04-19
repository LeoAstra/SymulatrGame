using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour {

	public Text timeLeft;
	public float startTime;
	public float targetTime;
	public float elapsedTime;
	public float remainingTime;
	public bool timerStarted;

	private void Start() {
		timerStarted = false;
		targetTime = 5.0f;
		timeLeft.text = "Timer: " + targetTime + "s";
	}


	void OnEnable() {
		SymulateButton.OnSymulateClicked += startTimer;
	}


	void OnDisable() {
		SymulateButton.OnSymulateClicked -= startTimer;
	}


	private void Update() {
		if (timerStarted) {
			elapsedTime = Time.time - startTime;
			remainingTime = targetTime - elapsedTime;
			timeLeft.text = "Timer: " + roundToNearestTenth(remainingTime) + "s";
		}
	}

	void startTimer() {
		timerStarted = true;
		startTime = Time.time;
	}
	float roundToNearestTenth(float n) {
		return ((float)((int)(n * 10)))/10;
	}
}
