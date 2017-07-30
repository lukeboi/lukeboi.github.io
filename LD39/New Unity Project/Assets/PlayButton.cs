using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

    private Image me;

    // Use this for initialization
    void Start()
    {
        me = GetComponent<Image>();

    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            me.color = Color.black;
            me.CrossFadeAlpha(1.0f, 2.0f, false);
            StartCoroutine(LoadScene());
        }
            
	}

    IEnumerator LoadScene()
    {

        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1, LoadSceneMode.Single);

    }
}
