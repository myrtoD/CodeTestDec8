using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour {


	public Transform sphere;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		if (transform.position.x >= 0) {
			Transform.RotateAround (sphere.position, Vector3.forward, 100 * Time.deltaTime);
		} else {
			Transform.RotateAround (sphere.position, -Vector3.forward, 100 * Time.deltaTime);
		}
	}
}
