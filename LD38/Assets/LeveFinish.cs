using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeveFinish : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public string menuname;
	// Update is called once per frame
	void FixedUpdate () {
        if(Input.GetKeyDown("r")) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().ToString());
        }
		else if(Input.anyKeyDown) {
            SceneManager.LoadScene(menuname);
        }
	}
}
