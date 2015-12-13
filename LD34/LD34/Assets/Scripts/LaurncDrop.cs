using UnityEngine;
using System.Collections;

public class LaurncDrop : MonoBehaviour {
    public GameObject Drop;
    AudioSource audio;
    
	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButtonDown(0))
        {
            audio.Play();
            Instantiate(Drop,transform.position,Quaternion.identity);
        }
	}
}
