using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Psy : MonoBehaviour {
	Rigidbody rb;
	public float rushamt;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
		
			rb.AddForce (Vector3.forward * rushamt);
		}
		if (Input.GetKey (KeyCode.S)) {

			rb.AddForce (Vector3.back * rushamt);
		}
		if (Input.GetKey (KeyCode.A)) {

			rb.AddForce (Vector3.left * rushamt);
		}
		if (Input.GetKey (KeyCode.D)) {

			rb.AddForce (Vector3.right * rushamt);
		}
	}
}
//http://aggrofamilytime.com/taking-my-son-to-the-moon/
//that to this website I got the moon texture