using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
        text.CrossFadeAlpha(0.0f, 0.0f, false);
    }

    public Text text; 

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp("h")) {
            text.CrossFadeAlpha(0.0f, 0.05f, false);
        }
        if (Input.GetKeyDown("h"))
        {
            text.CrossFadeAlpha(1.0f, 0.05f, false);
        }
    }
}
