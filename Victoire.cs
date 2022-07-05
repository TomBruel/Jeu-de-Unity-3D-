using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victoire : MonoBehaviour
{
    public GameObject victoire1;
    public GameObject victoire2;
    // Start is called before the first frame update
    void Start()
    {
        victoire1.SetActive(false);
        victoire2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "PION1")
        {
            victoire1.SetActive(true);
        }
        else
        {
            if(collision.gameObject.name == "PION2")
            {
                victoire2.SetActive(true);
            }
        }
    }
}
