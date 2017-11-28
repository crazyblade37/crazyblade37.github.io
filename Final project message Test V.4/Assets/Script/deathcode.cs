using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class deathcode : MonoBehaviour {




	// Use this for initialization
	void Start () {
		


	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Enemy") {
			other.gameObject.GetComponent<Ehealth>().Hit(10);
			Destroy (gameObject, 0.5f);

		}
	}

}
