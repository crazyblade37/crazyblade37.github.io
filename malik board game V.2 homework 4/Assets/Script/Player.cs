using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	public GameObject mover;
	public Vector3 movementAmount;
	public Vector3 movementplacement;
	// Use this for initialization
	void Start()
	{
		movementAmount = new Vector3 (1, 0, 0);
		movementplacement = new Vector3 (0, 0, 1);
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.W))
		{

			mover.transform.position += movementAmount;
		}
		if (Input.GetKeyDown(KeyCode.S))
		{

			mover.transform.position -= movementAmount;
		}if (Input.GetKeyDown(KeyCode.D))
		{

			mover.transform.position -=  movementplacement;
		}if (Input.GetKeyDown(KeyCode.A))
		{

			mover.transform.position +=  movementplacement;
		}

	}
}