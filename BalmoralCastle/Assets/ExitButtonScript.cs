using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButtonScript : MonoBehaviour {

    // Use this for initialization

    public Text Texst;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void funkcija ()
    {
        Application.Quit();
    }
}
