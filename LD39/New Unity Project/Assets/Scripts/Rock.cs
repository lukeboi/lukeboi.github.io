using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour {
    public bool RandomRotation = true;
    public bool RandomScale = true;
    public float RandomScaleMin = 0.5f;
    public float RandomScaleMax = 3f;
    // Use this for initialization
    void Start () {
		if(RandomRotation) {
            transform.rotation = Random.rotation;
        }

        if(RandomScale) {
            float s = Random.Range(RandomScaleMin, RandomScaleMax);
            transform.localScale = Vector3.one * s;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
