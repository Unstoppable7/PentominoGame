using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour,IDropHandler{

	public GameObject item {
			
		get {
			if (transform.childCount > 0) {
				return transform.GetChild (0).gameObject;
			}
			return null;
		}
	}

	#region IDropHandler implementation

	public void OnDrop (PointerEventData eventData)
	{
		/*
		if (!item) {
			for(int i=0;i<nroHijos;i++){
				DragHandeler.itemsBeingDragged[i].transform.SetParent (transform);
			}
		}*/
	}

	#endregion
}
