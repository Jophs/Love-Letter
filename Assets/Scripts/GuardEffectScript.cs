using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GuardEffectScript : MonoBehaviour {


    public GameObject Panel;
    public DropZone dropZone;


    void Start()
    {
        Panel.SetActive(false);
        Panel = GameObject.Find("GuardEffectPanel");
        dropZone = GameObject.Find("Tabletop").GetComponent<DropZone>();

    }


    /* void Update()
    {
        if (dropZone.guardPlayed == true)
        {
           
            Panel.SetActive(true);

         
        }

        if (dropZone.guardPlayed == false)
        {
            //Debug.Log("close panel");
            Panel.SetActive(false);

           
        }
    } */


    // Show the GuardEffectPanel
    public void showPanel()
    {

        //Debug.Log(dropZone.guardPlayed);
       
        Panel.SetActive(true);

    }

    public void hidePanel()
    {

    }


}
