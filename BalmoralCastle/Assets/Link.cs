using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   public void otvoriLink ()
    {
        Application.OpenURL("https://c2.etf.unsa.ba/course/view.php?id=44");
    }
}
