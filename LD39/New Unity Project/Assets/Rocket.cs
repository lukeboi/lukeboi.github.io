using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    public Game_Controller gc;
    bool moveup = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(moveup)
            transform.Translate(Vector3.up * Time.deltaTime * 15, Space.World);
    }

    void OnTriggerEnter()
    {
        Rigidbody m = GetComponent<Rigidbody>();
        m.useGravity = false;
        m.isKinematic = true;
        gc.win();
        moveup = true;
    }
}
