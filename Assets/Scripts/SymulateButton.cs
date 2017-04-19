using UnityEngine;

public class SymulateButton : MonoBehaviour {

	public delegate void ClickAction();
	public static event ClickAction OnSymulateClicked;


	void OnMouseDown() {
		if (OnSymulateClicked != null) {
			OnSymulateClicked();

		}
	}
}
