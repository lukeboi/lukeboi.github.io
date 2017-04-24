using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour {

    public Button L1;
    public string L1Press;

    public Button L2;
    public string L2Press;

    public Button L3;
    public string L3Press;

    public Button L4;
    public string L4Press;
    // Use this for initialization
    void Start () {
        L1.onClick.AddListener(delegate { ButtonPress(L1Press); });
        L2.onClick.AddListener(delegate { ButtonPress(L2Press); });
        L3.onClick.AddListener(delegate { ButtonPress(L3Press); });
        L4.onClick.AddListener(delegate { ButtonPress(L4Press); });
    }

    void ButtonPress(string n) {
        SceneManager.LoadScene(n);
    }
}
