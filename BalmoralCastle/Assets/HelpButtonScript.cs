using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpButtonScript : MonoBehaviour {

    public GameObject text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void prikaziTekst ()
    {
        if (text.activeSelf) text.SetActive(false);
        else text.SetActive(true);
    }
}
