using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeHandler2 : MonoBehaviour {

	public Text crono;
	public Text highScore;
	public Text Score2;
	private float time = 0.0f;
	public int score = 0;
	private GameStatus2 timer;

	// Use this for initialization
	void Start () {
		crono.text = "" + time.ToString ("f0");
		highScore.text = PlayerPrefs.GetInt ("HighScore2",0).ToString("f0");
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		crono.text = "" + time.ToString ("f0");

		if(DragHandler.ganar)
		{
			if (PlayerPrefs.GetInt ("HighScore2", 0) == 0) {
				PlayerPrefs.SetInt ("HighScore2", (int)time);
				highScore.text = time.ToString ("f0");

				score = (int)time;
				timer = GameObject.Find ("GameStatus5x12").GetComponent<GameStatus2> ();
				timer.highScore = score;

			} else if (time > PlayerPrefs.GetInt ("HighScore2", 0)) {
				PlayerPrefs.SetInt ("HighScore2", (int)time);
				highScore.text = time.ToString ("f0");

				score = (int)time;
				timer = GameObject.Find ("GameStatus5x12").GetComponent<GameStatus2> ();
				timer.highScore = score;
			}
			Score2.text = "" + score;

		}

	}

	public void SaveScore()
	{

		if (PlayerPrefs.GetInt ("HighScore2", 0) == 0) {
			PlayerPrefs.SetInt ("HighScore2", (int)time);
			highScore.text = time.ToString ("f0");

			score = (int)time;
			timer = GameObject.Find ("GameStatus5x12").GetComponent<GameStatus2> ();
			timer.highScore = score;

		} else if (time > PlayerPrefs.GetInt ("HighScore2", 0)) {
			PlayerPrefs.SetInt ("HighScore2", (int)time);
			highScore.text = time.ToString ("f0");

			score = (int)time;
			timer = GameObject.Find ("GameStatus5x12").GetComponent<GameStatus2> ();
			timer.highScore = score;
		}
		Score2.text = "" + score;
	}
}
