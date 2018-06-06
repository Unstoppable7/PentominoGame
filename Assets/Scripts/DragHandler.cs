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
    void Start()
    {
        startPosition = transform.position;
        nietos[0] = transform.GetChild(0).GetChild(0).transform;
        nietos[1] = transform.GetChild(1).GetChild(0).transform;
        nietos[2] = transform.GetChild(2).GetChild(0).transform;
        nietos[3] = transform.GetChild(3).GetChild(0).transform;
        nietos[4] = transform.GetChild(4).GetChild(0).transform;
        print("start");
        
    }
    void Update()
    {
        if (transform.childCount == 0)
        {
            ganar = true;
        }
        else
        {
            ganar=false;
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
        print("BeginDrag");
    }
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = (eventData.position);
    }

    public void OnDrop(PointerEventData eventData)
    {
        drop = true;
        print("onDrop");
        if (!Colisionador.trigger)
        {
            print("Entraa");
            transform.position = startPosition;
        }
        else
        {
            transform.position = nietos[2].transform.position;
            seleccionado = null;
        }
        print("Aqui  "+Colisionador.trigger);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        seleccionado = transform;
        
    }
}
