using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class deathcode : MonoBehaviour {


	AudioSource gun; // audio to storage clip
	public AudioClip impact;//audio clip from Mike Koenig the audio clip is here: http://soundbible.com/995-Jab.html

	// Use this for initialization
	void Start () {
		
		gun = GetComponent<AudioSource>();//audiosource from object

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Enemy") {
			other.gameObject.GetComponent<Ehealth>().Hit(10);// health damage code
			Destroy (gameObject, 0.5f);// destroy bullet after .5sec
			gun.PlayOneShot(impact, 0.025f);// start after .7sec
		}
	}

}
