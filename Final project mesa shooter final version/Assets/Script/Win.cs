using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Win : MonoBehaviour {
	public float duration = 3f;
	float begin = 0f;
	public Text Won;
	AudioSource victory; // audio to storage clip
	public AudioClip winsong;//audio clip from Kévin K and his link is https://www.youtube.com/watch?v=OyTDjr5gpE0

	// Use this for initialization
	void Start () {
		victory = GetComponent<AudioSource>();//audiosource from object
	}
	
	// Update is called once per frame
	void Update () {
		if (begin != 0 && Time.time > duration + begin) {
			Application.LoadLevel ("Main menu");
		}
	}
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "kill") {
			

			begin = Time.time;
			Won.text = "You Won";
			victory.PlayOneShot(winsong);// start after win

		}
}
}
