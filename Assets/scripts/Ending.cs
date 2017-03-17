using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Ending : MonoBehaviour {
	public Text scoreend;
	public Text highscored;
	long score =0;
	long highscore=0;
	void Start () {
		score = PlayerPrefs.GetInt ("Score");
		scoreend.text = "Score : " + score;
		highscore = PlayerPrefs.GetInt ("HighScore");
		highscored.text = "high score : " + highscore;
	}
	

}
