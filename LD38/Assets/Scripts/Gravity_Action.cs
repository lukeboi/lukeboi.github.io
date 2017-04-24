using UnityEngine;
using System.Collections;

public class Gravity_Action : MonoBehaviour {

	//public float maxGravDist = 4.0f;
	public float maxGravity = 1.0f;
	public Vector3 startforce;

	int i = 0;

	GameObject[] planets;

	void Start () {
        maxGravity = 5f;
		GetComponent<Rigidbody2D>().AddForce(startforce);
		planets = GameObject.FindGameObjectsWithTag("Planet");

	}

	void FixedUpdate () {
        planets = GameObject.FindGameObjectsWithTag("Planet");
        //LineRenderer lineRenderer = GetComponent<LineRenderer>();
        //lineRenderer.SetPosition (i, transform.position);
        //i++;
        foreach (GameObject planet in planets) {
			if (planet != this.gameObject) {
			 	float dist = Vector3.Distance(planet.transform.position, transform.position);
		 		Vector3 v = planet.transform.position - transform.position;
			 	GetComponent<Rigidbody2D>().AddForce(v.normalized * (maxGravity * ((transform.localScale.x * planet.transform.localScale.x) / (dist * dist))));
		 	}
		}
	 }
}
