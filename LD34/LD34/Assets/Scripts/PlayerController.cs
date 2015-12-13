using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public Rigidbody2D body;
    public float power;
    private float dir;
    private float speedMulti;
    float distToGround;
    private Animator animator;
    int timer;
    bool onGround = false;
	// Use this for initialization
	void Start () {
        animator = this.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        dir = Input.GetAxis("Horizontal");
        
        if (Mathf.Abs(body.velocity.x) < 5) {
            body.AddForce(new Vector2((dir * power) * speedMulti, 0));
        }

        if (Input.GetKeyUp(KeyCode.W) && onGround) {
            body.AddForce(new Vector2(0, 500));
            speedMulti = 0.5f;
            timer = 0;
            onGround = false;
        }
    }
    void OnCollisionEnter2D(Collision2D coll) {
        speedMulti = 1f;
        onGround = true;
    }
}
