using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDisparo : MonoBehaviour
{
    public BalaDisparo disparador; 

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 posicionInicial = transform.position;

            float velocidadProyectil = 20f; 

            disparador.DispararProyectil(posicionInicial, velocidadProyectil);
        }
    }
}
