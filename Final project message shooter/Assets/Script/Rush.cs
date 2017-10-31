using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rush : MonoBehaviour {
	


	Transform target; //public holder 
	Rigidbody seeker;
	public float booster;
	// Use this for initialization
	void Start () {
		seeker = GetComponent<Rigidbody> ();
		target = GameObject.Find("player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 targetDir = Vector3.Normalize (target.position - transform.position);
		seeker.AddForce (targetDir * booster);
	}
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "kill")
		{
			Destroy(other.gameObject);
		}
	}

}