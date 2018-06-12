using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour {

    public AudioSource sound;

    void Awake()
    {
       // DontDestroyOnLoad(sound);
    }
    public void seisDiez()
    {
        SceneManager.LoadScene("6x10");
    }
    public void cincoDoce()
    {
        SceneManager.LoadScene("5x12");
    }
    public void cuatroQuince()
    {
        SceneManager.LoadScene("4x15");
    }
    public void tresVeinte()
    {
        SceneManager.LoadScene("3x20");
    }
    public void chooseMap()
    {
        SceneManager.LoadScene("ChooseMap");
    }
   public void mute()
    {
        if (sound.isPlaying)
        {
            sound.Stop();
        }
        else
        {
            sound.Play();
        }
    }

    public void credits()
    {
        SceneManager.LoadScene("Credits");
    }
	public void score()
	{
		SceneManager.LoadScene("Scores");
	}

    public void menuPrincipal()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void girarDer()
    {
        if (DragHandler.seleccionado)
        {
            DragHandler.seleccionado.Rotate(0, 0, -90);
        }
    }

    public void girarIzq()
    {
        if (DragHandler.seleccionado)
        {
            DragHandler.seleccionado.Rotate(0, 0, 90);
        }
    }

    public void volteaHorizontal()
    {
        if (DragHandler.seleccionado)
        {
            DragHandler.seleccionado.Rotate(0, 180, 0);
        }
    }
    public void volteaVertical()
    {
		if (DragHandler.seleccionado)
        {
            DragHandler.seleccionado.Rotate(180, 0, 0,Space.World);
        }
    }
}
