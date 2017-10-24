using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rush : MonoBehaviour {
	public AudioClip impact;
	//http://soundbible.com/1723-Horse-Blow.html - recorded by stephan schutze the audio clip
	AudioSource hono;

	public Transform target; //public holder 
	Rigidbody seeker;
	public float booster;
	// Use this for initialization
	void Start () {
		seeker = GetComponent<Rigidbody> ();
		hono = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 targetDir = Vector3.Normalize (target.position - transform.position);
		seeker.AddForce (targetDir * booster);
	}

void OnTriggerEnter(Collider other) {
		hono.PlayOneShot(impact, 0.7F);
}
}