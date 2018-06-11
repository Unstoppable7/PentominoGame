using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solution : MonoBehaviour {

	[SerializeField]
	private GameObject pausePanel;

	void Awake()
	{
		pausePanel.SetActive (false);
	}

	public void SolutionBtn()
	{
		Time.timeScale = 0f;
		pausePanel.SetActive (true);
	}

	public void QuitSolution()
	{
		Time.timeScale = 1f;
		pausePanel.SetActive (false);
	}
}
