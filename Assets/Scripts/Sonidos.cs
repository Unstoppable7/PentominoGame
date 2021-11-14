using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos : MonoBehaviour {

    public AudioSource sonido;
    int hijos = 0;
	
	// Update is called once per frame
	void Update () {

        if (hijos < transform.childCount)
        {
            sonido.Play();
        }
        hijos = transform.childCount;
	}
}
