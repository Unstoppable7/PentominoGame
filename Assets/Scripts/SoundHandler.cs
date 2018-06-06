using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHandler : MonoBehaviour {

	public static SoundHandler sound;


	void Awake()
	{
		if(sound == null)
		{
			sound = this;
			DontDestroyOnLoad (gameObject);
		}else if(sound != this)
		{
			Destroy (gameObject);
		}
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
