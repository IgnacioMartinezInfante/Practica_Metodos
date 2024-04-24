using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misiones : MonoBehaviour
{
    public static bool activada1 = false;
    public static bool activada2 = false;
    public static bool activada3 = false;
    public static bool activada4 = false;
    public void Activarmision(string objetivo, int nivel)
    {
        if (nivel == 1)
        {
            if (objetivo == "cajas")
            {
                Debug.Log("Misión cajas nivel 1 activada");
                activada1 = true;
            }
            else
            {
                Debug.Log("Misión monedas nivel 1 activada");
                activada2 = true;
            }
        }
        else if (objetivo == "cajas")
        {
            Debug.Log("Misión cajas nivel 2 activada");
            activada3 = true;
        }
        else
        {
            Debug.Log("Misión monedas nivel 2 activada");
            activada4 = true;
        }

    }

    public void Completarmision(string objetivo, int nivel)
    {
        if (nivel == 1)
        {
            if (objetivo == "cajas")
            {
                Debug.Log("Misión cajas nivel 1 completada");
                activada1 = false;
            }
            else
            {
                Debug.Log("Misión monedas nivel 1 completada");
                activada2 = false;
            }
        }
        else if (objetivo == "cajas")
        {
            Debug.Log("Misión cajas nivel 2 completada");
            activada3 = false;
        }
        else
        {
            Debug.Log("Misión monedas nivel 2 completada");
            activada4 = false;
        }

    }

    public void Cancelarmision(string objetivo, int nivel)
    {
        if (nivel == 1)
        {
            if (objetivo == "cajas")
            {
                Debug.Log("Misión cajas nivel 1 cancelada");
                activada1 = false;
            }
            else
            {
                Debug.Log("Misión monedas nivel 1 cancelada");
                activada2 = false;
            }
        }
        else if (objetivo == "cajas")
        {
            Debug.Log("Misión cajas nivel 2 cancelada");
            activada3 = false;
        }
        else
        {
            Debug.Log("Misión monedas nivel 2 cancelada");
            activada4 = false;
        }

    }
}
