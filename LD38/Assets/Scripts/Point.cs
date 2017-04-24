using UnityEngine;
using System.Collections;

public class Point : MonoBehaviour {

	public Rigidbody2D r;
	public GameObject c;
    GameObject[] cursors;
	// Use this for initialization
	void Start () {
        Time.timeScale = 0;
		cursors = GameObject.FindGameObjectsWithTag("Cursor");
        c = cursors[0];
    }
	
	// Update is called once per frame
	void Update () {
        c = cursors[0];
        float speed = Vector3.Distance (c.transform.position, transform.position) * 50;
		Vector2 dir = (c.transform.position - transform.position).normalized * speed;

		if (Input.GetMouseButtonUp (0)) {
            Time.timeScale = 1;
            r.AddForce (dir);
			gameObject.AddComponent<Gravity_Action>();
			Destroy (this);
		}

		/*Vector3 newPos = dir / 50;//(i * (dir.x)) + transform.position.x, (i * (dir.y)) + transform.position.y, 0);
		newPos.x += transform.position.x;
		newPos.y += transform.position.y;
		LineRenderer lineRenderer = GetComponent<LineRenderer>();

		lineRenderer.SetColors (new Color (255 - speed, 0, 0), new Color (255 - speed, 0, 0));
		lineRenderer.SetPosition (0, transform.position);
		lineRenderer.SetPosition (1, newPos);*/


		transform.localScale = new Vector3(
			Clamp(transform.localScale.x + Input.mouseScrollDelta.y / 4, 0.25f, 10), 
			Clamp(transform.localScale.x + Input.mouseScrollDelta.y / 4, 0.25f, 10),
			Clamp(transform.localScale.x + Input.mouseScrollDelta.y / 4, 0.25f, 10));
	}
	public static float Clamp (float value, float min, float max) {
		if (value <= min) { return min; }
		if (value >= max) { return max; }
		return value;
	}
}
