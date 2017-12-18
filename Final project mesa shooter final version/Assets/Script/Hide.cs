using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour {
	


	Transform target;//public holder 

	public GameObject enemy;
	Rigidbody seeker;
	public float booster;
	public float range;
	// Use this for initialization
	void Start () {
		seeker = GetComponent<Rigidbody> ();
		target = GameObject.Find("player").transform;


	}
	
	// Update is called once per frame
	void Update () {
		// BeepBoopIndie help me find out distance code like how to use distance in a code here the website: https://www.youtube.com/watch?v=OMPV-duv25Q
		range = Vector3.Distance (GameObject.Find("player").transform.transform.position, enemy.transform.position);

		if(range < 7){
			Vector3 targetDir = Vector3.Normalize (target.position - transform.position);
		seeker.AddForce (targetDir * booster);
	}
	
	}
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "destroy")
		{
			
			Destroy(other.gameObject);
		}
		if (other.gameObject.tag == "kill")
		{

			Application.LoadLevel ("Main menu");
		}
	}

}