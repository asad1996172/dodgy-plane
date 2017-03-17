using UnityEngine;
using System.Collections;

public class Pointscorer : MonoBehaviour {
	public AudioSource audi;

	void OnCollisionEnter2D (Collision2D coll)
	{
		if(coll.gameObject.tag == "powerup" )
		{
		audi.Play();
		}
		}
}
