using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Time_Controller : MonoBehaviour {

	public Slider slider;
	public Text text;
	float target = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*float i = slider.value;
		if (i == 0f) {
			target = 1;
		} else if (i == 1f) {
			target = 2;
		} else {
			target = 5;
		}*/
		text.text = Time.timeScale + "x";

        if (Input.GetKeyUp("q") && Time.timeScale > 1) {
			Time.timeScale -= 1;
		}
		if (Input.GetKeyUp("e") && Time.timeScale < 15) {
			Time.timeScale += 1;
		}
        if(Input.GetKeyUp(KeyCode.R)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}
}
