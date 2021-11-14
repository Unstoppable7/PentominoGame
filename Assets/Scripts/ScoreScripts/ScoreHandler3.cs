using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler3 : MonoBehaviour {

	public Text score;
	public int highscore;
	private GameStatus3 NewScore;

	// Use this for initialization
	void Start () {
		score.text = PlayerPrefs.GetInt ("HighScore3",0).ToString("f0");
	}
	
	// Update is called once per frame
	void Update () {
		NewScore = GameObject.Find ("GameStatus4x15").GetComponent<GameStatus3> ();
		highscore = NewScore.highScore;
		score = GameObject.Find ("HighScore3").GetComponent<Text> ();
		PlayerPrefs.SetInt ("HighScore3",highscore);
		score.text = "" + highscore.ToString ("f0") + "s";
	}
}
