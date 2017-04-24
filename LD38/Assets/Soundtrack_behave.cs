using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundtrack_behave : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject[] m = GameObject.FindGameObjectsWithTag("Music");
        if (m.Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.transform);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
