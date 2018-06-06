using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler2 : MonoBehaviour {

	public Text score;
	public int highscore;
	private GameStatus2 NewScore;

	// Use this for initialization
	void Start () {
		score.text = PlayerPrefs.GetInt ("HighScore2",0).ToString("f0");
	}
	
	// Update is called once per frame
	void Update () {
		NewScore = GameObject.Find ("GameStatus5x12").GetComponent<GameStatus2> ();
		highscore = NewScore.highScore;
		score = GameObject.Find ("HighScore2").GetComponent<Text> ();
		PlayerPrefs.SetInt ("HighScore2",highscore);
		score.text = "" + highscore.ToString ("f0");
	}
}
