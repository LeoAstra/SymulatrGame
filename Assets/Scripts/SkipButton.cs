using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SkipButton : MonoBehaviour {

	void OnMouseDown() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
