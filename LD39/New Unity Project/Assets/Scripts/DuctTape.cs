using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuctTape : MonoBehaviour {

    public Game_Controller gameScript;
    // Use this for initialization
    void Start()
    {
        gameScript = GameObject.Find("FirstPersonCharacter").GetComponent<Game_Controller>();
        print("foo");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        print(other.transform.name);
        if (other.transform.name == "FPSController")
        {
            gameScript.ductTape();
            Destroy(this.gameObject);
        }
    }
}
