using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic3DPlus : MonoBehaviour {

	public GameObject mover;
	public int movementAmt = 1;
	public Vector3 startingPosition;
	public GameObject winSpot;

	// Use this for initialization
	void Start () {
		

		startingPosition = mover.transform.position;
	}

	// Update is called once per frame
	void Update () {
		

		if (mover.transform.position.z < -4 || //is it behind the grid?
		    mover.transform.position.z > 4 || //is it too far off the grid?
		    mover.transform.position.x < -4 || //is it too far left of the grid?
		    mover.transform.position.x > 4) { //is it too far right of the grid?
			mover.transform.position = startingPosition; //if any of those are true... reset it's position to the starting position
		}




		if (Input.GetKeyDown (KeyCode.S)) {
			
			mover.transform.position += new Vector3 (-movementAmt, 0, 0);
		} 
		if (Input.GetKeyDown (KeyCode.W)) {
			
			mover.transform.position += new Vector3 (movementAmt, 0, 0);
		} 
		if (Input.GetKeyDown (KeyCode.A)) {
			
			mover.transform.position += new Vector3 (0, 0, movementAmt);
		} 
			
		if (Input.GetKeyDown (KeyCode.D)) {
			
			mover.transform.position += new Vector3 (0, 0, -movementAmt);
		} 

	
	}
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("win")) {
			gameObject.GetComponent<Renderer> ().material.color = Color.blue;
			// Tasarran help me understand and use the material change color code for the player code when they win and the link is below 
			//http://answers.unity3d.com/questions/209573/how-to-change-material-color-of-an-object.html
			Debug.Log ("win?"); //give us a console message
		}
		if (other.gameObject.CompareTag ("Death")) {

			mover.transform.position = startingPosition;
		}
		if (other.gameObject.CompareTag ("Skip")) {

			movementAmt = 2;
		}
		if (other.gameObject.CompareTag ("Mud")) {

			movementAmt = 1;
		}
	}



}
