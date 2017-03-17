using UnityEngine;
using System.Collections;

public class Birdcontroller : MonoBehaviour {
	public Camera cam;
	private float maxWidth;
	public float speed;

	void Start () {
		if (cam == null) {
			cam = Camera.main;		
		}
		Vector3 upperCorner = new Vector3 (Screen.width, Screen.height, 0.0f);
		Vector3 targetWidth = cam.ScreenToWorldPoint ( upperCorner);
		float birdWidth = renderer.bounds.extents.x;
		maxWidth = targetWidth.x - (birdWidth);
	}

	

	void FixedUpdate () {
		/*float move = Input.GetAxis("Horizontal");
		rigidbody2D.velocity = new Vector2 (move*speed,rigidbody2D.velocity.y);
		*/		


		

		}

}
