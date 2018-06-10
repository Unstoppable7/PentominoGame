using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour,IBeginDragHandler, IDragHandler,IDropHandler,IPointerDownHandler
{

    Vector3 startPosition;
    public static bool drop;
    Transform[] nietos = new Transform[5];
    public static Transform seleccionado = null;
    public static Renderer cambiaColor=null;
    public static bool ganar;
    public static int[] banderas = new int[12];

    void Start()
    {
        startPosition = transform.position;
        nietos[0] = transform.GetChild(0).GetChild(0).transform;
        nietos[1] = transform.GetChild(1).GetChild(0).transform;
        nietos[2] = transform.GetChild(2).GetChild(0).transform;
        nietos[3] = transform.GetChild(3).GetChild(0).transform;
        nietos[4] = transform.GetChild(4).GetChild(0).transform;
        banderas[0] = 0;banderas[1] = 0;banderas[2] = 0;banderas[3] = 0;banderas[4] = 0;banderas[5] = 0;banderas[6] = 0;banderas[7] = 0;banderas[8] = 0;banderas[9] = 0;banderas[10] = 0;banderas[11] = 0;
    }
    void Update()
    {

        //Positiva
        if(transform.name == "I")// && transform.GetChild(0).childCount < 1 && transform.GetChild(1).childCount < 1 && transform.GetChild(2).childCount < 1 && transform.GetChild(3).childCount < 1 && transform.GetChild(4).childCount < 1)
        {
            Transform hijo1 = nietos[0].parent.GetComponent<Transform>();
            Transform hijo2 = nietos[1].parent.GetComponent<Transform>();
            Transform hijo3 = nietos[2].parent.GetComponent<Transform>();
            Transform hijo4 = nietos[3].parent.GetComponent<Transform>();
            Transform hijo5 = nietos[4].parent.GetComponent<Transform>();

            if (hijo1.CompareTag("Mapa") && hijo2.CompareTag("Mapa") && hijo3.CompareTag("Mapa") && hijo4.CompareTag("Mapa") && hijo5.CompareTag("Mapa") && hijo1.childCount < 2 && hijo2.childCount < 2 && hijo3.childCount < 2 && hijo4.childCount < 2 && hijo5.childCount < 2)
            {
                banderas[0] = 1;
            }
            
           // print(transform.name + " Colocado");
        }
        else if(transform.name == "W")// && transform.GetChild(0).childCount < 1 && transform.GetChild(1).childCount < 1 && transform.GetChild(2).childCount < 1 && transform.GetChild(3).childCount < 1 && transform.GetChild(4).childCount < 1)
        {
            Transform hijo1 = nietos[0].parent.GetComponent<Transform>();
            Transform hijo2 = nietos[1].parent.GetComponent<Transform>();
            Transform hijo3 = nietos[2].parent.GetComponent<Transform>();
            Transform hijo4 = nietos[3].parent.GetComponent<Transform>();
            Transform hijo5 = nietos[4].parent.GetComponent<Transform>();

            if (hijo1.CompareTag("Mapa") && hijo2.CompareTag("Mapa") && hijo3.CompareTag("Mapa") && hijo4.CompareTag("Mapa") && hijo5.CompareTag("Mapa") && hijo1.childCount < 2 && hijo2.childCount < 2 && hijo3.childCount < 2 && hijo4.childCount < 2 && hijo5.childCount < 2)
            {
                banderas[1] = 1;
            }
            //print(transform.name + " Colocado");
        }
        else if (transform.name == "F")// && transform.GetChild(0).childCount < 1 && transform.GetChild(1).childCount < 1 && transform.GetChild(2).childCount < 1 && transform.GetChild(3).childCount < 1 && transform.GetChild(4).childCount < 1)
        {
            Transform hijo1 = nietos[0].parent.GetComponent<Transform>();
            Transform hijo2 = nietos[1].parent.GetComponent<Transform>();
            Transform hijo3 = nietos[2].parent.GetComponent<Transform>();
            Transform hijo4 = nietos[3].parent.GetComponent<Transform>();
            Transform hijo5 = nietos[4].parent.GetComponent<Transform>();

            if (hijo1.CompareTag("Mapa") && hijo2.CompareTag("Mapa") && hijo3.CompareTag("Mapa") && hijo4.CompareTag("Mapa") && hijo5.CompareTag("Mapa") && hijo1.childCount < 2 && hijo2.childCount < 2 && hijo3.childCount < 2 && hijo4.childCount < 2 && hijo5.childCount < 2)
            {
                banderas[2] = 1;
            }
            //print(transform.name + " Colocado");
        }
        else if (transform.name == "L")// && transform.GetChild(0).childCount < 1 && transform.GetChild(1).childCount < 1 && transform.GetChild(2).childCount < 1 && transform.GetChild(3).childCount < 1 && transform.GetChild(4).childCount < 1)
        {
            Transform hijo1 = nietos[0].parent.GetComponent<Transform>();
            Transform hijo2 = nietos[1].parent.GetComponent<Transform>();
            Transform hijo3 = nietos[2].parent.GetComponent<Transform>();
            Transform hijo4 = nietos[3].parent.GetComponent<Transform>();
            Transform hijo5 = nietos[4].parent.GetComponent<Transform>();

            if (hijo1.CompareTag("Mapa") && hijo2.CompareTag("Mapa") && hijo3.CompareTag("Mapa") && hijo4.CompareTag("Mapa") && hijo5.CompareTag("Mapa") && hijo1.childCount < 2 && hijo2.childCount < 2 && hijo3.childCount < 2 && hijo4.childCount < 2 && hijo5.childCount < 2)
            {
                banderas[3] = 1;
            }
            // print(transform.name + " Colocado");
        }
        else if (transform.name == "N")// && transform.GetChild(0).childCount < 1 && transform.GetChild(1).childCount < 1 && transform.GetChild(2).childCount < 1 && transform.GetChild(3).childCount < 1 && transform.GetChild(4).childCount < 1)
        {
            Transform hijo1 = nietos[0].parent.GetComponent<Transform>();
            Transform hijo2 = nietos[1].parent.GetComponent<Transform>();
            Transform hijo3 = nietos[2].parent.GetComponent<Transform>();
            Transform hijo4 = nietos[3].parent.GetComponent<Transform>();
            Transform hijo5 = nietos[4].parent.GetComponent<Transform>();

            if (hijo1.CompareTag("Mapa") && hijo2.CompareTag("Mapa") && hijo3.CompareTag("Mapa") && hijo4.CompareTag("Mapa") && hijo5.CompareTag("Mapa") && hijo1.childCount < 2 && hijo2.childCount < 2 && hijo3.childCount < 2 && hijo4.childCount < 2 && hijo5.childCount < 2)
            {
                banderas[4] = 1;
            }
            // print(transform.name + " Colocado");
        }
        else if (transform.name == "P")// && transform.GetChild(0).childCount < 1 && transform.GetChild(1).childCount < 1 && transform.GetChild(2).childCount < 1 && transform.GetChild(3).childCount < 1 && transform.GetChild(4).childCount < 1)
        {
            Transform hijo1 = nietos[0].parent.GetComponent<Transform>();
            Transform hijo2 = nietos[1].parent.GetComponent<Transform>();
            Transform hijo3 = nietos[2].parent.GetComponent<Transform>();
            Transform hijo4 = nietos[3].parent.GetComponent<Transform>();
            Transform hijo5 = nietos[4].parent.GetComponent<Transform>();

            if (hijo1.CompareTag("Mapa") && hijo2.CompareTag("Mapa") && hijo3.CompareTag("Mapa") && hijo4.CompareTag("Mapa") && hijo5.CompareTag("Mapa") && hijo1.childCount < 2 && hijo2.childCount < 2 && hijo3.childCount < 2 && hijo4.childCount < 2 && hijo5.childCount < 2)
            {
                banderas[5] = 1;
            }
            // print(transform.name + " Colocado");
        }
        else if (transform.name == "T")// && transform.GetChild(0).childCount < 1 && transform.GetChild(1).childCount < 1 && transform.GetChild(2).childCount < 1 && transform.GetChild(3).childCount < 1 && transform.GetChild(4).childCount < 1)
        {
            Transform hijo1 = nietos[0].parent.GetComponent<Transform>();
            Transform hijo2 = nietos[1].parent.GetComponent<Transform>();
            Transform hijo3 = nietos[2].parent.GetComponent<Transform>();
            Transform hijo4 = nietos[3].parent.GetComponent<Transform>();
            Transform hijo5 = nietos[4].parent.GetComponent<Transform>();

            if (hijo1.CompareTag("Mapa") && hijo2.CompareTag("Mapa") && hijo3.CompareTag("Mapa") && hijo4.CompareTag("Mapa") && hijo5.CompareTag("Mapa") && hijo1.childCount < 2 && hijo2.childCount < 2 && hijo3.childCount < 2 && hijo4.childCount < 2 && hijo5.childCount < 2)
            {
                banderas[6] = 1;
            }
            // print(transform.name + " Colocado");
        }
        else if (transform.name == "U")// && transform.GetChild(0).childCount < 1 && transform.GetChild(1).childCount < 1 && transform.GetChild(2).childCount < 1 && transform.GetChild(3).childCount < 1 && transform.GetChild(4).childCount < 1)
        {
            Transform hijo1 = nietos[0].parent.GetComponent<Transform>();
            Transform hijo2 = nietos[1].parent.GetComponent<Transform>();
            Transform hijo3 = nietos[2].parent.GetComponent<Transform>();
            Transform hijo4 = nietos[3].parent.GetComponent<Transform>();
            Transform hijo5 = nietos[4].parent.GetComponent<Transform>();

            if (hijo1.CompareTag("Mapa") && hijo2.CompareTag("Mapa") && hijo3.CompareTag("Mapa") && hijo4.CompareTag("Mapa") && hijo5.CompareTag("Mapa") && hijo1.childCount < 2 && hijo2.childCount < 2 && hijo3.childCount < 2 && hijo4.childCount < 2 && hijo5.childCount < 2)
            {
                banderas[7] = 1;
            }
            // print(transform.name + " Colocado");
        }
        else if (transform.name == "V")// && transform.GetChild(0).childCount < 1 && transform.GetChild(1).childCount < 1 && transform.GetChild(2).childCount < 1 && transform.GetChild(3).childCount < 1 && transform.GetChild(4).childCount < 1)
        {
            Transform hijo1 = nietos[0].parent.GetComponent<Transform>();
            Transform hijo2 = nietos[1].parent.GetComponent<Transform>();
            Transform hijo3 = nietos[2].parent.GetComponent<Transform>();
            Transform hijo4 = nietos[3].parent.GetComponent<Transform>();
            Transform hijo5 = nietos[4].parent.GetComponent<Transform>();

            if (hijo1.CompareTag("Mapa") && hijo2.CompareTag("Mapa") && hijo3.CompareTag("Mapa") && hijo4.CompareTag("Mapa") && hijo5.CompareTag("Mapa") && hijo1.childCount < 2 && hijo2.childCount < 2 && hijo3.childCount < 2 && hijo4.childCount < 2 && hijo5.childCount < 2)
            {
                banderas[8] = 1;
            }
            //print(transform.name + " Colocado");
        }
        else if (transform.name == "X")// && transform.GetChild(0).childCount < 1 && transform.GetChild(1).childCount < 1 && transform.GetChild(2).childCount < 1 && transform.GetChild(3).childCount < 1 && transform.GetChild(4).childCount < 1)
        {
            Transform hijo1 = nietos[0].parent.GetComponent<Transform>();
            Transform hijo2 = nietos[1].parent.GetComponent<Transform>();
            Transform hijo3 = nietos[2].parent.GetComponent<Transform>();
            Transform hijo4 = nietos[3].parent.GetComponent<Transform>();
            Transform hijo5 = nietos[4].parent.GetComponent<Transform>();

            if (hijo1.CompareTag("Mapa") && hijo2.CompareTag("Mapa") && hijo3.CompareTag("Mapa") && hijo4.CompareTag("Mapa") && hijo5.CompareTag("Mapa") && hijo1.childCount<2 && hijo2.childCount < 2 && hijo3.childCount < 2 && hijo4.childCount < 2 && hijo5.childCount < 2)
            {
                banderas[9] = 1;
            }
            // print(transform.name + " Colocado");
        }
        else if (transform.name == "Y")// && transform.GetChild(0).childCount < 1 && transform.GetChild(1).childCount < 1 && transform.GetChild(2).childCount < 1 && transform.GetChild(3).childCount < 1 && transform.GetChild(4).childCount < 1)
        {
            Transform hijo1 = nietos[0].parent.GetComponent<Transform>();
            Transform hijo2 = nietos[1].parent.GetComponent<Transform>();
            Transform hijo3 = nietos[2].parent.GetComponent<Transform>();
            Transform hijo4 = nietos[3].parent.GetComponent<Transform>();
            Transform hijo5 = nietos[4].parent.GetComponent<Transform>();

            if (hijo1.CompareTag("Mapa") && hijo2.CompareTag("Mapa") && hijo3.CompareTag("Mapa") && hijo4.CompareTag("Mapa") && hijo5.CompareTag("Mapa") && hijo1.childCount < 2 && hijo2.childCount < 2 && hijo3.childCount < 2 && hijo4.childCount < 2 && hijo5.childCount < 2)
            {
                banderas[10] = 1;
            }
            // print(transform.name + " Colocado");
        }
        else if (transform.name == "Z")// && transform.GetChild(0).childCount < 1 && transform.GetChild(1).childCount < 1 && transform.GetChild(2).childCount < 1 && transform.GetChild(3).childCount < 1 && transform.GetChild(4).childCount < 1)
        { 
            Transform hijo1 = nietos[0].parent.GetComponent<Transform>();
            Transform hijo2 = nietos[1].parent.GetComponent<Transform>();
            Transform hijo3 = nietos[2].parent.GetComponent<Transform>();
            Transform hijo4 = nietos[3].parent.GetComponent<Transform>();
            Transform hijo5 = nietos[4].parent.GetComponent<Transform>();

            if (hijo1.CompareTag("Mapa") && hijo2.CompareTag("Mapa") && hijo3.CompareTag("Mapa") && hijo4.CompareTag("Mapa") && hijo5.CompareTag("Mapa") && hijo1.childCount < 2 && hijo2.childCount < 2 && hijo3.childCount < 2 && hijo4.childCount < 2 && hijo5.childCount < 2)
            {
                banderas[11] = 1;
            }
            //print(transform.name + " Colocado");
        }

        //Negativa
        if (transform.name == "I" && transform.GetChild(0).childCount > 0 && transform.GetChild(1).childCount > 0 && transform.GetChild(2).childCount > 0 && transform.GetChild(3).childCount > 0 && transform.GetChild(4).childCount > 0)
        {
            banderas[0] = 0;
           /// print(transform.name + " NO Colocado");
        }
        else if (transform.name == "W" && transform.GetChild(0).childCount > 0 && transform.GetChild(1).childCount > 0 && transform.GetChild(2).childCount > 0 && transform.GetChild(3).childCount > 0 && transform.GetChild(4).childCount > 0)
        {
            banderas[1] = 0;
           // print(transform.name + " NO Colocado");
        }
        else if (transform.name == "F" && transform.GetChild(0).childCount > 0 && transform.GetChild(1).childCount > 0 && transform.GetChild(2).childCount > 0 && transform.GetChild(3).childCount > 0 && transform.GetChild(4).childCount > 0)
        {
            banderas[2] = 0;
           // print(transform.name + " NO Colocado");
        }
        else if (transform.name == "L" && transform.GetChild(0).childCount > 0 && transform.GetChild(1).childCount > 0 && transform.GetChild(2).childCount > 0 && transform.GetChild(3).childCount > 0 && transform.GetChild(4).childCount > 0)
        {
            banderas[3] = 0;
           // print(transform.name + " NO Colocado");
        }
        else if (transform.name == "N" && transform.GetChild(0).childCount > 0 && transform.GetChild(1).childCount > 0 && transform.GetChild(2).childCount > 0 && transform.GetChild(3).childCount > 0 && transform.GetChild(4).childCount > 0)
        {
            banderas[4] = 0;
            //print(transform.name + " NO Colocado");
        }
        else if (transform.name == "P" && transform.GetChild(0).childCount > 0 && transform.GetChild(1).childCount > 0 && transform.GetChild(2).childCount > 0 && transform.GetChild(3).childCount > 0 && transform.GetChild(4).childCount > 0)
        {
            banderas[5] = 0;
            //print(transform.name + " NO Colocado");
        }
        else if (transform.name == "T" && transform.GetChild(0).childCount > 0 && transform.GetChild(1).childCount > 0 && transform.GetChild(2).childCount > 0 && transform.GetChild(3).childCount > 0 && transform.GetChild(4).childCount > 0)
        {
            banderas[6] = 0;
            //print(transform.name + " NO Colocado");
        }
        else if (transform.name == "U" && transform.GetChild(0).childCount > 0 && transform.GetChild(1).childCount > 0 && transform.GetChild(2).childCount > 0 && transform.GetChild(3).childCount > 0 && transform.GetChild(4).childCount > 0)
        {
            banderas[7] = 0;
            //print(transform.name + " NO Colocado");
        }
        else if (transform.name == "V" && transform.GetChild(0).childCount > 0 && transform.GetChild(1).childCount > 0 && transform.GetChild(2).childCount > 0 && transform.GetChild(3).childCount > 0 && transform.GetChild(4).childCount > 0)
        {
            banderas[8] = 0;
           // print(transform.name + " NO Colocado");
        }
        else if (transform.name == "X" && transform.GetChild(0).childCount > 0 && transform.GetChild(1).childCount > 0 && transform.GetChild(2).childCount > 0 && transform.GetChild(3).childCount > 0 && transform.GetChild(4).childCount > 0)
        {
            banderas[9] = 0;
           // print(transform.name + " NO Colocado");
        }
        else if (transform.name == "Y" && transform.GetChild(0).childCount > 0 && transform.GetChild(1).childCount > 0 && transform.GetChild(2).childCount > 0 && transform.GetChild(3).childCount > 0 && transform.GetChild(4).childCount > 0)
        {
            banderas[10] = 0;
           // print(transform.name + " NO Colocado");
        }
        else if (transform.name == "Z" && transform.GetChild(0).childCount > 0 && transform.GetChild(1).childCount > 0 && transform.GetChild(2).childCount > 0 && transform.GetChild(3).childCount > 0 && transform.GetChild(4).childCount > 0)
        {
            banderas[11] = 0;
            //print(transform.name + " NO Colocado");
        }


        if (banderas[0] == 1 && banderas[1] == 1 && banderas[2] == 1 && banderas[3] == 1 && banderas[4] == 1 && banderas[5] == 1 && banderas[6] == 1 && banderas[7] == 1 && banderas[8] == 1 && banderas[9] == 1 && banderas[10] == 1 && banderas[11] == 1)
        {
            ganar = true;
            //print(" GANAAAAAR");
        }
        else
        {
            ganar=false;
            //print(" NO GANAR");
        }
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        drop = false;
        nietos[0].SetParent(transform.GetChild(0).transform);
        nietos[1].SetParent(transform.GetChild(1).transform);
        nietos[2].SetParent(transform.GetChild(2).transform);
        nietos[3].SetParent(transform.GetChild(3).transform);
        nietos[4].SetParent(transform.GetChild(4).transform);
        //print("BeginDrag");
    }
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = (eventData.position);
    }

    public void OnDrop(PointerEventData eventData)
    {
        drop = true;
        //print("onDrop");
        if (!Colisionador.trigger)
        {
            transform.position = startPosition;
        }
        else
        {
            transform.position = nietos[2].transform.position;
            seleccionado = null;
        }
        //print("Aqui  "+Colisionador.trigger);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        seleccionado = transform;
        
    }
}
