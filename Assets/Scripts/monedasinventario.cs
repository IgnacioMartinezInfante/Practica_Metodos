using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monedasinventario : MonoBehaviour
{
    public GameObject objetoMoneda; 
    public Inventario inventario; 

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Moneda"))
        {
            Destroy(collision.gameObject); 

            inventario.Incrementarcontador("monedas", 1);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        { 
            if (Inventario.contadormonedas > 0)
            {
                // se podría hacer para pagar algo y luego disminuir el contador del inventario, pero para el ejercicio solamente lo saco del inventario
                inventario.Disminuircontador("monedas", 1);
            }
        }
    }
}
