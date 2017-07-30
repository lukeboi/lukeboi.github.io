using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionForceKiller : MonoBehaviour {

    public Game_Controller f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Rigidbody>().velocity.magnitude > 2 && other.name != "Bomb(Clone)")
            f.kill();
    }
}
