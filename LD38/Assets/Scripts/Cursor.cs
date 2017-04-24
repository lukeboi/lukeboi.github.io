using UnityEngine;
using System.Collections;

public class Cursor : MonoBehaviour {

	public Camera c;
	Vector3 pos;

	// Use this for initialization
	void Start () {
	
	}

    public GameObject planet;


	// Update is called once per frame
	void Update () {
		pos = Input.mousePosition;
		pos.z = 0;
		pos = c.ScreenToWorldPoint (pos);
		pos.z = 0;
		transform.position = pos;
        if(Input.GetMouseButtonDown(0)) {
            GameObject c = Instantiate(planet);
            c.transform.position = transform.position;
        }
	}
}
