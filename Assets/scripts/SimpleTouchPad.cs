using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class SimpleTouchPad : MonoBehaviour , IPointerDownHandler , IPointerUpHandler {
	private bool touched;
	private int pointyerID;
	private bool canFire;

	void Awake ()
	{touched = false;
	}
	public void OnPointerDown (PointerEventData data)
	{
		if (!touched) {
			touched = true;
			pointyerID = data.pointerId;
			canFire = true;
		}
	}

	public void OnPointerUp (PointerEventData data)
	{
		if (data.pointerId == pointyerID) {
			canFire = false;
			touched = false;
		}
	}
	public bool Canfire ()
	{
		return canFire;
	}

}
