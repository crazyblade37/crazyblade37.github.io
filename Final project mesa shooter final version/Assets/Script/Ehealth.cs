

using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class Ehealth : MonoBehaviour {
//website for health code = https://www.youtube.com/watch?v=5zNDRMJ3_AA code is by Lena Florian i had to alter part of the code because of it becoming outdated

	AudioSource enemydeath; // audio to storage clip
	public AudioClip death;//audio clip from thecheeseman the link to audio is here http://soundbible.com/1454-Pain.html


	private float health,maxHealth;
	private Image healthBar;// website for health image - https://www.2old2play.com/games/battle-high-2
	public float Health { get { return health; } }
	void Start () {
		health = 100f;
		maxHealth = 100f;
		healthBar = transform.Find("EnemyCanvas").Find ("HealthBG").Find ("Health").GetComponent<Image>();
		enemydeath = GetComponent<AudioSource>();//audiosource from object

	}

	// Update is called once per frame
	void Update () {
		transform.LookAt(GameObject.Find("player").transform);
	}

	public void Hit(float damage)
	{
		health -= damage;
		healthBar.fillAmount = health / maxHealth;
		if (healthBar.fillAmount == 0) {
			Destroy(gameObject);
			enemydeath.PlayOneShot(death);// start after death
		}

	}
}
