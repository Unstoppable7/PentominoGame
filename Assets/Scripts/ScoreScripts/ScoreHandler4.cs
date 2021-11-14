using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler4 : MonoBehaviour {

	public Text score;
	public int highscore;
	private GameStatus4 NewScore;

	// Use this for initialization
	void Start () {
		score.text = PlayerPrefs.GetInt ("HighScore4",0).ToString("f0");
	}
	
	// Update is called once per frame
	void Update () {
		NewScore = GameObject.Find ("GameStatus3x20").GetComponent<GameStatus4> ();
		highscore = NewScore.highScore;
		score = GameObject.Find ("HighScore4").GetComponent<Text> ();
		PlayerPrefs.SetInt ("HighScore4",highscore);
		score.text = "" + highscore.ToString ("f0")+ "s";
	}
}
