using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillScreen : MonoBehaviour {

    private Image me;

	// Use this for initialization
	void Start () {
        me = GetComponent<Image>();
        me.color = Color.black;
        me.CrossFadeAlpha(0.0f, 2.0f, false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void kill()
    {
        StartCoroutine(killcycle());
    }

    IEnumerator killcycle()
    {
        me.color = Color.red;
        me.CrossFadeAlpha(1.0f, 0.01f, false);
        yield return new WaitForSeconds(0.1f);
        me.CrossFadeAlpha(0.0f, 0.01f, false);
        yield return new WaitForSeconds(1);
        me.color = Color.black;
        me.CrossFadeAlpha(1.0f, 3.0f, false);
        print("hi");
    }
}
