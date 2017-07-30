using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpInfo : MonoBehaviour {
    public HUD_Help not;
    public string message = "Press T to turn your flashlight on";
    // Use this for initialization
    void Start()
    {
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
            not.Notify(message);
            Destroy(this.gameObject);
        }
    }
}
