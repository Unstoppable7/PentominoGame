using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganaste : MonoBehaviour {
    public GameObject ganaste;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (DragHandler.ganar)
        {
			//Time.timeScale = 1f;
            ganaste.SetActive(true);
        }
        else
        {
			//Time.timeScale = 1f;
            ganaste.SetActive(false);
        }
	}
}
