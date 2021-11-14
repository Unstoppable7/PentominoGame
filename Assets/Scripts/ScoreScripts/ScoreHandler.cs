using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour {

	public Text score;
	public int highscore;
	private GameStatus NewScore;

	// Use this for initialization
	void Start () {
		score.text = PlayerPrefs.GetInt ("HighScore",0).ToString("f0");
	}
	
	// Update is called once per frame
	void Update () {
		NewScore = GameObject.Find ("GameStatus6x10").GetComponent<GameStatus> ();
		highscore = NewScore.highScore;
		score = GameObject.Find ("HighScore").GetComponent<Text> ();
		PlayerPrefs.SetInt ("HighScore",highscore);
		score.text = "" + highscore.ToString ("f0") + "s";
	}
}
