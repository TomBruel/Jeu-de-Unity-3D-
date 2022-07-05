using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pion2 : MonoBehaviour
{
    private bool monTour = false;
    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") == true && monTour == true)
        {
            jetDeEtavancer();
            monTour = !monTour;
        }
        else
        {
            if (Input.GetKeyDown("space") == true && monTour == false) monTour = !monTour;
        }
            GameObject.Find("Main Camera").transform.position = gameObject.transform.position + new Vector3(-15f, 10f, 0f);
    }

    private int jetde()
    {
        int valeurDuDe = 0;
        valeurDuDe = Random.Range(1, 7);
        Debug.Log("Valeur du de : " + valeurDuDe);
        return valeurDuDe;
    } 

    private void jetDeEtavancer()
    {
        int valeurDuDe = jetde();
        Vector3 xyz = gameObject.transform.position;

        /* test si on s'arrête avant la derniere case
         * si oui, on avance comme prévu
         * si non, alors on s'arrête à la position de la derniere case
         */
        if(xyz[0] + valeurDuDe * 20f < 210f )
        {
            gameObject.transform.position += new Vector3(valeurDuDe*10f, 0f, 0f);
        }
        else
        {
            gameObject.transform.position = new Vector3(210f, xyz[1], xyz[2]);
        }
    }
} 
