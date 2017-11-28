using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunner : MonoBehaviour {

	public GameObject prefab;
	public float speed = 0.7f;
	private float delay = 0f;
	void Start () {
		
	}
	

	void Update () {
		Ray beam = Camera.main.ScreenPointToRay (Input.mousePosition);

		Debug.DrawRay (beam.origin, beam.direction * 1000f);

		RaycastHit BeamHit = new RaycastHit ();

		if (Physics.Raycast (beam, out BeamHit, 1000f)) {

			//had finding delay from this website https://answers.unity.com/questions/283377/how-to-delay-a-shot.html and his name is Maddogc
			if (Input.GetMouseButtonDown(0) && Time.time > delay) {
				delay = Time.time + speed;
				GameObject ballInstance = Instantiate (prefab, beam.origin, Quaternion.identity);
				ballInstance.GetComponent<Rigidbody> ().AddForce (beam.direction * 2000f);
			
			
			}

		
		}
	}

}

