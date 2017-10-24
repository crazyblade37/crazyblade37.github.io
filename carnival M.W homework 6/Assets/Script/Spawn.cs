using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject prefab; //selected prefab from our project view 
	public Transform spawnPoint; //use the position of this transform as a spawn point


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) { //if the left mouse button is being pressed during this frame...
			Instantiate (prefab, spawnPoint.position, Quaternion.identity); //instantiate(spawn) our prefab at spawnPoint.position with a rotation of Quaternion.identity("no rotation")
		}


	}

}