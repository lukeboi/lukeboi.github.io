using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planet_Counter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    GameObject[] planets;
    public Text me;
    public GameObject Win;

    GameObject w;
	// Update is called once per frame
	void Update () {
        planets = GameObject.FindGameObjectsWithTag("Planet");
        int leg = planets.Length - 1;
        if (leg == 1) {
            me.text = "1 Planet Remains";
        } else {
            me.text = leg + " Planets Remain";
        }
        if (leg == 0 && !w) {
            w = Instantiate(Win, transform.parent);
        }
    }
}
