using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notification : MonoBehaviour {
    Text me;
	// Use this for initialization
	void Start () {
        me = GetComponent<Text>();
        Notify("Hello");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Notify(string message)
    {
        me.CrossFadeAlpha(1.0f, 0.0f, false);
        me.text = message;
        StartCoroutine(Fadeout(2));
    }
    IEnumerator Fadeout(float time)
    {
        string n = me.text;
        yield return new WaitForSeconds(time);
        if(n == me.text)
        {
            me.CrossFadeAlpha(0.0f, 0.25f, false);

        }
        // Code to execute after the delay
    }
}
