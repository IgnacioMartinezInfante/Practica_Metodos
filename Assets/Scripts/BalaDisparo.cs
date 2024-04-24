using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaDisparo : MonoBehaviour
{
    public GameObject proyectilPrefab; 

    public void DispararProyectil(Vector3 posicionInicial, float velocidad)
    {
        GameObject proyectil = Instantiate(proyectilPrefab, posicionInicial, Quaternion.identity);

        Rigidbody rb = proyectil.GetComponent<Rigidbody>();

        rb.velocity = proyectil.transform.forward * velocidad;
    }
}
