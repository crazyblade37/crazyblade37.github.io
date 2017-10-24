using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Basic3DPlus : MonoBehaviour {

	public GameObject mover;
	public int movementAmt = 1;
	public Vector3 startingPosition;
	public GameObject winSpot;
	public GameObject[] enemies;
	public AudioSource Loser;//http://soundbible.com/1501-Buzzer.html this audio is from cognito
	public AudioSource Win;//http://soundbible.com/1003-Ta-Da.html this audio is from Mike Koenig 
	public AudioSource tp;//http://soundbible.com/1501-Buzzer.html Music Maker: Sound Effects Bible since the publisher had no name.
	public float enemySpeed = 0.1f;

	// Use this for initialization
	void Start () {
		
		startingPosition = mover.transform.position;

	}

	// Update is called once per frame
	void Update () {
		

		if (mover.transform.position.z < 0 || //is it behind the grid?
		    mover.transform.position.z > 17 || //is it too far off the grid?
		    mover.transform.position.x < -5 || //is it too far left of the grid?
		    mover.transform.position.x > 5) { //is it too far right of the grid?
			mover.transform.position = startingPosition; //if any of those are true... reset it's position to the starting position
		}
		if (mover.transform.position == 
			new Vector3 (winSpot.transform.position.x, //...x as winSpot
				mover.transform.position.y, //...y as itself, because the winSpot is below it and we don't care about the y
				winSpot.transform.position.z)){ //z as winSpot
			//if so...
			Debug.Log ("win?"); //give us a console message

			mover.GetComponent<MeshRenderer> ().material.color = Color.red; //access the color through 
			newLevel ();

		
		}
		for (int i = 0; i < enemies.Length; i++) {
			if (mover.transform.position == enemies[i].transform.position) { //is mover in same position as enemy?
				mover.transform.position = startingPosition; 
				Loser.Play();
			}

			if (enemies[i].transform.position.x > -6) {
				enemies[i].transform.position += new Vector3 (-enemySpeed, 0, 0);
			} else {
				enemies[i].transform.position = new Vector3 (6, enemies[i].transform.position.y, enemies[i].transform.position.z);
			}
		}



		if (Input.GetKeyDown (KeyCode.A)) {
			
			mover.transform.position += new Vector3 (-movementAmt, 0, 0);
			tp.Play();
		} 
		if (Input.GetKeyDown (KeyCode.D)) {
			
			mover.transform.position += new Vector3 (movementAmt, 0, 0);
			tp.Play();
		} 

		if (Input.GetKeyDown (KeyCode.W)) {
			
		
			mover.transform.position += new Vector3 (0, 0, movementAmt);

			tp.Play();
		} 
			
		if (Input.GetKeyDown (KeyCode.S)) {
			
			mover.transform.position += new Vector3 (0, 0, -movementAmt);
			tp.Play();
		} 

	
	}


	void newLevel(){
		mover.transform.position = startingPosition; 
		mover.GetComponent<MeshRenderer> ().material.color = new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f), 1F);
		Win.Play();
		enemySpeed += 0.05f;

		for (int i = 0; i < enemies.Length; i++) {
			enemies [i].transform.position = new Vector3 (Random.Range (-6, 6), enemies[i].transform.position.y, Random.Range (1, 15));
		}

}
	void OnTriggerEnter(Collider other) {

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
