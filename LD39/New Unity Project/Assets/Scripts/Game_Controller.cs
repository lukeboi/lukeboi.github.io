using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class Game_Controller : MonoBehaviour {
    public Light Flashlight;
    public CharacterController Player;
    public Text PowerHUD;
    public Notification notifier;
    public FirstPersonController fps;
    public HUD_Help storyHUD;
    public GameObject bomb;
    public int powerIncrease;
    public GameObject gunMesh;
    public KillScreen killscreen;
    
    bool moveup = false;

    bool dead = false;

    bool canshoot = false;

    int power = 100;

    // Use this for initialization
    void Start () {
        gunMesh.transform.localScale = Vector3.zero;
        displayPower();
        InvokeRepeating("decreasePower", 0, 1.0f);
        InvokeRepeating("powerTick", 0, 0.025f);
        Physics.gravity = new Vector3(0f, -3.7f, 0f);
        fps.m_JumpSpeed = 0f;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.T)) {
            if (Flashlight.intensity == 0) {
                Flashlight.intensity = 3;
            }
            else {
                Flashlight.intensity = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.V) && canshoot)
            createBomb();

        if (moveup)
            transform.Translate(Vector3.up * Time.deltaTime * 15, Space.World);
    }
    void FixedUpdate() {
    }

    public void powerTick ()
    {
        if (powerIncrease > 0)
        {
            powerIncrease--;
            power++;
            displayPower();
        }
    }

    public void battery() {
        notifier.Notify("Battery (+25 Power)");
        powerIncrease += 25;
    }

    public void decreasePower() {
        power--;
        displayPower();
    }

    void displayPower() {
        if (dead)
            return;
        if (power > 10)
            PowerHUD.color = Color.white;
        else
            PowerHUD.color = Color.red;
        if (power <= 0)
            kill();
        PowerHUD.text = "Power: " + power;
    }

    public void ductTape()
    {
        fps.m_JumpSpeed = 5f;
        notifier.Notify("Duct Tape");
        StartCoroutine(ductTapeMessage());
    }
    IEnumerator ductTapeMessage()
    {
        yield return new WaitForSeconds(4);
        storyHUD.Notify("You use the duct tape to fix your boots. You can jump now (press Space)");
        yield return new WaitForSeconds(4);
        storyHUD.Notify("Press LShift to sprint");
    }
    public void createBomb()
    {
        notifier.Notify("Press B to detonate");
        Instantiate(bomb, transform.position + transform.forward * 3, Quaternion.identity);
    }

    public void gun()
    {
        canshoot = true;
        gunMesh.transform.localScale = Vector3.one;
        notifier.Notify("Detonator Tool");
        StartCoroutine(gunMessage());
    }
    IEnumerator gunMessage()
    {
        yield return new WaitForSeconds(4);
        storyHUD.Notify("Press V to place a detonator");
    }
    public void kill()
    {
        PowerHUD.text = "";
        notifier.Notify("");
        storyHUD.Notify("");
        dead = true;
        fps.enabled = false;
        killscreen.kill();
        fps.m_WalkSpeed = 0f;
        StartCoroutine(LoadScene());
    }
    public void win()
    {
        moveup = true;
        dead = true;
        fps.enabled = false;
        PowerHUD.text = "";
        notifier.Notify("");
        storyHUD.Notify("Well Done!");
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {

        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(0, LoadSceneMode.Single);

    }
}
