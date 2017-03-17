using UnityEngine;
using System.Collections;

public class Prefabclloder : MonoBehaviour {
	Timer tim;
	public int increament;

   /*void OnTriggerEnter2D (Collider2D col)
	{
	
	}*/
	void OnCollisionEnter2D (Collision2D other)
	{
		
		if (other.gameObject.tag == "obstacles") {
			Application.LoadLevel (2);

			return;
		}
		/*else if (other.gameObject.tag == "powerup") {

			tim = GameObject.Find ("Main Camera").GetComponent<Timer> ();

			Destroy(other.gameObject);
			Timer.timetaken+=increament;

		}*/
	}


}
