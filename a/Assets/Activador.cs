using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activador : MonoBehaviour
{
    public GameObject[] botones;
    private bool estoyActivo;

    // Use this for initialization
    void Start()
    {
        DesactivarObjetos();

    }

    private void DesactivarObjetos()
    {
        foreach (GameObject boton in botones)
        {
            boton.SetActive(false);
        }
        estoyActivo = false;

    }
    public void ReactivarObjetos()
    {
        if (estoyActivo)
        {
            foreach (GameObject boton in botones)
            {
                boton.SetActive(false);
            }
            estoyActivo = false;
        }
        else
        {
            foreach(GameObject boton in botones)
            {
                boton.SetActive(true);
            }
            estoyActivo = true;
            
        }
    }


}





