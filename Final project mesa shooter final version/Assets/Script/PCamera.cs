using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script is from Johnny YT his link is here : https://www.youtube.com/watch?v=VzRai2sZjkk

public class PCamera : MonoBehaviour {
	public GameObject cam;

	float rotX;
	float rotY;

	float speed = 3f;

	Vector3 localvelocity;
	Rigidbody rb;

	void Start (){
		rb = gameObject.GetComponent<Rigidbody> ();//assings the rigidbody
		localvelocity = transform.InverseTransformDirection (rb.velocity);//This lets the rigidbody move in the players rotation
		Cursor.visible = false;
	}


	void Update () {
		rotX += Input.GetAxis ("Mouse X");//sets the rotation to the x axis
		rotY -= Input.GetAxis ("Mouse Y");//sets the rotation to the y axis

		transform.eulerAngles = new Vector3 (0, rotX, 0);//applies the x rotation
		cam.transform.eulerAngles = new Vector3 (rotY, rotX, 0);//applies the y rotation

		rb.velocity = transform.TransformDirection (localvelocity);

		if (Input.GetAxis ("Horizontal") > 0)
			localvelocity.x = speed;
		if (Input.GetAxis ("Horizontal") < 0)
			localvelocity.x = -speed;
		if (Input.GetAxis ("Horizontal") == 0)
			localvelocity.x = 0;

		if (Input.GetAxis ("Vertical") > 0)
			localvelocity.z = speed;
		if (Input.GetAxis ("Vertical") < 0)
			localvelocity.z = -speed;
		if (Input.GetAxis ("Vertical") == 0)
			localvelocity.z = 0;
	}


}
