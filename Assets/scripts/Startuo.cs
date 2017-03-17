using UnityEngine;
using System.Collections;

public class Startuo : MonoBehaviour {
	public AudioSource audii;
	public void Startgam ()
	{
		audii.Play();
		Application.LoadLevel (1);
	}
}
