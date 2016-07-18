using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float Speed;
    public GameObject mainController;
    private Rigidbody2D rb2d;
    private int TrackTakeOff = 240;

        
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        
    }	
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");



        Vector3 v3 = new Vector3(moveHorizontal, moveVertical,50);
        rb2d.AddForce(v3 * Speed);
        //gameObject.transform.localScale = new Vector3(2, 2);
            
        }

    void OnTriggerEnter2D(Collider2D other)
    {
        MasterScript mainScript = mainController.GetComponent<MasterScript>();

        mainScript.CollectableEncountered(other);
    }
}
