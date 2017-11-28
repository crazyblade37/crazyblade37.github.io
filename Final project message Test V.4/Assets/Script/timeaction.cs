using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeaction : MonoBehaviour {

	public float StartTime = 5f;
	public float interval = 3f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time >= StartTime){
			StartTime += interval;

			Debug.Log("menu");

		}
	}

}
