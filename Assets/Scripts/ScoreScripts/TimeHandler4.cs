using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeHandler4 : MonoBehaviour {

	public Text crono;
	public Text highScore;
	public Text Score;
	private float time = 0.0f;
	public int score = 0,temp=0;
	private GameStatus4 timer;

	// Use this for initialization
	void Start () {
		crono.text = "" + time.ToString ("f0");
		highScore.text = PlayerPrefs.GetInt ("HighScore4",0).ToString("f0");
	}
	
	// Update is called once per frame
	void Update () {

		if (DragHandler.ganar) {
			if (PlayerPrefs.GetInt ("HighScore4", 0) == 0) {
				PlayerPrefs.SetInt ("HighScore4", (int)time);
				highScore.text = time.ToString ("f0");

				score = (int)time;
				timer = GameObject.Find ("GameStatus3x20").GetComponent<GameStatus4> ();
				timer.highScore = score;
				temp = timer.highScore;

			} else if (time < PlayerPrefs.GetInt ("HighScore4", 0)) {
				PlayerPrefs.SetInt ("HighScore4", (int)time);
				highScore.text = time.ToString ("f0");

				score = (int)time;
				timer = GameObject.Find ("GameStatus3x20").GetComponent<GameStatus4> ();
				timer.highScore = score;
				temp = timer.highScore;

			} else if (time > PlayerPrefs.GetInt ("HighScore4", 0)) {
				
				temp = (int)time;
			}

			Score.text = "" + temp;

		} else 
		{
			time += Time.deltaTime;
			crono.text = "" + time.ToString ("f0");
		}
	}

	/*public void SaveScore()
	{

		if (PlayerPrefs.GetInt ("HighScore4", 0) == 0) {
			PlayerPrefs.SetInt ("HighScore4", (int)time);
			highScore.text = time.ToString ("f0");

			score = (int)time;
			timer = GameObject.Find ("GameStatus3x20").GetComponent<GameStatus4> ();
			timer.highScore = score;

		} else if (time > PlayerPrefs.GetInt ("HighScore4", 0)) {
			PlayerPrefs.SetInt ("HighScore4", (int)time);
			highScore.text = time.ToString ("f0");

			score = (int)time;
			timer = GameObject.Find ("GameStatus3x20").GetComponent<GameStatus4> ();
			timer.highScore = score;
		}

	}*/
}
