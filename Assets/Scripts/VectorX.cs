using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VectorX : MonoBehaviour {

	public GameObject arrow;
	public Text vectorXComponent;
	public Vector2 arrowVector;

	// Use this for initialization
	void Start () {
		vectorXComponent.text = "0";
		arrow = GameObject.FindWithTag("Arrow");
	}
	
	// Update is called once per frame
	void Update () {
		arrowVector = (arrow.GetComponent<Arrow1D>().targetPosition - arrow.GetComponent<Arrow1D>().playerPosition);
		vectorXComponent.text = "" + arrowVector.x;
	}
}
