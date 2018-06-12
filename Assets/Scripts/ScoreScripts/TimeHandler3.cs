using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeHandler3 : MonoBehaviour {

	public Text crono;
	public Text highScore;
	public Text Score1;
	private float time = 0.0f;
	public int score = 0;
	private GameStatus3 timer;

	// Use this for initialization
	void Start () {
		crono.text = "" + time.ToString ("f0");
		highScore.text = PlayerPrefs.GetInt ("HighScore3",0).ToString("f0");
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		crono.text = "" + time.ToString ("f0");

		if(DragHandler.ganar)
		{
			
			if (PlayerPrefs.GetInt ("HighScore3", 0) == 0) {
				PlayerPrefs.SetInt ("HighScore3", (int)time);
				highScore.text = time.ToString ("f0");

				score = (int)time;
				timer = GameObject.Find ("GameStatus4x15").GetComponent<GameStatus3> ();
				timer.highScore = score;

			} else if (time < PlayerPrefs.GetInt ("HighScore3", 0)) {
				PlayerPrefs.SetInt ("HighScore3", (int)time);
				highScore.text = time.ToString ("f0");

				score = (int)time;
				timer = GameObject.Find ("GameStatus4x15").GetComponent<GameStatus3> ();
				timer.highScore = score;
			}

			Score1.text = "" + score;
		}
	}

	public void SaveScore()
	{

		if (PlayerPrefs.GetInt ("HighScore3", 0) == 0) {
			PlayerPrefs.SetInt ("HighScore3", (int)time);
			highScore.text = time.ToString ("f0");

			score = (int)time;
			timer = GameObject.Find ("GameStatus4x15").GetComponent<GameStatus3> ();
			timer.highScore = score;

		} else if (time > PlayerPrefs.GetInt ("HighScore3", 0)) {
			PlayerPrefs.SetInt ("HighScore3", (int)time);
			highScore.text = time.ToString ("f0");

			score = (int)time;
			timer = GameObject.Find ("GameStatus4x15").GetComponent<GameStatus3> ();
			timer.highScore = score;
		}

	}
}
