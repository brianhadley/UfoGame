using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

    public GameObject Player;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = this.transform.position - Player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = offset + Player.transform.position;
	}
}
