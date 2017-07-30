using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD_Help : MonoBehaviour {
    Text me;
    // Use this for initialization
    void Start()
    {
        me = GetComponent<Text>();
        me.CrossFadeAlpha(0.0f, 0.0f, false);
        StartCoroutine(storyline());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator storyline ()
    {
        yield return new WaitForSeconds(4);
        Notify("Use WASD to move");
        yield return new WaitForSeconds(8);
        Notify("Assessing Crash Damage...");
        yield return new WaitForSeconds(6);
        Notify("Assessment Complete");
        yield return new WaitForSeconds(6);
        Notify("Your ship is completey destroyed");
        yield return new WaitForSeconds(6);
        Notify("Your suit's power reserves are leaking");
        yield return new WaitForSeconds(6);
        Notify("Your boots are damaged. You won't be able to jump until you find something to fix them");
    }
    public void Notify(string message)
    {
        me.CrossFadeAlpha(1.0f, 0.5f, false);
        me.text = message;
        StartCoroutine(Fadeout(5));
    }
    IEnumerator Fadeout(float time)
    {
        string n = me.text;
        yield return new WaitForSeconds(time);
        if (n == me.text)
        {
            me.CrossFadeAlpha(0.0f, 0.25f, false);

        }
        // Code to execute after the delay
    }
}
