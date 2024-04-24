using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cajasmisiones : MonoBehaviour
{
    public GameObject objetoMoneda; 
    public GameObject objetoCaja;
    public Inventario inventario; 
    public Misiones misiones; 
   
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            misiones.Activarmision("cajas", 1);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            misiones.Activarmision("cajas", 2);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            misiones.Activarmision("monedas", 1);
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            misiones.Activarmision("monedas", 2);
        }


        if (Inventario.contadormonedas == 1 && Misiones.activada1 == true) 
        {
            misiones.Completarmision("cajas", 1);
        }
        if (Inventario.contadormonedas == 1 && Misiones.activada2 == true)
        {
            misiones.Completarmision("monedas", 1);
        }
        if (Inventario.contadormonedas == 1 && Misiones.activada3 == true)
        {
            misiones.Completarmision("cajas", 2);
        }
        if (Inventario.contadormonedas == 1 && Misiones.activada4 == true)
        {
            misiones.Completarmision("monedas", 2);
        }


        if (Input.GetKeyDown(KeyCode.Z))
        {
            misiones.Cancelarmision("cajas", 1);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            misiones.Cancelarmision("cajas", 2);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            misiones.Cancelarmision("monedas", 1);
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            misiones.Cancelarmision("monedas", 2);
        }
    }
}
