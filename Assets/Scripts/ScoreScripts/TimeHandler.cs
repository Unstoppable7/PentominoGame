using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeHandler : MonoBehaviour {

	public Text crono;
	public Text highScore;
	public Text Score3;
	private float time = 0.0f;
	public int score = 0, temp = 0;
	private GameStatus timer;

	// Use this for initialization
	void Start () {
		crono.text = "" + time.ToString ("f0");
		highScore.text = PlayerPrefs.GetInt ("HighScore",0).ToString("f0");
	}
	
	// Update is called once per frame
	void Update () {
		

		if (DragHandler.ganar) {
			if (PlayerPrefs.GetInt ("HighScore", 0) == 0) {
				PlayerPrefs.SetInt ("HighScore", (int)time);
				highScore.text = time.ToString ("f0");

				score = (int)time;
				timer = GameObject.Find ("GameStatus6x10").GetComponent<GameStatus> ();
				timer.highScore = score;
				temp = timer.highScore;

			} else if (time < PlayerPrefs.GetInt ("HighScore", 0)) {
				PlayerPrefs.SetInt ("HighScore", (int)time);
				highScore.text = time.ToString ("f0");

				score = (int)time;
				timer = GameObject.Find ("GameStatus6x10").GetComponent<GameStatus> ();
				timer.highScore = score;
				temp = timer.highScore;
			}
			else if(time > PlayerPrefs.GetInt ("HighScore", 0))
			{
				temp = (int)time;
			}

			Score3.text = "" + score;

		} else {
			time += Time.deltaTime;
			crono.text = "" + time.ToString ("f0");
		}
	}

	/*public void SaveScore()
	{

		if (PlayerPrefs.GetInt ("HighScore", 0) == 0) {
			PlayerPrefs.SetInt ("HighScore", (int)time);
			highScore.text = time.ToString ("f0");

			score = (int)time;
			timer = GameObject.Find ("GameStatus6x10").GetComponent<GameStatus> ();
			timer.highScore = score;

		} else if (time > PlayerPrefs.GetInt ("HighScore", 0)) {
			PlayerPrefs.SetInt ("HighScore", (int)time);
			highScore.text = time.ToString ("f0");

			score = (int)time;
			timer = GameObject.Find ("GameStatus6x10").GetComponent<GameStatus> ();
			timer.highScore = score;
		}

	}*/
}
