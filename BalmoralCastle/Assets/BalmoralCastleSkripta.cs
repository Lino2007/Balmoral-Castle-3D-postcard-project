using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalmoralCastleSkripta : MonoBehaviour {

    Ray ray;
    RaycastHit hit;

    public GameObject Tekst;
    public GameObject VideoPlane;
    public GameObject Glazba;

    //mjesto za pomocne varijable



	// Use this for initialization
	void Start () {
      // Tekst.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //  bool aktivnostTeksta = Tekst.activeSelfako;

        if (Input.GetMouseButtonDown(0))
        {
            bool aktivnostTekst = Tekst.activeInHierarchy, aktivnostVideoPlane = VideoPlane.activeInHierarchy,
             aktivnostGlazba = Glazba.activeInHierarchy;


            if (Physics.Raycast(ray, out hit))
            {

                if (hit.collider.gameObject.name == "Open_Book")
                {
                    if (!(aktivnostTekst))
                    {
                        VideoPlane.SetActive(false);
                        Glazba.SetActive(false);
                        Tekst.SetActive(true);
                    }
                    else
                        Tekst.SetActive(false);
                }
                else if (hit.collider.gameObject.name == "BagPipes")
                {
                    if (!(aktivnostGlazba))
                    {
                        VideoPlane.SetActive(false);
                        Tekst.SetActive(false);
                        Glazba.SetActive(true);
                    }
                    else
                        Glazba.SetActive(false);
                }
                else if (hit.collider.gameObject.name == "Crown")
                {
                    if (!(aktivnostVideoPlane))
                    {
                        Glazba.SetActive(false);
                        Tekst.SetActive(false);
                        VideoPlane.SetActive(true);
                    }
                    else
                        VideoPlane.SetActive(false);


                }
            }
        }
        }
    }

