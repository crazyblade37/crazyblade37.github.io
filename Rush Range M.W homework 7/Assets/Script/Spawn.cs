using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
	

	public GameObject prefab; //selected prefab from our project view 
	public Transform spawnPoint;//use the position of this transform as a spawn point
	public float spawnTime = 3f;// code for spawn by Sillan and website http://answers.unity3d.com/questions/398607/spawn-after-every-5-seconds.html

	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnBall", spawnTime, spawnTime);
	}

	// Update is called once per frame
	void Update () {
		


	}
	void SpawnBall()
	{
		var newBall = GameObject.Instantiate(prefab);
	}

}