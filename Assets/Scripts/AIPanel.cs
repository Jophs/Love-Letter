using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIPanel : MonoBehaviour {

    public GameObject Panel;

    void Start()
    {
        Panel.SetActive(false);
        Panel = GameObject.Find("AIPanel");

    }

    // Show the AIPanel
    public void showPanel()
    {

        Panel.SetActive(true);

    }
}
