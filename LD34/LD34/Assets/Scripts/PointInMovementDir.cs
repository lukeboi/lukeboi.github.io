using UnityEngine;
using System.Collections;

public class PointInMovementDir : MonoBehaviour {

    public Rigidbody2D body;
    public string PlantTagName;
    public GameObject Plant;

    public Camera view;
    public float joltSpeed;

    public float time;

    AudioSource audio;

    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();
        Vector3 pos = view.ScreenToWorldPoint(Input.mousePosition);
        Vector3 dir = pos - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        body.AddForce(transform.right * joltSpeed);
    }
	
	// Update is called once per frame
	void Update () {
        float xvel = body.velocity.x;
        float yvel = body.velocity.y;

        float dir = Mathf.Atan2(yvel, xvel);
        dir = dir * Mathf.Rad2Deg;
        transform.localEulerAngles = new Vector3 (0, 0, dir + 90);

        time += Time.deltaTime;
	}

    void OnTriggerEnter2D(Collider2D collision) {

        if (collision.gameObject.tag == PlantTagName && time > 1)
        {
            Instantiate(Plant, body.position, transform.rotation);
            
            //StartCoroutine((3));
        }
        Destroy(this.gameObject);
        
    }

    IEnumerator wait(float waittime) {
        yield return new WaitForSeconds(waittime);
    }
}
