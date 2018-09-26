using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GuardEffect : MonoBehaviour
{

    public DropZone dropZone;
    
 

    // Use this for initialization
    void Start () {

        dropZone = GameObject.Find("Tabletop").GetComponent<DropZone>();

	}
	
	// Update is called once per frame
	void Update () {

            if(dropZone.guardPlayed == true)
        {
            Debug.Log("do effect of guard");
        }

	}





}
