using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WinnerScript : MonoBehaviour {

    public int scene;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other) {
        print("collide");
        if (other.gameObject.tag == "Player") {
            SceneManager.LoadScene(scene);
        }
    }
}
