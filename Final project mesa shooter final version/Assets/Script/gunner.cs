using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class gunner : MonoBehaviour {

	public GameObject prefab;
	public Texture2D crosshairImage;
	public float speed = 0.7f;
	private float delay = 0f;
	private float x = Screen.width / 2;
	private float y = Screen.height / 2;
	AudioSource cannon; // audio to storage clip
	public AudioClip air;//audio clip from Jojikiba the link is here https://www.youtube.com/watch?v=QuyphFwv22s
	void Start () {
		cannon = GetComponent<AudioSource>();//audiosource from object
	}
	

	void Update () {
		Ray beam = Camera.main.ScreenPointToRay (new Vector3(x, y, 0));

		Debug.DrawRay (beam.origin, beam.direction * 1000f);

		RaycastHit BeamHit = new RaycastHit ();

		if (Physics.Raycast (beam, out BeamHit, 1000f)) {

			//had finding delay from this website https://answers.unity.com/questions/283377/how-to-delay-a-shot.html and his name is Maddogc
			if (Input.GetMouseButtonDown(0) && Time.time > delay) {
				delay = Time.time + speed;
				GameObject ballInstance = Instantiate (prefab, beam.origin, Quaternion.identity);
				ballInstance.GetComponent<Rigidbody> ().AddForce (beam.direction * 3000f);
				cannon.PlayOneShot(air,2f);// start after press
			
			}

		
		}
	}

	void OnGUI()
	{
		float xMin = (Screen.width / 2) - (crosshairImage.width / 2);
		float yMin = (Screen.height / 2) - (crosshairImage.height / 2);
		// crosshair code for the image to come up from a user named : syclamoth and the website is https://answers.unity.com/questions/201103/c-crosshair.html
		GUI.DrawTexture(new Rect(xMin, yMin, crosshairImage.width, crosshairImage.height), crosshairImage);
	}
}

