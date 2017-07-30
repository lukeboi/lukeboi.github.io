using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(death());
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        //transform.localScale = new Vector3(transform.localScale.x + 3.5f, transform.localScale.y + 3.5f, transform.localScale.z + 3.5f);
	}

    IEnumerator death()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "FPSController")
            return; 
        Rigidbody v = other.GetComponent<Rigidbody>();
        bool m = false;
        if (v.isKinematic)
        {
            m = true;
            v.transform.position.Set(v.transform.position.x, v.transform.position.y + 3, v.transform.position.z);
        }
        v.isKinematic = false;
        if(m)
            v.AddForce((Vector3.Normalize(other.transform.position - this.transform.position) * 2500).x, 500, (Vector3.Normalize(other.transform.position - this.transform.position) * 2500).z);
        else
            v.AddForce(Vector3.Normalize(other.transform.position - this.transform.position) * 2500);
    }
}