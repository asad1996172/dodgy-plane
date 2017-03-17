using UnityEngine;
using System.Collections;

public class Lwftmover : MonoBehaviour {
	public GameObject player;
	public Camera cam;
	private float maxWidth;
	public SimpleTouchPad touch;
	// Use this for initialization
	void Start () {
		if (cam == null) {
			cam = Camera.main;		
		}
		Vector3 upperCorner = new Vector3 (Screen.width, Screen.height, 0.0f);
		Vector3 targetWidth = cam.ScreenToWorldPoint ( upperCorner);
		float birdWidth = renderer.bounds.extents.x;
		maxWidth = targetWidth.x - (birdWidth);
	}

	void Update ()
	{
		if(touch.Canfire())
		{
			player.transform.Translate (Vector3.left * 11 * Time.deltaTime);

		}


	}
	void FixedUpdate()
	{

		Vector3 targetPOsition = new Vector3 (player.transform.position.x, 0.0f, 0.0f);
		float targetWidth = Mathf.Clamp (targetPOsition.x, -maxWidth, maxWidth);
		targetPOsition = new Vector3 (targetWidth, targetPOsition.y, targetPOsition.z);
		rigidbody2D.MovePosition (targetPOsition);
	}
}
