using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunner : MonoBehaviour {

	public GameObject prefab;

	void Start () {
		
	}
	

	void Update () {
		Ray beam = Camera.main.ScreenPointToRay (Input.mousePosition);

		Debug.DrawRay (beam.origin, beam.direction * 1000f);

		RaycastHit BeamHit = new RaycastHit ();

		if (Physics.Raycast (beam, out BeamHit, 1000f)) {

		
			if (Input.GetMouseButtonDown (0)) {
				GameObject ballInstance = Instantiate (prefab, beam.origin, Quaternion.identity);
				ballInstance.GetComponent<Rigidbody> ().AddForce (beam.direction * 1000f);
			
			
			}

		
		}
	}

}

