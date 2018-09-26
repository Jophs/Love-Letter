using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{

    public bool guardPlayed = false;
 

    void Start()
    {

       
    }



    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("OnPointerEnter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("OnPointerExit");
    }


    public GameObject item
    {
        get
        {
            if (transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }


    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerDrag.name + " was dropped on " + gameObject.name);
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();

        if (d != null)
        {
            d.parentToReturnTo = this.transform;

            if(eventData.pointerDrag.name == "Guard")
            {
                guardPlayed = true;
                //Debug.Log(guardPlayed);
                    
            }

        }
<<<<<<< HEAD:Assets/Scripts/DropZone.cs
=======


        // If Guard is played, activate GuardEffect
        if (eventData.pointerDrag.name.Contains("Guard"))
        {
            
        }
    }
>>>>>>> 3f49e19f145913bf009abb93b8ae054293121428:Assets/DropZone.cs


    }

}
