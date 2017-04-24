using UnityEngine;
using System.Collections;

public class Mouse_Zoom : MonoBehaviour {

	public float dragSpeed = 2;
	public Camera Cam;
	private Vector3 dragOrigin;

    public bool go = true;

	void Update() {
		if (Cam.orthographicSize < 1) {
			Cam.orthographicSize = 1;
		} else if (Cam.orthographicSize > 300) {
			Cam.orthographicSize = 300;
		} else if (!Input.GetMouseButton(0)) {
			Cam.orthographicSize -= Input.mouseScrollDelta.y;
		}
        if (go)
		    transform.Translate (Input.GetAxis ("Horizontal") / 3, Input.GetAxis ("Vertical") / 3, 0);
	}
}
