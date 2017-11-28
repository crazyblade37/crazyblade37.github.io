

using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class Ehealth : MonoBehaviour {
	// website for health image - https://www.2old2play.com/games/battle-high-2


	//website for health code = https://www.youtube.com/watch?v=5zNDRMJ3_AA code is by Lena Florian i had to alter part of the code because of it becoming outdated

	private float health,maxHealth;
	private Image healthBar;
	public float Health { get { return health; } }
	void Start () {
		health = 100f;
		maxHealth = 100f;
		healthBar = transform.Find("EnemyCanvas").Find ("HealthBG").Find ("Health").GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Hit(float damage)
	{
		health -= damage;
		healthBar.fillAmount = health / maxHealth;
		if (healthBar.fillAmount == 0) {
			Destroy(gameObject);
		}

	}
}
