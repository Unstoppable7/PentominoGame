using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeHandler2 : MonoBehaviour {

	public Text crono;
	public Text highScore;
	public Text Score3;
	private float time = 0.0f;
	public int score = 0, temp = 0;
	private GameStatus2 timer;

	void Start () {
		crono.text = "" + time.ToString ("f0");
		highScore.text = PlayerPrefs.GetInt ("HighScore2",0).ToString("f0");
	}

	void Update () {
		if (DragHandler.ganar) {
			if (PlayerPrefs.GetInt ("HighScore2", 0) == 0) {
				PlayerPrefs.SetInt ("HighScore2", (int)time);
				highScore.text = time.ToString ("f0");

				score = (int)time;
				timer = GameObject.Find ("GameStatus5x12").GetComponent<GameStatus2> ();
				timer.highScore = score;
				temp = timer.highScore;

			} else if (time < PlayerPrefs.GetInt ("HighScore2", 0)) {
				PlayerPrefs.SetInt ("HighScore2", (int)time);
				highScore.text = time.ToString ("f0");

				score = (int)time;
				timer = GameObject.Find ("GameStatus5x12").GetComponent<GameStatus2> ();
				timer.highScore = score;
				temp = timer.highScore;
			}
			else if(time > PlayerPrefs.GetInt ("HighScore2", 0))
			{
				temp = (int)time;
			}

			Score3.text = "" + score;

		} else {
			time += Time.deltaTime;
			crono.text = "" + time.ToString ("f0");
		}
	}
}
