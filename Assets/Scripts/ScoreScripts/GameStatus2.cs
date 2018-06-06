using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus2 : MonoBehaviour {

	public static GameStatus2 gameStatus;
	public int highScore;

	void Awake()
	{
		if(gameStatus == null)
		{
			gameStatus = this;
			DontDestroyOnLoad (gameObject);
		}
		else if(gameStatus != this)
		{
			Destroy (gameObject);
		}
	}
}
