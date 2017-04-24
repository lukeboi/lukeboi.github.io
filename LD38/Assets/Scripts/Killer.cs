using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour {

    public GameObject Lost;
    public GameObject burst;
    public GameObject canvas;
    void OnCollisionEnter2D(Collision2D coll) {
        
        if (coll.gameObject.tag == "Planet" && !coll.gameObject.GetComponent<Rigidbody2D>().isKinematic) {
            GameObject.Find("Main Camera").GetComponent<Mouse_Zoom>().enabled = false;
            Instantiate(Lost, GameObject.Find("Canvas").transform);

            GameObject.Find("Progress").SetActive(false);
        }
        GameObject b = Instantiate(burst, transform);
        b.transform.parent = null;
        Destroy(this.gameObject);
    }
}
