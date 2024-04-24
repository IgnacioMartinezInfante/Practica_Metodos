using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cajasinventario : MonoBehaviour
{
    public GameObject objetoCaja; 
    public Inventario inventario; 
    public float distanciaDeInstancia = 3f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Caja"))
        {
            Destroy(collision.gameObject); 

            inventario.Incrementarcontador("cajas", 1);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Inventario.contadorcajas > 0) 
            {
                Vector3 posicionDeInstancia = transform.position + transform.forward * distanciaDeInstancia;

                Instantiate(objetoCaja, posicionDeInstancia, Quaternion.identity);

                inventario.Disminuircontador("cajas", 1);
            }           
        }
    }
}
