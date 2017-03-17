using UnityEngine;
using System.Collections;

public class Powerup : MonoBehaviour {

	Timer tim;
	public int increament;
	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.tag == "Player") {
			
			tim = GameObject.Find ("Main Camera").GetComponent<Timer> ();
			
			Destroy(this.gameObject);
			Timer.timetaken+=increament;
			
		}
	}

}
