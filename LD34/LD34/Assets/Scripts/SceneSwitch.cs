using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void click(int id) {
        if (id >= 0) { SceneManager.LoadScene(id); }
        else { SceneManager.LoadScene(Application.loadedLevel); }
    }
}
