using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Colisionador : MonoBehaviour
{
    public static bool trigger;
    public static bool insertado;
    Transform objColisionado;
    
    void OnTriggerEnter2D(Collider2D colisionador)
    {
        if (colisionador.transform.CompareTag("Figura"))
        {
            trigger = true;
            objColisionado = colisionador.transform;
            //print(transform.name + "  " + colisionador.transform.name);
        }        
    }
    void OnTriggerExit2D(Collider2D colisionador)
    {
        if (colisionador.transform.CompareTag("Figura") )
        {
            trigger = false;
            objColisionado = null;
        }
    }
    void Update()
    {
        if (trigger && DragHandler.drop && objColisionado)
        {

            objColisionado.transform.SetParent(transform);
            objColisionado.transform.position = transform.position;
            insertado = true;
        }

    }
}
