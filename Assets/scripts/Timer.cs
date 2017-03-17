using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {


	public Text timerText;
    public static float timetaken = 0f;
	public static int highscore ;
	private int temp;
	//int asad = 0;
	void Awake()
	{
		timetaken = 0f;
		//asad=PlayerPrefs.GetInt ("asad");
		highscore = PlayerPrefs.GetInt ("HighScore");


		}

	void Update ()
	{
		timetaken += Time.deltaTime;
	
		timerText.text = "Score : " + Mathf.RoundToInt (timetaken);
	}
	public void IncreaseScore (int amount)
	{
		timetaken += amount;
	}
	void FixedUpdate ()
	{

	}
void OnDisable()
	{
		 if (timetaken > highscore) {
			highscore = (int) timetaken;
		}

		PlayerPrefs.SetInt ("HighScore", highscore);
		PlayerPrefs.SetInt ("Score",(int)timetaken);
		//timetaken = 0f;
	}
}
