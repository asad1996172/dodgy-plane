using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {
	public AudioSource audiii;
	public void Restartgame ()
	{
		audiii.Play();

		Application.LoadLevel (1);
	}
}
